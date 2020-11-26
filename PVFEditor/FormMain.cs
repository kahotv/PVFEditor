using PVFEditor.Services;
using PVFServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Grpc.Core;
using Utils;
using System.IO;
using Google.Protobuf.WellKnownTypes;
using System.Diagnostics;

namespace PVFEditor
{
    public partial class FormMain : Form
    {
        StateInfo _stateinfo = new StateInfo();
        SaveFileDialog m_fsave = new SaveFileDialog() { Title = "请选择要打补丁的PVF", Filter = "PVF文件(*.pvf)|*.pvf|所有文件(*.*)|*.*", RestoreDirectory = true };
        FolderBrowserDialog m_floder = new FolderBrowserDialog() { ShowNewFolderButton = true };
        FolderBrowserDialog m_floder_import = new FolderBrowserDialog() { ShowNewFolderButton = false, Description = "选择需合并的PVF跟目录" };

        bool _editing = false;
        bool Editing
        {
            get { return _editing; }
            set { _editing = value; OnEditingChanged(_editing); }
        }

        int _editScriptId = -1;
        int EditScriptId        //记录当前打开的文件ID
        {
            get { return _editScriptId; }
            set { _editScriptId = value; OnEditScriptIdChanged(_editScriptId); }
        }

        string _editScriptPath = "";
        string EditScriptPath
        {
            get { return _editScriptPath; }
            set { _editScriptPath = value; OnEditScriptPathChaned(_editScriptPath); }
        }



        public FormMain()
        {
            InitializeComponent();

            InitStaticResource();
            InitMenusEvent();

            InitState();

        }

        void InitStaticResource()
        {
            this.pg.SelectedObject = _stateinfo;

            var nameMap = new Dictionary<string, string>()
            {
                ["Equ"] = "装备",
                ["Dgn"] = "副本",
                ["Mob"] = "怪物",
                ["Qst"] = "任务",
                ["Stk"] = "物品",
                ["Skl"] = "技能",
                //["Xui"] = "UI",
                //["Lst"] = "列表",
            };

            var list = EnumHelper.GetEnumList(typeof(PVFServices.SearchScriptRequest.Types.SearchType));

            list = list.Where(p => nameMap.ContainsKey(p.Name)).Select(p => new EnumHelper.EnumInfo 
            {
                Name = nameMap[p.Name],
                Value = p.Value
            }).ToArray();

            this.cbSearchType.Items.AddRange(list);
            this.cbSearchType.SelectedIndex = 0;
        }

        void InitState()
        {
            Editing = false;
            EditScriptId = -1;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CheckEditState();
        }

        private void MenuFileClose_Click(object sender, EventArgs e)
        {
            pvf.CloseContext(new CloseContextRequest());
            InitState();
            CheckEditState();
        }

        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            pvf.CreateContext(new CreateContextRequest());
            CheckEditState();
        }

        private PVFServices.Pvf.PvfClient pvf =>
            PvfServicesClient.GetInterface();

        //打开Context变动
        private void OnEditingChanged(bool editing)
        {
            if (editing)
            {
                menuFileOpen.Enabled = false;
                menuFileClose.Enabled = true;
                menuFileExportPatch.Enabled = true;
                panel_search.Enabled = true;
                ShowDirTree();
            }
            else
            {
                menuFileOpen.Enabled = true;
                menuFileClose.Enabled = false;
                menuFileExportPatch.Enabled = false;
                panel_search.Enabled = false;
                CloseDirTree();
            }
        }

        //打开文件变动
        private void OnEditScriptIdChanged(int fileid)
        {
            _stateinfo.EditFileIndex = fileid;
            if (fileid >= 0)
            {
                //打开了文件
                panel_control.Enabled = true;
            }
            else
            {
                panel_control.Enabled = false;
            }
            pg.Refresh();
        }
        private void OnEditScriptPathChaned(string path)
        {
            _stateinfo.EditFileName = Path.GetFileName(path);
            pg.Refresh();
        }

        private void InitMenusEvent()
        {
            menuFileOpen.Click += MenuFileOpen_Click;           //打开Context
            menuFileClose.Click += MenuFileClose_Click;         //关闭Context
            menuEditDelete.Click += MenuEditDelete_Click;       //删除修改
            menuFileExportPatch.Click += MenuFileExportPatch_Click;
            menuEditPSkill.Click += MenuEditPSkill_Click;
            menuEditPSY.Click += MenuEditPSY_Click;
            menuEditImport.Click += MenuEditImport_Click;


            tvAll.BeforeExpand += TvAll_BeforeExpand;                           //动态加载


            tvAll.NodeMouseDoubleClick += TvAll_NodeMouseDoubleClick;            //树形列表双击
            tvEditing.NodeMouseDoubleClick += TvAll_NodeMouseDoubleClick;        //树形列表双击
            tvSearch.NodeMouseDoubleClick += TvAll_NodeMouseDoubleClick;         //树形列表双击
        }

        private void MenuEditImport_Click(object sender, EventArgs e)
        {
            var res = m_floder_import.ShowDialog();
            if (res != System.Windows.Forms.DialogResult.OK)
                return;

            //不合并.bak文件
            string[] fis = Directory.GetFiles(m_floder_import.SelectedPath, "*", SearchOption.AllDirectories);
            fis = fis.Where(p => !p.Contains(".bak")).ToArray();

            //文件超过50个则提示
            if (fis.Length > 50)
            {
                if (MessageBox.Show("需合并的文件超过50个(共" + fis.Length + "个文件),是否继续？", "警告", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
            }

            //合并
            Stopwatch sw = new Stopwatch();
            int count = 0;
            for(int i = 0;i < fis.Length; i++)
            {
                //读出文件
                string strfile = File.ReadAllText(fis[i], Encoding.UTF8);
                string path = fis[i].Replace(m_floder_import.SelectedPath + "\\", "");

                var r = pvf.WriteScript(new WriteScriptRequest() { Fileid = -1, Path = path, Script = strfile });

                if(r != null)
                {
                    count++;
                }
            }

            MessageBox.Show($"完成，成功{count}/{fis.Length}");
            CheckEditState();
        }

        //处理圣耀
        private void MenuEditPSY_Click(object sender, EventArgs e)
        {
            var r = pvf.PSY(new Empty());
            if(r != null)
            {
                MessageBox.Show($"处理完成，共{r.Count}个文件");
                CheckEditState();
            }
        }

        //处理技能
        private void MenuEditPSkill_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var r = pvf.PSkill(new Empty());
            if(r != null)
            {
                sw.Stop();
                MessageBox.Show($"处理完成，共{r.Count}文件，耗时{sw.ElapsedMilliseconds}ms");
                CheckEditState();
            }
        }

        //对PVF打补丁
        private void MenuFileExportPatch_Click(object sender, EventArgs e)
        {
            //选择PVF文件
            DialogResult dr = m_fsave.ShowDialog();
            if (dr != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            var source = File.ReadAllBytes(m_fsave.FileName);

            var r = pvf.GetPatchData(new Google.Protobuf.WellKnownTypes.Empty());
            var patch = r.Data.ToArray();

            var patchDec = Util.deCompressBytes(patch, 0, patch.Length);
            
            var target = xdelta3.net.Xdelta3Lib.Decode(source, patchDec);

            string filetarget = Path.Combine(
                Path.GetDirectoryName(m_fsave.FileName),
                Path.GetFileNameWithoutExtension(m_fsave.FileName) + 
                DateTime.Now.ToString("yyyyMMddHHmmss") + ".pvf");
            using (FileStream fs = new FileStream(filetarget, FileMode.Create))
            {
                fs.Write(target.ToArray(), 0, target.Length);
            }

            MessageBox.Show("导出成功:" + filetarget);
        }

        private void tvEditing_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            if (e.Node.Parent == null || e.Node == null)
                return;
            if (e.Node.Tag is int)
            {
                int fileid = (int)e.Node.Tag;
                if (fileid > 0)
                {
                    tvEditing.SelectedNode = e.Node;
                    cmsTreeViewEditing.Show(tvEditing, e.X, e.Y);
                }
            }

        }
        private void MenuEditDelete_Click(object sender, EventArgs e)
        {
            //删除修改
            TreeNode node = tvEditing.SelectedNode;
            if (node == null)
                return;

            if (node.Tag is int && (int)node.Tag > 0)
            {
                pvf.CancelScript(new CancelScriptRequest() { Fileid = (int)node.Tag });
                CheckEditState();
            }
        }

        private void TvAll_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if ((int)e.Node.Tag > 0)
            {
                this.ReadScript((int)e.Node.Tag, e.Node.Name);
            }
        }

        private void TvAll_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;

            if ((int)node.Tag == -1)
            {
                //展开
                node.Nodes.Clear();
                ExpandTreeNodes(node.Nodes, node.Name);
                node.Tag = -2;  //设置为已展开
            }

        }

        private void CheckEditState()
        {
            var resp = pvf.GetContext(new PVFServices.GetContextRequest());

            tvEditing.Nodes.Clear();

            this.Editing = resp.Editing;

            tpEditing.Text = string.Format("{0}({1})", tpEditing.Tag.ToString(), resp.Infos.Count);

            //填充属性表
            _stateinfo.Guid = resp.Guid;
            _stateinfo.PackTime = resp.Packtime;
            _stateinfo.FileCount = resp.Filecount;
            _stateinfo.EditFileCount = resp.Infos.Count;
            pg.Refresh();
            //填充treeview
            FillTreeNode(tvEditing, resp.Infos.Select(p=>new MFileInfo
            {
                Id = p.Id,
                Name = p.Name,
                Path = p.Path
            }));
        }

        void FillTreeNode(TreeView tv,IEnumerable<MFileInfo> list)
        {
            tv.Nodes.Clear();
            foreach (var item in list)
            {
                string[] paths = item.Path.Split(new char[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (paths.Length == 0 && string.IsNullOrWhiteSpace(item.Name))
                {
                    MessageBox.Show("空文件");
                    continue;
                }

                if (paths.Length == 0)
                {
                    //顶层目录的文件
                    TreeNode node = tv.Nodes.Find("/", false).FirstOrDefault();
                    if (node == null)
                    {
                        node = new TreeNode("/") { Tag = -1, Name = "/" };
                        tv.Nodes.Add(node);
                    }

                    FillTreeNode(node, paths, 0, item.Name, item.Id);
                }
                else
                {
                    //非顶层
                    string topname = paths[0];
                    TreeNode node = tv.Nodes.Find(topname, false).FirstOrDefault();
                    if (node == null)
                    {
                        node = new TreeNode(topname) { Tag = -1, Name = topname };
                        tv.Nodes.Add(node);
                    }

                    FillTreeNode(node, paths, 1, item.Name, item.Id);
                }
            }
        }

        void FillTreeNode(TreeNode node, string[] paths, int deep, string filename, int fileid)
        {
            if (paths.Length == deep)
            {
                //寻找是否已存在
                string name = node.Name + "/" + filename;
                TreeNode sub = node.Nodes.Find(name, false).FirstOrDefault();
                if (sub == null)
                {
                    sub = new TreeNode()
                    {
                        Text = filename,
                        Name = name,
                        Tag = fileid        //is file
                    };
                    node.Nodes.Add(sub);
                }
            }
            else
            {
                //寻找是否已经存在
                string topname = paths[deep];
                string name = node.Name + "/" + topname;
                TreeNode sub = node.Nodes.Find(name, false).FirstOrDefault();
                if (sub == null)
                {
                    sub = new TreeNode()
                    {
                        Text = topname,
                        Name = name,
                        Tag = -1        //is directory
                    };

                    node.Nodes.Add(sub);
                }

                FillTreeNode(sub, paths, deep + 1, filename, fileid);
            }
        }


        private void ShowDirTree()
        {
            if (tvAll.Nodes.Count == 0)
            {
                //首次展开
                ExpandTreeNodes(tvAll.Nodes, "");
            }

            tvAll.Enabled = true;
            tvSearch.Enabled = true;
        }
        private void CloseDirTree()
        {
            tvAll.Enabled = false;
            tvSearch.Enabled = false;
        }

        private void ExpandTreeNodes(TreeNodeCollection nodes, string dir)
        {
            var r = pvf.ExpandPath(new ExpandPathRequest() { Path = dir });

            var listfiles = r.Infos.Where(p => p.Fileid >= 0).Select(p => new TreeNode()
            {
                Text = p.Name,
                Name = $"{dir}/{p.Name}",
                Tag = p.Fileid
            }).ToArray();
            var list = r.Infos.Where(p => p.Fileid < 0).Select(p => new TreeNode()
            {
                Text = p.Name,
                Name = $"{dir}/{p.Name}",
                Tag = p.Fileid,
            }).ToArray();

            foreach (var item in list)
            {
                item.Nodes.Add(new TreeNode()); //空Item用于显示+号，展开前要移除此项
            }

            if (list.Length == 0 && listfiles.Length != 0)
            {
                //只有文件
                nodes.AddRange(listfiles);  //文件直接添加
            }
            else if (list.Length != 0 && listfiles.Length == 0)
            {
                //只有目录
                nodes.AddRange(list);
            }
            else if (list.Length != 0 && listfiles.Length != 0)
            {
                //有文件有目录
                nodes.Add(new TreeNode("/", listfiles) { Tag = -2, Name = dir });   //文件放入/，并且路径设置为与父节点相同
                nodes.AddRange(list);
            }
            else
            {
                //没有文件和目录，不会发生这情况
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = tbSearchTxt.Text;
            var type = (SearchScriptRequest.Types.SearchType)((EnumHelper.EnumInfo)cbSearchType.SelectedItem).Value;
            bool searhPath = cbSearchPath.Checked;

            if (string.IsNullOrWhiteSpace(txt))
            {
                MessageBox.Show("请输入搜索内容");
                return;
            }

            var resp = pvf.SearchScript(new SearchScriptRequest()
            {
                Type = type,
                Txt = txt,
                Bpath = searhPath
            });

            if (resp == null || resp.Infos.Count == 0)
            {
                MessageBox.Show("没搜到!");
                return;
            }

            //填充到搜索列表
            FillTreeNode(tvSearch, resp.Infos);
            tpSearch.Text = tpSearch.Tag + "(" + resp.Infos.Count + ")";
        }

        //读取/展开
        private void btnReadScript_Click(object sender, EventArgs e)
        {
            MessageBox.Show("不可用");

        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            pvf.WriteScript(new WriteScriptRequest() { Fileid = EditScriptId, Script = tbScript.Text });
            CheckEditState();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.ReadScript(this.EditScriptId, this.EditScriptPath);
        }

        private void btnReadSource_Click(object sender, EventArgs e)
        {
            this.ReadScriptOld(EditScriptId, EditScriptPath);
        }

        private void ReadScript(int fileid, string path)
        {
            if (fileid >= 0)
            {
                this.EditScriptPath = path;
                this.EditScriptId = fileid;
                //是文件，就读取
                tbScript.Enabled = false;
                var r = pvf.ReadScript(new ReadScriptRequest() { Fileid = fileid });
                tbScript.Text = r.Script;
                tbScript.Enabled = true;
                tbFilePath.Text = path;
                _stateinfo.NameTag = FixTagName(r.Nametag);
                pg.Refresh();
            }
        }

        private void ReadScriptOld(int fileid, string path)
        {
            if (fileid >= 0)
            {
                this.EditScriptPath = path;
                this.EditScriptId = fileid;

                //是文件，就读取
                tbScript.Enabled = false;
                var r = pvf.ReadScriptOld(new ReadScriptOldRequest() { Fileid = fileid });
                tbScript.Text = r.Script;
                tbScript.Enabled = true;
                tbFilePath.Text = path;
                _stateinfo.NameTag = FixTagName(r.Nametag);
                pg.Refresh();
            }
        }

        //导出文件
        private void btnExportScript_Click(object sender, EventArgs e)
        {
            var r = m_floder.ShowDialog();
            if (r == DialogResult.OK)
            {
                //拿到相对路径
                string savepath = string.Join("\\", (m_floder.SelectedPath + "\\" + _editScriptPath).Split(new char[] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries));

                if (!Directory.Exists(Path.GetDirectoryName(savepath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(savepath));
                }

                File.WriteAllText(savepath, tbScript.Text, Encoding.UTF8);
            }
        }

        private string FixTagName(string tagname)
        {
            if (!string.IsNullOrEmpty(tagname))
            {
                int idx = tagname.IndexOf('>');
                if (idx > 0)
                {
                    return tagname.Substring(idx + 1, tagname.Length - idx - 1);

                }
                return tagname;
            }
            return tagname;
        }
    }
    public class StateInfo
    {
        [CategoryAttribute("PVF属性"), DisplayNameAttribute("PVF编号"), ReadOnlyAttribute(true)]
        public string Guid { set; get; }
        [CategoryAttribute("PVF属性"), DisplayNameAttribute("打包时间"), ReadOnlyAttribute(true)]
        public string PackTime { set; get; }
        [CategoryAttribute("PVF属性"), DisplayNameAttribute("文件总数"), ReadOnlyAttribute(true)]
        public int FileCount { set; get; }
        [CategoryAttribute("当前状态"), DisplayNameAttribute("改动数量"), ReadOnlyAttribute(true)]
        public int EditFileCount { set; get; }
        [CategoryAttribute("当前状态"), DisplayNameAttribute("当前文件"), ReadOnlyAttribute(true)]
        public string EditFileName { set; get; }
        [CategoryAttribute("当前状态"), DisplayNameAttribute("当前编号"), ReadOnlyAttribute(true)]
        public int EditFileIndex { set; get; }
        [CategoryAttribute("当前状态"), DisplayNameAttribute("[name]"), ReadOnlyAttribute(true)]
        public string NameTag { set; get; }
    }

}
