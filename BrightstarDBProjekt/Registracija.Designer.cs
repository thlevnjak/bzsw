
namespace BrightstarDBProjekt
{
    partial class Registracija
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
            this.lblPrijava = new System.Windows.Forms.Label();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPrijava
            // 
            this.lblPrijava.AutoSize = true;
            this.lblPrijava.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPrijava.Location = new System.Drawing.Point(92, 184);
            this.lblPrijava.Name = "lblPrijava";
            this.lblPrijava.Size = new System.Drawing.Size(109, 13);
            this.lblPrijava.TabIndex = 6;
            this.lblPrijava.Text = "Imaš račun - prijavi se";
            this.lblPrijava.Click += new System.EventHandler(this.lblPrijava_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(44, 139);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(209, 42);
            this.btnRegistracija.TabIndex = 5;
            this.btnRegistracija.Text = "Registriraj se";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(125, 113);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(128, 20);
            this.txtLozinka.TabIndex = 4;
            this.txtLozinka.UseSystemPasswordChar = true;
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(125, 87);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(128, 20);
            this.txtKorIme.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lozinka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(125, 61);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(128, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(125, 35);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(128, 20);
            this.txtIme.TabIndex = 1;
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 243);
            this.Controls.Add(this.lblPrijava);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.Registracija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrijava;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIme;
    }
}