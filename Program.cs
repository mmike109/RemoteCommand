using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    

    class Program
    {
        static void Main(string[] args)
        {
          


            string compName = Environment.MachineName;
            //var psExexInstaller = new Installer(@"PsExec.exe", @"C:\Windows\System32", @"\\142.130.107.100\Dump\GornikM");
            //var psInfoInstaller = new Installer(@"PsInfo.exe", @"C:\Windows\System32", @"\\142.130.107.100\Dump\GornikM");


            //psExexInstaller.combinePath();
            //psInfoInstaller.combinePath();

            var excelRead = new ExcelReader(@"C:\DFO-MPO\UerWin10CleanUp.xlsx",1);
            var result = RunCMD.ExecuteCommandAsAdmin(@"ping wnonbur9035507");
            Console.WriteLine(result);
            int i = 0;
            while(i < excelRead.RowCount(0,0))

            {
                i++;
                System.Windows.Forms.MessageBox.Show(excelRead.ReadCell(i, 0));
                // i.ToString();
                // var excecuteAsAdmin = new RunCMD();
                // RunCMD.ExecuteCommandAsAdmin(excelRead.ReadCell(i, 0));
                
                //RunCMD.ExecuteCommandAsAdmin(@"ping wnonbur9035507");
                
                //Process process = new Process();
                //ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.FileName = "cmd.exe";
                ////startInfo.Arguments = "/C copy /b Image1.jpg + Archive.rar Image2.jpg";
                //process.StartInfo = startInfo;
                //process.Start();

                // var proc1 = new ProcessStartInfo();
                // string Command;
                // proc1.UseShellExecute = true;
                // Command = @"ipconfig";
                // proc1.WorkingDirectory = @"C:\Windows\System32";
                // proc1.FileName = @"C:\Windows\System32\cmd.exe";
                //// as admin = proc1.Verb = "runas";
                // proc1.Arguments = "/c " + Command[i];
                // proc1.WindowStyle = ProcessWindowStyle.Maximized;
                // Process.Start(proc1);

            }

           


            //var fileName = "PsExec.exe";
            //var sourceFile = @"C:\Users\GornikM\Downloads\PSTools (3)";
            //string target = @"C:\Windows\System32";
            ////string target = @"C:\DFO-MPO";
            //fsafsafs 
            ////if (!Directory.Exists(target))
            ////{

            ////}

            ////string[] sourcefiles = Directory.GetFiles(sourceFile);

            //string sourcePath = Path.Combine(sourceFile, fileName);
            //string destFile = Path.Combine(target, fileName);
            //File.Copy(sourcePath, destFile);





            //foreach (string source in sourcefiles)
            //{
            //    string fileName = Path.GetFileName(source);
            //    string destFile = Path.Combine(target, fileName);

            //    File.Copy(source, destFile);
            //}



        }
    }
}
