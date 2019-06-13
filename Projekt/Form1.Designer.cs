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
            this.buttonKodowanie1 = new System.Windows.Forms.Button();
            this.buttonKodowanie2 = new System.Windows.Forms.Button();
            this.buttonKodowanie3 = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.comboDrives = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listFiles
            // 
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(12, 92);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(417, 537);
            this.listFiles.TabIndex = 0;
            // 
            // buttonKodowanie1
            // 
            this.buttonKodowanie1.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonKodowanie1.Location = new System.Drawing.Point(457, 112);
            this.buttonKodowanie1.Name = "buttonKodowanie1";
            this.buttonKodowanie1.Size = new System.Drawing.Size(153, 66);
            this.buttonKodowanie1.TabIndex = 1;
            this.buttonKodowanie1.Text = "Kodowanie1";
            this.buttonKodowanie1.UseVisualStyleBackColor = false;
            // 
            // buttonKodowanie2
            // 
            this.buttonKodowanie2.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonKodowanie2.Location = new System.Drawing.Point(457, 184);
            this.buttonKodowanie2.Name = "buttonKodowanie2";
            this.buttonKodowanie2.Size = new System.Drawing.Size(153, 66);
            this.buttonKodowanie2.TabIndex = 2;
            this.buttonKodowanie2.Text = "Kodowanie2";
            this.buttonKodowanie2.UseVisualStyleBackColor = false;
            // 
            // buttonKodowanie3
            // 
            this.buttonKodowanie3.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonKodowanie3.Location = new System.Drawing.Point(457, 256);
            this.buttonKodowanie3.Name = "buttonKodowanie3";
            this.buttonKodowanie3.Size = new System.Drawing.Size(153, 66);
            this.buttonKodowanie3.TabIndex = 3;
            this.buttonKodowanie3.Text = "Kodowanie3";
            this.buttonKodowanie3.UseVisualStyleBackColor = false;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 639);
            this.Controls.Add(this.comboDrives);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.buttonKodowanie3);
            this.Controls.Add(this.buttonKodowanie2);
            this.Controls.Add(this.buttonKodowanie1);
            this.Controls.Add(this.listFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.Button buttonKodowanie1;
        private System.Windows.Forms.Button buttonKodowanie2;
        private System.Windows.Forms.Button buttonKodowanie3;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.ComboBox comboDrives;
    }
}

