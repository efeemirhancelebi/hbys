namespace HBYS
{
    partial class hastaArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastaArama));
            this.labelHastaTc = new System.Windows.Forms.Label();
            this.textTc = new System.Windows.Forms.TextBox();
            this.btnArama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHastaTc
            // 
            this.labelHastaTc.AutoSize = true;
            this.labelHastaTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHastaTc.Location = new System.Drawing.Point(12, 9);
            this.labelHastaTc.Name = "labelHastaTc";
            this.labelHastaTc.Size = new System.Drawing.Size(166, 16);
            this.labelHastaTc.TabIndex = 3;
            this.labelHastaTc.Text = "Hasta TC Kimlik Numarası:";
            // 
            // textTc
            // 
            this.textTc.Location = new System.Drawing.Point(15, 28);
            this.textTc.Name = "textTc";
            this.textTc.Size = new System.Drawing.Size(163, 20);
            this.textTc.TabIndex = 4;
            // 
            // btnArama
            // 
            this.btnArama.Location = new System.Drawing.Point(15, 54);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(163, 35);
            this.btnArama.TabIndex = 5;
            this.btnArama.Text = "Hasta Arama";
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // hastaArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 101);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.textTc);
            this.Controls.Add(this.labelHastaTc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "hastaArama";
            this.Text = "Hasta Arama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHastaTc;
        private System.Windows.Forms.TextBox textTc;
        private System.Windows.Forms.Button btnArama;
    }
}