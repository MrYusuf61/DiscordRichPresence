using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRP
{
    public static class Logger
    {
        public static void Log(string text)
        {
            try
            {
                if (!File.Exists(".\\errors.log"))
                    File.WriteAllText(".\\errors.log", "MrYusuf", Encoding.UTF8);

                text = File.ReadAllText(".\\errors.log") + $"\n[{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.ffff")}] " + text;
                FileStream fs = new FileStream(".\\errors.log", FileMode.OpenOrCreate);
                var tempBytes = Encoding.UTF8.GetBytes(text);
                fs.Write(tempBytes, 0, tempBytes.Length);
                fs.Flush();
                fs.Close();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                if (Debugger.IsAttached)
                    Debugger.Break();
            }
        }

        public static void Error(Exception ex)
        {
            var st = new StackTrace(ex, true);
            var lines = "";
            foreach (var frame in st.GetFrames())
            {
                if (!string.IsNullOrEmpty(frame.GetFileName()))
                    lines += frame.GetFileName().Split('\\').Last() + ":" + frame.GetFileLineNumber() + "\n";
            }
            Log(lines + "\t" + ex.Message);
        }
    }
}
