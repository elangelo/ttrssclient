using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace ttrssdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = ConfigurationManager.AppSettings["server"];
            var username = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["password"];


        }
    }
}
