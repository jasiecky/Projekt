
namespace WindowsFormsApp1
{
    partial class ZarzT
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
            this.DodajXML = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtNumerTelefonu = new System.Windows.Forms.MaskedTextBox();
            this.tPesel = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tNazwisko = new System.Windows.Forms.TextBox();
            this.tImie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DodajXML
            // 
            this.DodajXML.Location = new System.Drawing.Point(139, 281);
            this.DodajXML.Name = "DodajXML";
            this.DodajXML.Size = new System.Drawing.Size(197, 42);
            this.DodajXML.TabIndex = 35;
            this.DodajXML.Text = "Dodaj kontrahenta i zapisz w pliku XML";
            this.DodajXML.UseVisualStyleBackColor = true;
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(139, 233);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(197, 42);
            this.Dodaj.TabIndex = 34;
            this.Dodaj.Text = "Dodaj kontrahenta";
            this.Dodaj.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "PESEL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Numer telefonu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nazwisko:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Imie:";
            // 
            // mtNumerTelefonu
            // 
            this.mtNumerTelefonu.Location = new System.Drawing.Point(139, 129);
            this.mtNumerTelefonu.Mask = "(999) 000-0000";
            this.mtNumerTelefonu.Name = "mtNumerTelefonu";
            this.mtNumerTelefonu.Size = new System.Drawing.Size(197, 20);
            this.mtNumerTelefonu.TabIndex = 28;
            // 
            // tPesel
            // 
            this.tPesel.Location = new System.Drawing.Point(139, 168);
            this.tPesel.Name = "tPesel";
            this.tPesel.Size = new System.Drawing.Size(197, 20);
            this.tPesel.TabIndex = 27;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(139, 207);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(197, 20);
            this.tEmail.TabIndex = 26;
            // 
            // tNazwisko
            // 
            this.tNazwisko.Location = new System.Drawing.Point(139, 88);
            this.tNazwisko.Name = "tNazwisko";
            this.tNazwisko.Size = new System.Drawing.Size(197, 20);
            this.tNazwisko.TabIndex = 25;
            // 
            // tImie
            // 
            this.tImie.Location = new System.Drawing.Point(139, 49);
            this.tImie.Name = "tImie";
            this.tImie.Size = new System.Drawing.Size(197, 20);
            this.tImie.TabIndex = 24;
            // 
            // ZarzT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DodajXML);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtNumerTelefonu);
            this.Controls.Add(this.tPesel);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tNazwisko);
            this.Controls.Add(this.tImie);
            this.Name = "ZarzT";
            this.Text = "ZarzT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DodajXML;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtNumerTelefonu;
        private System.Windows.Forms.TextBox tPesel;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tNazwisko;
        private System.Windows.Forms.TextBox tImie;
    }
}