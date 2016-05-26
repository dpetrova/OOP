using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.UI
{
    using System.IO;
    using Interfaces;

    public class FileHandler : IFileHandler
    {
        public string FileRead(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
