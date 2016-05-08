using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseNameManager
{
    public static class Utils
    {
        public static string ComputeHash(string fileName)
        {
            FileStream fs = null;
            try
            {
                fs = File.OpenRead(fileName);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            using (var md5 = MD5.Create())
            {
                byte[] buffer = md5.ComputeHash(fs);
                fs.Close();
                return BitConverter.ToString(buffer).Replace("-", string.Empty).ToLowerInvariant();
            }
            //return md5.ComputeHash(stream);
        }
    }
}
