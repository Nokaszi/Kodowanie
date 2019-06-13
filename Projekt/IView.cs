using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    interface IView
    {
        string CurrentPath { get; set; }
        string[] Drives { set; }
        event Action LoadingFiles;
        event Action LoadingDrives;
        string[] Files { set; }
    }
}
