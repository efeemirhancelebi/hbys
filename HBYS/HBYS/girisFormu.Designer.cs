namespace HBYS
{
    partial class girisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisFormu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textTc = new System.Windows.Forms.TextBox();
            this.labelTc = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.btnHemsire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(175, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textTc
            // 
            this.textTc.Location = new System.Drawing.Point(120, 274);
            this.textTc.Name = "textTc";
            this.textTc.Size = new System.Drawing.Size(260, 20);
            this.textTc.TabIndex = 1;
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(123, 258);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(101, 13);
            this.labelTc.TabIndex = 2;
            this.labelTc.Text = "TC Kimlik Numarası:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(123, 312);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(31, 13);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Şifre:";
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(120, 328);
            this.textSifre.Name = "textSifre";
            this.textSifre.Size = new System.Drawing.Size(260, 20);
            this.textSifre.TabIndex = 4;
            // 
            // btnHemsire
            // 
            this.btnHemsire.Location = new System.Drawing.Point(144, 364);
            this.btnHemsire.Name = "btnHemsire";
            this.btnHemsire.Size = new System.Drawing.Size(206, 35);
            this.btnHemsire.TabIndex = 5;
            this.btnHemsire.Text = "Sistem Girişi";
            this.btnHemsire.UseVisualStyleBackColor = true;
            this.btnHemsire.Click += new System.EventHandler(this.btnHemsire_Click);
            // 
            // girisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnHemsire);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelTc);
            this.Controls.Add(this.textTc);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "girisFormu";
            this.Text = "Hasta Bilgi Yönetim Sistemi - HBYS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textTc;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.Button btnHemsire;
    }
}

