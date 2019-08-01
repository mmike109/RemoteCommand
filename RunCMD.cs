using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RemoteCommand
{
    class RunCMD
    {



        //public static void Main()
        //{
        //    int i = 0;
        //    ExcelReader e = new ExcelReader(@"C:\DFO-MPO\UerWin10CleanUp.xlsx", 1);
        //    Process process = new Process();
        //    ProcessStartInfo startInfo = new ProcessStartInfo();
        //    startInfo.FileName = "cmd.exe";
        //    e.ReadCell(i, 0);
        //    //startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
        //    process.StartInfo = startInfo;
        //    process.Start();
        //}

        //public static string ExecuteCommandAsAdmin(string command,string compNmae)
            public static string ExecuteCommandAsAdmin(string command)
        {

            ProcessStartInfo procStartInfo = new ProcessStartInfo()
            {
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                FileName = "runas.exe",
                Arguments = "/user:Administrator \"cmd /K " + command + "\""
            };

            using (Process proc = new Process())
            {
                proc.StartInfo = procStartInfo;
                proc.Start();

                string output = proc.StandardOutput.ReadToEnd();

                if (string.IsNullOrEmpty(output))
                    output = proc.StandardError.ReadToEnd();

                return output;
            }
        }

    }
}
