namespace Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listFiles = new System.Windows.Forms.ListBox();
            this.buttonKodowanie = new System.Windows.Forms.Button();
            this.buttonDekodowanie = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.comboDrives = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listFiles
            // 
            this.listFiles.BackColor = System.Drawing.Color.Violet;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(12, 92);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(417, 537);
            this.listFiles.TabIndex = 0;
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.listFiles_SelectedIndexChanged);
            this.listFiles.DoubleClick += new System.EventHandler(this.listFiles_DoubleClick);
            // 
            // buttonKodowanie
            // 
            this.buttonKodowanie.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonKodowanie.Location = new System.Drawing.Point(457, 112);
            this.buttonKodowanie.Name = "buttonKodowanie";
            this.buttonKodowanie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonKodowanie.Size = new System.Drawing.Size(153, 66);
            this.buttonKodowanie.TabIndex = 1;
            this.buttonKodowanie.Text = "Kodowanie";
            this.buttonKodowanie.UseVisualStyleBackColor = false;
            this.buttonKodowanie.Click += new System.EventHandler(this.buttonKodowanie_Click);
            // 
            // buttonDekodowanie
            // 
            this.buttonDekodowanie.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDekodowanie.Location = new System.Drawing.Point(457, 184);
            this.buttonDekodowanie.Name = "buttonDekodowanie";
            this.buttonDekodowanie.Size = new System.Drawing.Size(153, 66);
            this.buttonDekodowanie.TabIndex = 2;
            this.buttonDekodowanie.Text = "Dekodowanie";
            this.buttonDekodowanie.UseVisualStyleBackColor = false;
            this.buttonDekodowanie.Click += new System.EventHandler(this.buttonDekodowanie_Click);
            // 
            // textPath
            // 
            this.textPath.Enabled = false;
            this.textPath.Location = new System.Drawing.Point(12, 12);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(417, 20);
            this.textPath.TabIndex = 4;
            // 
            // comboDrives
            // 
            this.comboDrives.FormattingEnabled = true;
            this.comboDrives.Location = new System.Drawing.Point(371, 47);
            this.comboDrives.Name = "comboDrives";
            this.comboDrives.Size = new System.Drawing.Size(58, 21);
            this.comboDrives.TabIndex = 5;
            this.comboDrives.SelectedIndexChanged += new System.EventHandler(this.comboDrives_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 639);
            this.Controls.Add(this.comboDrives);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.buttonDekodowanie);
            this.Controls.Add(this.buttonKodowanie);
            this.Controls.Add(this.listFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.Button buttonKodowanie;
        private System.Windows.Forms.Button buttonDekodowanie;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.ComboBox comboDrives;
    }
}

