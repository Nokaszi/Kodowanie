namespace Projekt
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonKodowanie1 = new System.Windows.Forms.Button();
            this.buttonKodowanie2 = new System.Windows.Forms.Button();
            this.buttonKodowanie3 = new System.Windows.Forms.Button();
            this.labelKlucz = new System.Windows.Forms.Label();
            this.buttonGeneruj = new System.Windows.Forms.Button();
            this.textKlucz = new System.Windows.Forms.TextBox();
            this.checkboxToFiles = new System.Windows.Forms.CheckBox();
            this.labelTopic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKodowanie1
            // 
            this.buttonKodowanie1.Location = new System.Drawing.Point(59, 223);
            this.buttonKodowanie1.Name = "buttonKodowanie1";
            this.buttonKodowanie1.Size = new System.Drawing.Size(100, 65);
            this.buttonKodowanie1.TabIndex = 0;
            this.buttonKodowanie1.Text = "Kodwanie1";
            this.buttonKodowanie1.UseVisualStyleBackColor = true;
            this.buttonKodowanie1.Click += new System.EventHandler(this.buttonKodowanie1_Click);
            // 
            // buttonKodowanie2
            // 
            this.buttonKodowanie2.Location = new System.Drawing.Point(227, 223);
            this.buttonKodowanie2.Name = "buttonKodowanie2";
            this.buttonKodowanie2.Size = new System.Drawing.Size(100, 65);
            this.buttonKodowanie2.TabIndex = 1;
            this.buttonKodowanie2.Text = "Kodownaie2";
            this.buttonKodowanie2.UseVisualStyleBackColor = true;
            this.buttonKodowanie2.Click += new System.EventHandler(this.buttonKodowanie2_Click);
            // 
            // buttonKodowanie3
            // 
            this.buttonKodowanie3.Location = new System.Drawing.Point(404, 223);
            this.buttonKodowanie3.Name = "buttonKodowanie3";
            this.buttonKodowanie3.Size = new System.Drawing.Size(100, 65);
            this.buttonKodowanie3.TabIndex = 2;
            this.buttonKodowanie3.Text = "Kodowanie3";
            this.buttonKodowanie3.UseVisualStyleBackColor = true;
            this.buttonKodowanie3.Click += new System.EventHandler(this.buttonKodowanie3_Click);
            // 
            // labelKlucz
            // 
            this.labelKlucz.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKlucz.Location = new System.Drawing.Point(51, 48);
            this.labelKlucz.Name = "labelKlucz";
            this.labelKlucz.Size = new System.Drawing.Size(301, 43);
            this.labelKlucz.TabIndex = 3;
            this.labelKlucz.Text = "Wprowadź klucz";
            // 
            // buttonGeneruj
            // 
            this.buttonGeneruj.Location = new System.Drawing.Point(419, 108);
            this.buttonGeneruj.Name = "buttonGeneruj";
            this.buttonGeneruj.Size = new System.Drawing.Size(85, 38);
            this.buttonGeneruj.TabIndex = 4;
            this.buttonGeneruj.Text = "Generuj";
            this.buttonGeneruj.UseVisualStyleBackColor = true;
            this.buttonGeneruj.Click += new System.EventHandler(this.buttonGeneruj_Click);
            // 
            // textKlucz
            // 
            this.textKlucz.Location = new System.Drawing.Point(59, 108);
            this.textKlucz.Name = "textKlucz";
            this.textKlucz.Size = new System.Drawing.Size(354, 20);
            this.textKlucz.TabIndex = 5;
            // 
            // checkboxToFiles
            // 
            this.checkboxToFiles.AutoSize = true;
            this.checkboxToFiles.Location = new System.Drawing.Point(59, 134);
            this.checkboxToFiles.Name = "checkboxToFiles";
            this.checkboxToFiles.Size = new System.Drawing.Size(97, 17);
            this.checkboxToFiles.TabIndex = 6;
            this.checkboxToFiles.Text = "Zapisz do pliku";
            this.checkboxToFiles.UseVisualStyleBackColor = true;
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTopic.Location = new System.Drawing.Point(56, 9);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(51, 26);
            this.labelTopic.TabIndex = 7;
            this.labelTopic.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 305);
            this.Controls.Add(this.labelTopic);
            this.Controls.Add(this.checkboxToFiles);
            this.Controls.Add(this.textKlucz);
            this.Controls.Add(this.buttonGeneruj);
            this.Controls.Add(this.labelKlucz);
            this.Controls.Add(this.buttonKodowanie3);
            this.Controls.Add(this.buttonKodowanie2);
            this.Controls.Add(this.buttonKodowanie1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKodowanie1;
        private System.Windows.Forms.Button buttonKodowanie2;
        private System.Windows.Forms.Button buttonKodowanie3;
        private System.Windows.Forms.Label labelKlucz;
        private System.Windows.Forms.Button buttonGeneruj;
        private System.Windows.Forms.TextBox textKlucz;
        private System.Windows.Forms.CheckBox checkboxToFiles;
        private System.Windows.Forms.Label labelTopic;
    }
}