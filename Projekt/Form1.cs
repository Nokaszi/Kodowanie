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
    }
}
