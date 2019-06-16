﻿using System;
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
        public void Encrypt_Kodowanie1(string key, string file)
        {
            if (File.Exists(file))
            {
                string[] text = File.ReadAllLines(file);
                List<string> lines = new List<string>();
                foreach (string line in text)
                {
                    lines.Add(Encrypt_AES(key, line));

                }

                File.WriteAllLines(Path.GetFileName(file), lines.ToArray());
                MessageBox.Show("fungo");
            }
            else MessageBox.Show("Nie fungo");
        }
        
    }
}
