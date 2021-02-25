using PVFEditor.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVFEditor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginServicesClient.Login(tbName.Text, tbPwd.Text);
                PvfServicesClient.Init(errmsg =>
                {
                    MessageBox.Show(errmsg);
                },LoginServicesClient.GetHttpClient());


                this.Hide();

                FormMain main = new FormMain();
                main.ShowDialog();
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
