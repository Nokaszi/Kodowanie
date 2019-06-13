using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projekt
{
    class Model
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
    }
}
