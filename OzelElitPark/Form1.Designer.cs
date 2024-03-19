namespace OzelElitPark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnSekreter = new System.Windows.Forms.Button();
            this.BtnDoktor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnYonetici = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSekreter
            // 
            this.BtnSekreter.BackColor = System.Drawing.Color.Tomato;
            this.BtnSekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreter.FlatAppearance.BorderSize = 0;
            this.BtnSekreter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSekreter.Image = global::OzelElitPark.Properties.Resources.icons8_nurse_100;
            this.BtnSekreter.Location = new System.Drawing.Point(557, 198);
            this.BtnSekreter.Name = "BtnSekreter";
            this.BtnSekreter.Size = new System.Drawing.Size(192, 168);
            this.BtnSekreter.TabIndex = 8;
            this.BtnSekreter.UseVisualStyleBackColor = false;
            this.BtnSekreter.Click += new System.EventHandler(this.BtnSekreter_Click);
            // 
            // BtnDoktor
            // 
            this.BtnDoktor.BackColor = System.Drawing.Color.BlueViolet;
            this.BtnDoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktor.FlatAppearance.BorderSize = 0;
            this.BtnDoktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoktor.Image = global::OzelElitPark.Properties.Resources.icons8_doctor_100;
            this.BtnDoktor.Location = new System.Drawing.Point(294, 198);
            this.BtnDoktor.Name = "BtnDoktor";
            this.BtnDoktor.Size = new System.Drawing.Size(192, 168);
            this.BtnDoktor.TabIndex = 7;
            this.BtnDoktor.UseVisualStyleBackColor = false;
            this.BtnDoktor.Click += new System.EventHandler(this.BtnDoktor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OzelElitPark.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(294, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 60);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnYonetici
            // 
            this.BtnYonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnYonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnYonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnYonetici.Image = global::OzelElitPark.Properties.Resources.icons8_admin_100;
            this.BtnYonetici.Location = new System.Drawing.Point(69, 198);
            this.BtnYonetici.Name = "BtnYonetici";
            this.BtnYonetici.Size = new System.Drawing.Size(192, 168);
            this.BtnYonetici.TabIndex = 1;
            this.BtnYonetici.UseVisualStyleBackColor = false;
            this.BtnYonetici.Click += new System.EventHandler(this.BtnYonetici_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSekreter);
            this.Controls.Add(this.BtnDoktor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnYonetici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Özel ElitPark Hastanesi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnYonetici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnDoktor;
        private System.Windows.Forms.Button BtnSekreter;
    }
}

