using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseNameManager
{
    public class SubtitleFile
    {
        private readonly string _md5hash;

        public string MD5Hash
        {
            get { return _md5hash; }
        }

        public string FileName { get; private set; }

        public SubtitleFile(string fileName)
        {
            _md5hash = Utils.ComputeHash(fileName);
            FileName = Path.GetFileNameWithoutExtension(fileName);
        }

    }
}
