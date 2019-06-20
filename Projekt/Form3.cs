using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form3 : Form, IViewKodowanie
    {
        public Form3(string decision,string file )
        {
            InitializeComponent();
            this.decision = decision+" "+file;
            if(decision=="Kodowanie")
            {
                checkboxToFiles.Text = "Zapisz do pliku";
            }
            else
            {
                checkboxToFiles.Text = "Klucz z pliku";
                buttonGeneruj.Enabled = false;
                buttonGeneruj.Visible = false;
            }
        }
        #region Properties
        public string decision
        {
            get
            {
                return labelTopic.Text.Split(' ')[0];
            }
            set
            {
                labelTopic.Text = value;
            }
        }
        public string pathcoder
        {
            get
            {
                return labelTopic.Text.Split(' ')[1];
            }
        }
        public string Key
        {
            get
            {
                return textKlucz.Text;
            }
            set
            {
                textKlucz.Text = value;
            }
        }
        public bool InFile
        {
            get
            {
                if (checkboxToFiles.Checked == true)
                    return true;
                else
                {
                    return false;
                }
            }
        }
        #endregion
        #region Events
        public event Action Kodowanie1;
        public event Action Kodowanie2;
        public event Action Kodowanie3;
        public event Action Dekodowanie1;
        public event Action Dekodowanie2;
        public event Action Dekodowanie3;
        public event Action Generuj;
        #endregion
        private void buttonKodowanie1_Click(object sender, EventArgs e)
        {
            if(decision.Equals("Kodowanie") && Kodowanie1!=null)
            {
                try
                {
                    Kodowanie1();
                    MessageBox.Show("Kodowanie zakończone sukcesem", "Sukces");
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd", "Error");
                }
            }
            else
            {
                try
                {
                    if (Dekodowanie1 != null)
                    {
                        Dekodowanie1();
                    }
                    MessageBox.Show("Dekodowanie zakończone sukcesem", "Sukces");
                }
                
                catch
                {
                    MessageBox.Show("Wystąpił błąd", "Error");
                }
                
            }

        }

        private void buttonKodowanie2_Click(object sender, EventArgs e)
        {
            if (decision == "Kodowanie" && Kodowanie2 != null)
            {
                Kodowanie2();
            }
            else
            {
                if (Dekodowanie2 != null)
                {
                    Dekodowanie2();
                }
            }
        }

        private void buttonKodowanie3_Click(object sender, EventArgs e)
        {
            if (decision == "Kodowanie" && Kodowanie3 != null)
            {
                Kodowanie3();
            }
            else
            {
                if (Dekodowanie3 != null)
                {
                    Dekodowanie3();
                }
            }
        }

        private void buttonGeneruj_Click(object sender, EventArgs e)
        {
            if (Generuj != null)
            {
                Generuj();
            }
        }
    }
}
