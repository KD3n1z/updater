using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace updater
{
    internal static class Program
    {
        public static string appName = "?";
        public static string url = "?";
        public static string path = "?";

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            foreach(string arg in args)
            {
                if (arg.StartsWith("url="))
                {
                    url = arg.Remove(0, "url=".Length);
                }
                else if (arg.StartsWith("app="))
                {
                    appName = arg.Remove(0, "app=".Length);
                }
                else if (arg.StartsWith("path="))
                {
                    path = arg.Remove(0, "path=".Length);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
