using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Westwind.Utilities.Configuration;

namespace SimpleWebHost
{
    public class AppConfig : AppConfiguration
    {
        public string FolderToHost { get; set; }
        public int Port { get; set; }

        public AppConfig()
        {
            Port = 9050;
            FolderToHost = "c:\\simpleWeb";
        }
    }
}
