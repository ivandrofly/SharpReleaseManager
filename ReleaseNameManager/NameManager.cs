using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseNameManager
{
    public class NameManager : IEnumerable<KeyValuePair<string, HashSet<string>>>
    {
        /// <summary>
        /// Key = File MD5
        /// HashSet = File names with shares same md5.
        /// </summary>
        private readonly Dictionary<string, HashSet<string>> _releaseDictionary = new Dictionary<string, HashSet<string>>();

        public void Add(SubtitleFile subfile)
        {
            // Store the hash if isn't already contained.
            if (!_releaseDictionary.ContainsKey(subfile.MD5Hash))
            {
                _releaseDictionary.Add(subfile.MD5Hash, new HashSet<string>());
            }
            // TODO: Implement.
            //string validatedName = ValidateReleaseName(subfile.FileName);
            string validatedName = subfile.FileName;
            HashSet<string> releaseNames = _releaseDictionary[subfile.MD5Hash];
            // Contains = O(1).
            if (!releaseNames.Contains(validatedName))
            {
                releaseNames.Add(validatedName);
            }
        }

        public static string ValidateReleaseName(string name)
        {
            throw new NotImplementedException("ValidateReleaseName()");
        }

        public IEnumerator<KeyValuePair<string, HashSet<string>>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<string, HashSet<string>>>)_releaseDictionary).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<string, HashSet<string>>>)_releaseDictionary).GetEnumerator();
        }

        //IEnumerator<KeyValuePair<string, HashSet<string>>> IEnumerable<KeyValuePair<string, HashSet<string>>>.GetEnumerator()
        //{
        //    return _releaseDictionary.GetEnumerator();
        //    //foreach (KeyValuePair<string, HashSet<string>> kvp in _releaseDictionary)
        //    //{
        //    //    yield return kvp;
        //    //    //foreach (string releaseName in _releaseDictionary[kvp.Key])
        //    //    //{
        //    //    //    yield return releaseName;
        //    //    //}
        //    //}
        //}

        //public ICollection<string> GetGroupNames()
        //{
        //    // TODO: Only use .Count if its time-complexity is O(1);
        //    ICollection<string> groupNames = new List<string>(_releaseDictionary.Keys.Count);
        //    foreach (var key in _releaseDictionary.Keys)
        //    {
        //        groupNames.Add(key);
        //    }
        //    return groupNames;
        //}
    }
}
