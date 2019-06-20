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
            viewKodowanie.Kodowanie1 += view_encoding_AES;
            viewKodowanie.Dekodowanie1 += view_decoding_AES;
        }
        private void view_encoding_AES()
        {
            model.Encrypt_Kodowanie1(viewKodowanie.Key, viewKodowanie.pathcoder,viewKodowanie.InFile,"Kodowanie_AES");
        }
        private void view_decoding_AES()
        {
            model.Decrypt_Kodowanie1(viewKodowanie.Key, viewKodowanie.pathcoder,viewKodowanie.InFile,"Dekodowanie_AES");
        }
    }
}
