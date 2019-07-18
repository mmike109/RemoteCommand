using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteCommand
{
    class Installer
    {

        public string FileName { get; set; }
        public string SourceFolder { get; set; }
        public string TargetFolder { get; set; }


        public Installer(string fileName, string targetFolder, string sourceFolder)
        {
            FileName = fileName;
            TargetFolder = targetFolder;
            SourceFolder = sourceFolder;
        }

  

       
        public void combinePath()
        {
            string sourcePath = Path.Combine(this.SourceFolder, this.FileName);
            string destFile = Path.Combine(this.TargetFolder, this.FileName);
            try { 
            File.Copy(sourcePath, destFile);
            }catch(System.IO.IOException e)
            {
                
                MessageBox.Show(e.Message);
            }catch(System.ArgumentException a)
            {
                MessageBox.Show("Warning File"+ FileName.ToString() + " not Found");
            }
        }
        
    }
}
