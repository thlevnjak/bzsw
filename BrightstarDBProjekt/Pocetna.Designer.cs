
namespace BrightstarDBProjekt
{
    partial class Pocetna
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
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTrenutni = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Location = new System.Drawing.Point(11, 76);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.Size = new System.Drawing.Size(552, 135);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis svih korisnika\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trenutno prijavljen:";
            // 
            // lblTrenutni
            // 
            this.lblTrenutni.AutoSize = true;
            this.lblTrenutni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutni.Location = new System.Drawing.Point(386, 31);
            this.lblTrenutni.Name = "lblTrenutni";
            this.lblTrenutni.Size = new System.Drawing.Size(52, 13);
            this.lblTrenutni.TabIndex = 2;
            this.lblTrenutni.Text = "Korisnik";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(489, 9);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 23);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(43, 227);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(202, 227);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lozinka:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(361, 227);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtLozinka.TabIndex = 5;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(488, 226);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 20);
            this.btnSpremi.TabIndex = 6;
            this.btnSpremi.Text = "Ažuriraj";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 284);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.lblTrenutni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKorisnici);
            this.Name = "Pocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Početna";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTrenutni;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnSpremi;
    }
}