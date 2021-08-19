namespace OSB
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
            this.lgid = new System.Windows.Forms.Label();
            this.lgpass = new System.Windows.Forms.Label();
            this.txid = new System.Windows.Forms.TextBox();
            this.txpass = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.fgpass = new System.Windows.Forms.Label();
            this.lbca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lgid
            // 
            this.lgid.AutoSize = true;
            this.lgid.BackColor = System.Drawing.Color.Transparent;
            this.lgid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgid.Location = new System.Drawing.Point(24, 231);
            this.lgid.Name = "lgid";
            this.lgid.Size = new System.Drawing.Size(108, 32);
            this.lgid.TabIndex = 4;
            this.lgid.Text = "User ID";
            // 
            // lgpass
            // 
            this.lgpass.AutoSize = true;
            this.lgpass.BackColor = System.Drawing.Color.Transparent;
            this.lgpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgpass.ForeColor = System.Drawing.Color.Black;
            this.lgpass.Location = new System.Drawing.Point(12, 326);
            this.lgpass.Name = "lgpass";
            this.lgpass.Size = new System.Drawing.Size(139, 32);
            this.lgpass.TabIndex = 5;
            this.lgpass.Text = "Password";
            // 
            // txid
            // 
            this.txid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txid.Font = new System.Drawing.Font("Arial Narrow", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txid.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txid.Location = new System.Drawing.Point(67, 7);
            this.txid.Name = "txid";
            this.txid.Size = new System.Drawing.Size(228, 43);
            this.txid.TabIndex = 6;
            this.txid.TextChanged += new System.EventHandler(this.txid_TextChanged);
            // 
            // txpass
            // 
            this.txpass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txpass.Font = new System.Drawing.Font("Arial Narrow", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txpass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txpass.Location = new System.Drawing.Point(62, 3);
            this.txpass.Name = "txpass";
            this.txpass.PasswordChar = '*';
            this.txpass.Size = new System.Drawing.Size(236, 50);
            this.txpass.TabIndex = 7;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.DodgerBlue;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login.Location = new System.Drawing.Point(179, 422);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(112, 38);
            this.login.TabIndex = 8;
            this.login.Text = "Log In";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // fgpass
            // 
            this.fgpass.AutoSize = true;
            this.fgpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgpass.Location = new System.Drawing.Point(268, 554);
            this.fgpass.Name = "fgpass";
            this.fgpass.Size = new System.Drawing.Size(191, 24);
            this.fgpass.TabIndex = 9;
            this.fgpass.Text = "Forgot Password>>";
            // 
            // lbca
            // 
            this.lbca.AutoSize = true;
            this.lbca.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbca.Location = new System.Drawing.Point(140, 498);
            this.lbca.Name = "lbca";
            this.lbca.Size = new System.Drawing.Size(192, 25);
            this.lbca.TabIndex = 10;
            this.lbca.Text = "Create New Account";
            this.lbca.Click += new System.EventHandler(this.lbca_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txpass);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(162, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 58);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OSB.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.txid);
            this.panel2.Location = new System.Drawing.Point(162, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 59);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OSB.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(220, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "American International";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OSB.Properties.Resources.icon1;
            this.pictureBox3.Location = new System.Drawing.Point(30, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(102, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(225, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "University-Bangladesh";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Location = new System.Drawing.Point(173, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 119);
            this.panel3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(240, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "-where leaders are created";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(181, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "AIUB Sports Club";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 587);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbca);
            this.Controls.Add(this.fgpass);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lgpass);
            this.Controls.Add(this.lgid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Sports Slot Booking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lgid;
        private System.Windows.Forms.Label lgpass;
        private System.Windows.Forms.TextBox txid;
        private System.Windows.Forms.TextBox txpass;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label fgpass;
        private System.Windows.Forms.Label lbca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

