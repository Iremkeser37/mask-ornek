namespace masked_ornek
{
    partial class Form1
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
            this.maskTc = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblDogumTarih = new System.Windows.Forms.Label();
            this.lblKartNumara = new System.Windows.Forms.Label();
            this.lblIpAdres = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // maskTc
            // 
            this.maskTc.AutoSize = true;
            this.maskTc.Location = new System.Drawing.Point(40, 38);
            this.maskTc.Name = "maskTc";
            this.maskTc.Size = new System.Drawing.Size(44, 13);
            this.maskTc.TabIndex = 0;
            this.maskTc.Text = "T.C. No";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(40, 77);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(43, 13);
            this.lblTel.TabIndex = 1;
            this.lblTel.Text = "Telefon";
            // 
            // lblDogumTarih
            // 
            this.lblDogumTarih.AutoSize = true;
            this.lblDogumTarih.Location = new System.Drawing.Point(40, 116);
            this.lblDogumTarih.Name = "lblDogumTarih";
            this.lblDogumTarih.Size = new System.Drawing.Size(70, 13);
            this.lblDogumTarih.TabIndex = 2;
            this.lblDogumTarih.Text = "Doğum Tarihi";
            // 
            // lblKartNumara
            // 
            this.lblKartNumara.AutoSize = true;
            this.lblKartNumara.Location = new System.Drawing.Point(40, 152);
            this.lblKartNumara.Name = "lblKartNumara";
            this.lblKartNumara.Size = new System.Drawing.Size(73, 13);
            this.lblKartNumara.TabIndex = 3;
            this.lblKartNumara.Text = "Kart Numarası";
            // 
            // lblIpAdres
            // 
            this.lblIpAdres.AutoSize = true;
            this.lblIpAdres.Location = new System.Drawing.Point(40, 186);
            this.lblIpAdres.Name = "lblIpAdres";
            this.lblIpAdres.Size = new System.Drawing.Size(46, 13);
            this.lblIpAdres.TabIndex = 4;
            this.lblIpAdres.Text = "Ip Adres";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(114, 35);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox1.TabIndex = 5;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(114, 74);
            this.maskedTextBox2.Mask = "(999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(114, 109);
            this.maskedTextBox3.Mask = "00/00/0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox3.TabIndex = 7;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(114, 145);
            this.maskedTextBox4.Mask = "00000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox4.TabIndex = 8;
            this.maskedTextBox4.ValidatingType = typeof(int);
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(114, 186);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox5.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblIpAdres);
            this.Controls.Add(this.lblKartNumara);
            this.Controls.Add(this.lblDogumTarih);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.maskTc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maskTc;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblDogumTarih;
        private System.Windows.Forms.Label lblKartNumara;
        private System.Windows.Forms.Label lblIpAdres;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
    }
}

