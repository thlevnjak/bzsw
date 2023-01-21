
namespace BrightstarDBProjekt
{
    partial class Prijava
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lozinka:";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(125, 60);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(128, 20);
            this.txtKorIme.TabIndex = 1;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(125, 86);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(128, 20);
            this.txtLozinka.TabIndex = 2;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(44, 112);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(209, 42);
            this.btnPrijava.TabIndex = 3;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRegistracija.Location = new System.Drawing.Point(82, 157);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(134, 13);
            this.lblRegistracija.TabIndex = 3;
            this.lblRegistracija.Text = "Nemaš račun - registriraj se";
            this.lblRegistracija.Click += new System.EventHandler(this.lblRegistracija_Click);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 243);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Prijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Prijava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label lblRegistracija;
    }
}

