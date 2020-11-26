using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace PVFEditor
{
    public class Util
    {
        /// <summary>
        /// 压缩字节数组
        /// </summary>
        /// <param name="sourceByte">需要被压缩的字节数组</param>
        /// <returns>压缩后的字节数组</returns>
        public static byte[] compressBytes(byte[] sourceByte, int start, int length)
        {
            using (MemoryStream mout = new MemoryStream())
            {
                using (var streamZOut = new GZipStream(mout, CompressionLevel.Optimal))
                {
                    streamZOut.Write(sourceByte, start, length);
                }
                return mout.ToArray();
            }
        }
        /// <summary>
        /// 解压缩字节数组
        /// </summary>
        /// <param name="sourceByte">需要被解压缩的字节数组</param>
        /// <returns>解压后的字节数组</returns>
        public static byte[] deCompressBytes(byte[] sourceByte, int start, int length)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (MemoryStream mout = new MemoryStream(sourceByte))
                {
                    using (var streamZOut = new GZipStream(mout, CompressionMode.Decompress))
                    {
                        streamZOut.CopyTo(ms);
                    }
                }
                return ms.ToArray();
            }
        }
    }
}
