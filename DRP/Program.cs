using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DRP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            LoadDlls();
            SetStartup();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TickManager.Start();
            XML.Read();
            Application.ApplicationExit += Application_ApplicationExit;
            Application.ThreadException += Application_ThreadException;

            bool show = true;
            if (args.Length > 0) show = !(args[0].ToLower() == "--noshow");
            Application.Run(new FrmMain(show));

        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Logger.Error(e.Exception);
            Environment.Exit(-1);
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            TickManager.Stop();
        }

        private static void LoadDlls()
        {
            foreach (var item in typeof(Properties.Resources).GetProperties())
            {
                if (item.PropertyType == typeof(byte[]))
                {
                    if (File.Exists($".\\{item.Name.Replace("_", ".")}.dll")) continue;
                    FileStream fs = new FileStream($".\\{item.Name.Replace("_", ".")}.dll", FileMode.Create);
                    var tempFileVar = (byte[])item.GetValue(null, null);
                    fs.Write(tempFileVar, 0, tempFileVar.Length);
                    fs.Flush();
                    fs.Close();
                    fs.Dispose();
                }
            }
        }


        private static void SetStartup()
        {
            try
            {
                var fileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\DRP.cmd";
                if (File.Exists(fileName)) File.Delete(fileName);
                // shortcut :)
                File.WriteAllText(fileName, "cd " + Application.StartupPath + "\nstart DRP.exe --noshow");
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }


        }
    }
}
