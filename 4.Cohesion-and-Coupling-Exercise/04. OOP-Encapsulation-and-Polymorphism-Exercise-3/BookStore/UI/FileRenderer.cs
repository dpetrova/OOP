using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.UI
{
    using System.IO;
    using Interfaces;

    public class FileRenderer : IFileRenderer
    {
        public void WriteLine(string path, string text)
        {
            File.WriteAllText(path, text);
        }
    }
}
