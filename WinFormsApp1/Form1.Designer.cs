namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbKlucz = new System.Windows.Forms.TextBox();
            this.tbOdszyfrowana = new System.Windows.Forms.TextBox();
            this.lOdszyfrowana = new System.Windows.Forms.Label();
            this.bOdszyfruj = new System.Windows.Forms.Button();
            this.tbZaszyfrowana = new System.Windows.Forms.TextBox();
            this.lZaszyfrowana = new System.Windows.Forms.Label();
            this.bSzyfruj = new System.Windows.Forms.Button();
            this.tbWiadomosc = new System.Windows.Forms.TextBox();
            this.lWiadomosc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbKlucz);
            this.panel1.Controls.Add(this.tbOdszyfrowana);
            this.panel1.Controls.Add(this.lOdszyfrowana);
            this.panel1.Controls.Add(this.bOdszyfruj);
            this.panel1.Controls.Add(this.tbZaszyfrowana);
            this.panel1.Controls.Add(this.lZaszyfrowana);
            this.panel1.Controls.Add(this.bSzyfruj);
            this.panel1.Controls.Add(this.tbWiadomosc);
            this.panel1.Controls.Add(this.lWiadomosc);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 451);
            this.panel1.TabIndex = 0;
            // 
            // tbKlucz
            // 
            this.tbKlucz.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbKlucz.Location = new System.Drawing.Point(407, 25);
            this.tbKlucz.Name = "tbKlucz";
            this.tbKlucz.Size = new System.Drawing.Size(125, 27);
            this.tbKlucz.TabIndex = 8;
            // 
            // tbOdszyfrowana
            // 
            this.tbOdszyfrowana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbOdszyfrowana.Location = new System.Drawing.Point(144, 225);
            this.tbOdszyfrowana.Name = "tbOdszyfrowana";
            this.tbOdszyfrowana.ReadOnly = true;
            this.tbOdszyfrowana.Size = new System.Drawing.Size(125, 27);
            this.tbOdszyfrowana.TabIndex = 7;
            // 
            // lOdszyfrowana
            // 
            this.lOdszyfrowana.AutoSize = true;
            this.lOdszyfrowana.Location = new System.Drawing.Point(31, 225);
            this.lOdszyfrowana.Name = "lOdszyfrowana";
            this.lOdszyfrowana.Size = new System.Drawing.Size(106, 20);
            this.lOdszyfrowana.TabIndex = 6;
            this.lOdszyfrowana.Text = "Odszyfrowana:";
            // 
            // bOdszyfruj
            // 
            this.bOdszyfruj.Location = new System.Drawing.Point(144, 179);
            this.bOdszyfruj.Name = "bOdszyfruj";
            this.bOdszyfruj.Size = new System.Drawing.Size(94, 29);
            this.bOdszyfruj.TabIndex = 5;
            this.bOdszyfruj.Text = "Odszyfruj";
            this.bOdszyfruj.UseVisualStyleBackColor = true;
            this.bOdszyfruj.Click += new System.EventHandler(this.bOdszyfruj_Click);
            // 
            // tbZaszyfrowana
            // 
            this.tbZaszyfrowana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbZaszyfrowana.Location = new System.Drawing.Point(140, 129);
            this.tbZaszyfrowana.Name = "tbZaszyfrowana";
            this.tbZaszyfrowana.ReadOnly = true;
            this.tbZaszyfrowana.Size = new System.Drawing.Size(125, 27);
            this.tbZaszyfrowana.TabIndex = 4;
            // 
            // lZaszyfrowana
            // 
            this.lZaszyfrowana.AutoSize = true;
            this.lZaszyfrowana.Location = new System.Drawing.Point(31, 129);
            this.lZaszyfrowana.Name = "lZaszyfrowana";
            this.lZaszyfrowana.Size = new System.Drawing.Size(103, 20);
            this.lZaszyfrowana.TabIndex = 3;
            this.lZaszyfrowana.Text = "Zaszyfrowana:";
            // 
            // bSzyfruj
            // 
            this.bSzyfruj.Location = new System.Drawing.Point(140, 82);
            this.bSzyfruj.Name = "bSzyfruj";
            this.bSzyfruj.Size = new System.Drawing.Size(94, 29);
            this.bSzyfruj.TabIndex = 2;
            this.bSzyfruj.Text = "Szyfruj";
            this.bSzyfruj.UseVisualStyleBackColor = true;
            this.bSzyfruj.Click += new System.EventHandler(this.bSzyfruj_Click);
            // 
            // tbWiadomosc
            // 
            this.tbWiadomosc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbWiadomosc.Location = new System.Drawing.Point(140, 25);
            this.tbWiadomosc.Name = "tbWiadomosc";
            this.tbWiadomosc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbWiadomosc.Size = new System.Drawing.Size(125, 27);
            this.tbWiadomosc.TabIndex = 1;
            this.tbWiadomosc.TextChanged += new System.EventHandler(this.tbWiadomosc_TextChanged);
            // 
            // lWiadomosc
            // 
            this.lWiadomosc.AutoSize = true;
            this.lWiadomosc.Location = new System.Drawing.Point(43, 25);
            this.lWiadomosc.Name = "lWiadomosc";
            this.lWiadomosc.Size = new System.Drawing.Size(91, 20);
            this.lWiadomosc.TabIndex = 0;
            this.lWiadomosc.Text = "Wiadomość:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Szyfr Vigenere";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lWiadomosc;
        private TextBox tbOdszyfrowana;
        private Label lOdszyfrowana;
        private Button bOdszyfruj;
        private TextBox tbZaszyfrowana;
        private Label lZaszyfrowana;
        private Button bSzyfruj;
        private TextBox tbWiadomosc;
        private TextBox tbKlucz;
    }
}