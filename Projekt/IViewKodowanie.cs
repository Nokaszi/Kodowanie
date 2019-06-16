using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    interface IViewKodowanie
    {
        string decision { get; set; }
        string Key { get; set; }
        bool InFile { get; }
        string pathcoder { get; }

        event Action Kodowanie1;
        event Action Kodowanie2;
        event Action Kodowanie3;
        event Action Dekodowanie1;
        event Action Dekodowanie2;
        event Action Dekodowanie3;
        event Action Generuj;
    }
}
