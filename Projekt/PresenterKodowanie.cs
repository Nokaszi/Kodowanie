using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class PresenterKodowanie
    {
        IViewKodowanie viewKodowanie;
        Model model;
        public PresenterKodowanie(Model model, IViewKodowanie viewKodowanie)
        {
            this.model = model;
            this.viewKodowanie = viewKodowanie;
        }
    }
}
