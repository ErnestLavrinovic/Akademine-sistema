namespace WindowsFormsApp2.Forms
{
    partial class GrupesSukurimas
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
            this.Patvirtinti = new System.Windows.Forms.Button();
            this.Atsaukti = new System.Windows.Forms.Button();
            this.GrupesPavadinimas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Patvirtinti
            // 
            this.Patvirtinti.Location = new System.Drawing.Point(197, 85);
            this.Patvirtinti.Name = "Patvirtinti";
            this.Patvirtinti.Size = new System.Drawing.Size(75, 23);
            this.Patvirtinti.TabIndex = 0;
            this.Patvirtinti.Text = "Patvirtinti";
            this.Patvirtinti.UseVisualStyleBackColor = true;
            this.Patvirtinti.Click += new System.EventHandler(this.Patvirtinti_Click);
            // 
            // Atsaukti
            // 
            this.Atsaukti.Location = new System.Drawing.Point(12, 85);
            this.Atsaukti.Name = "Atsaukti";
            this.Atsaukti.Size = new System.Drawing.Size(75, 23);
            this.Atsaukti.TabIndex = 1;
            this.Atsaukti.Text = "Atsaukti";
            this.Atsaukti.UseVisualStyleBackColor = true;
            this.Atsaukti.Click += new System.EventHandler(this.Atsaukti_Click);
            // 
            // GrupesPavadinimas
            // 
            this.GrupesPavadinimas.Location = new System.Drawing.Point(12, 22);
            this.GrupesPavadinimas.Name = "GrupesPavadinimas";
            this.GrupesPavadinimas.Size = new System.Drawing.Size(260, 20);
            this.GrupesPavadinimas.TabIndex = 2;
            this.GrupesPavadinimas.Text = "Grupes Pavadinimas";
            this.GrupesPavadinimas.TextChanged += new System.EventHandler(this.GrupesPavadinimas_TextChanged);
            // 
            // GrupesSukurimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 120);
            this.Controls.Add(this.GrupesPavadinimas);
            this.Controls.Add(this.Atsaukti);
            this.Controls.Add(this.Patvirtinti);
            this.Name = "GrupesSukurimas";
            this.Text = "GrupesSukurimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Patvirtinti;
        private System.Windows.Forms.Button Atsaukti;
        private System.Windows.Forms.TextBox GrupesPavadinimas;
    }
}