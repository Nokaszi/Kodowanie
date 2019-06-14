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
    public partial class Form1 : Form,IView
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Properties
        public string CurrentPath
        {
            get
            {
                return textPath.Text;
            }
            set
            {
                textPath.Text = value;
            }
        }
        public string[] Drives
        {
            set
            {
                comboDrives.Items.Clear();
                comboDrives.Items.AddRange(value);
                comboDrives.Refresh();
            }
        }
        public string[] Files
        {
            set
            {
                listFiles.Items.Clear();
                if (CurrentPath.Length > 3)
                {
                    listFiles.Items.Add("...");
                }
                listFiles.Items.AddRange(value);
                listFiles.Refresh();

            }
        }
        #endregion

        #region Events
        public event Action LoadingFiles;
        public event Action LoadingDrives;
        #endregion

        private void Form_LoadingFiles()
        {
            if (LoadingFiles != null)
            {
                LoadingFiles();
            }
            buttonDekodowanie.Enabled = false;
            buttonKodowanie.Enabled = false;
        }
        private void Form_LoadingDrives()
        {
            if (LoadingDrives != null)
            {
                LoadingDrives();
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Form_LoadingDrives();
            CurrentPath = "C:\\";
            Form_LoadingFiles();
            
        }

        private void comboDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboDrives.SelectedIndex>-1)
            CurrentPath = comboDrives.SelectedItem.ToString();
            Form_LoadingFiles();
        }

        private void listFiles_DoubleClick(object sender, EventArgs e)
        {
            if (listFiles.SelectedItem != null && listFiles.SelectedIndex > -1 && listFiles.SelectedItem.ToString().StartsWith("<F>") == false)
            {
                if (listFiles.SelectedItem.ToString().Equals("..."))
                {
                    CurrentPath = CurrentPath.Remove(CurrentPath.Length - 1);
                    CurrentPath = CurrentPath.Remove(CurrentPath.LastIndexOf(@"\") + 1);
                    LoadingFiles();

                }
                else
                {
                    if (LoadingFiles != null)
                    {
                        CurrentPath += listFiles.SelectedItem.ToString().Remove(0, 3) + "\\";
                        LoadingFiles();
                    }
                }

            }
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listFiles.SelectedIndex>0)
            {
                buttonKodowanie.Enabled = true;
                buttonDekodowanie.Enabled = true;
            }
            else
            {
                buttonKodowanie.Enabled = false;
                buttonDekodowanie.Enabled = false;
            }
        }

        private void buttonKodowanie_Click(object sender, EventArgs e)
        {
            Form3 windowKodowanie = new Form3("Kodowanie");
            windowKodowanie.ShowDialog();
        }

        private void buttonDekodowanie_Click(object sender, EventArgs e)
        {
            Form3 windowKodowanie = new Form3("Dekodowanie");
            windowKodowanie.ShowDialog();
        }
    }
}
