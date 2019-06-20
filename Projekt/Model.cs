using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Projekt
{
    class Model:Cryptography
    {
        public string[] GetDrives
        {
            get
            {
                List<string> disks = new List<string>();
                DriveInfo[] allDisks = DriveInfo.GetDrives();
                foreach (DriveInfo d in allDisks)
                {

                    if (d.IsReady == true) disks.Add(Convert.ToString(d));
                }

                return disks.ToArray();
            }
        }
        public string[] GetFiles(string CurrentPath)
        {
            List<string> Files = new List<string>();
            string[] Paths = Directory.GetDirectories(CurrentPath);
            foreach (string s in Paths)
            {
                Files.Add("<D>" + Path.GetFileName(s));
            }
            Paths = Directory.GetFiles(CurrentPath);
            foreach (string f in Paths)
            {
                Files.Add("<F>" + Path.GetFileName(f));
            }
            return Files.ToArray();
            
        }
        public void Encrypt_Kodowanie1(string key, string path, bool inFile, string outputPath)
        {
            if (inFile == true)
            {
                File.WriteAllText("moje_zdjęcie.jpg", key);
            }
            if (File.Exists(path))
            {
                Encrypt_AES(key, path,outputPath);
            }
            if (Directory.Exists(path))
            {

                if (!Directory.Exists(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                }
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    string name = Path.GetFileName(file);

                    Encrypt_Kodowanie1(key, file, false, Path.Combine(outputPath,name));
                }
                string[] folders = Directory.GetDirectories(path);
                foreach (string folder in folders)
                {
                    string name = Path.GetFileName(folder);
                    Encrypt_Kodowanie1(key, folder, false, Path.Combine(outputPath, name));
                }
            }
        
        }
        public void Decrypt_Kodowanie1(string key, string path, bool withFile, string outputPath)
        {
            if (File.Exists(path))
            {
                if (withFile == true && File.Exists(key))
                {
                    key = File.ReadAllText(key);
                }
                Decrypt_AES(key, path, outputPath);
            }
            if (Directory.Exists(path))
            {

                if (!Directory.Exists(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                }
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    string name = Path.GetFileName(file);

                    Decrypt_Kodowanie1(key, file, false, Path.Combine(outputPath, name));
                }
                string[] folders = Directory.GetDirectories(path);
                foreach (string folder in folders)
                {
                    string name = Path.GetFileName(folder);
                    Decrypt_Kodowanie1(key, folder, false, Path.Combine(outputPath, name));
                }
            }
        }
        
    }
}
