using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineSimulator
{
    public static class AppEngine
    {
        // Private variables
        private static List<FileInfo> _databaseFiles;

        private static string _currentDbName;

        // Public properties
        public static string CurrentDbName
        {
            get { return _currentDbName; }
            set { _currentDbName = value; }
        }

        public static List<string> DbFilesNameList
        {
            get
            {
                return _databaseFiles.Select(s => s.Name).ToList();
            }
        }


        // Methods
        public static void GatherDbFiles(string ext)
        {
            _databaseFiles = new List<FileInfo>();
            var files = new DirectoryInfo(@".\").GetFiles($@"*.{ext}");

            if (!files.Any())
                throw new Exception("No database files available.");

            _databaseFiles.AddRange(files);
            _currentDbName = files.First().Name;
        }

        public static double GetCurrentDbSize()
        {
            var sizeInBytes = _databaseFiles.First(s => s.Name == _currentDbName).Length;
            
            return ConvertBytesToKilobytes(sizeInBytes);
        }

        private static double ConvertBytesToKilobytes(long bytes)
        {
            return ((bytes/1024f)/1024f)*1000;
        }


    }
}
