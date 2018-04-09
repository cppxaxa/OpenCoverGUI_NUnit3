using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCoverLibrary
{
    public class DLLUtilities
    {
        private void AddPath<TInfo>(ref List<TInfo> filePathList, string currentDirectory, int level) where TInfo : class
        {
            if (level == 0)
                return;

            var directoryInfo = new DirectoryInfo(currentDirectory);

            foreach (var path in directoryInfo.GetDirectories())
            {
                AddPath(ref filePathList, path.FullName, level - 1);
            }

            foreach (var file in directoryInfo.GetFiles())
            {
                if (file.Extension == ".dll")
                {
                    filePathList.Add(file.FullName as TInfo);
                }
            }
        }

        public List<TInfo> ListAllDLLFiles<TInfo>(string rootPath, int level = 6) where TInfo : class
        {
            List<TInfo> filePath = new List<TInfo>();

            AddPath(ref filePath, rootPath, level);

            return filePath;
        }
    }
}
