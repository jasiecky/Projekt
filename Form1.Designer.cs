
namespace WindowsFormsApp1
{
    partial class Main
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
            this.ZarzP = new System.Windows.Forms.Button();
            this.Zakoncz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZarzP
            // 
            this.ZarzP.Location = new System.Drawing.Point(364, 166);
            this.ZarzP.Name = "ZarzP";
            this.ZarzP.Size = new System.Drawing.Size(257, 79);
            this.ZarzP.TabIndex = 0;
            this.ZarzP.Text = "Zarządzanie przedstawicielami";
            this.ZarzP.UseVisualStyleBackColor = true;
            this.ZarzP.Click += new System.EventHandler(this.ZarzP_Click);
            // 
            // Zakoncz
            // 
            this.Zakoncz.Location = new System.Drawing.Point(364, 251);
            this.Zakoncz.Name = "Zakoncz";
            this.Zakoncz.Size = new System.Drawing.Size(257, 79);
            this.Zakoncz.TabIndex = 1;
            this.Zakoncz.Text = "Zakończ";
            this.Zakoncz.UseVisualStyleBackColor = true;
            this.Zakoncz.Click += new System.EventHandler(this.Zakoncz_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.Zakoncz);
            this.Controls.Add(this.ZarzP);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZarzP;
        private System.Windows.Forms.Button Zakoncz;
    }
}

