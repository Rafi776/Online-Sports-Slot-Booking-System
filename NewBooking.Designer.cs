namespace OSB
{
    partial class NewBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBooking));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbldash = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookingdate = new System.Windows.Forms.DateTimePicker();
            this.button6 = new System.Windows.Forms.Button();
            this.bookingslot = new System.Windows.Forms.ComboBox();
            this.bookingsport = new System.Windows.Forms.ComboBox();
            this.bookingdepartment = new System.Windows.Forms.ComboBox();
            this.bookingID = new System.Windows.Forms.TextBox();
            this.bookingname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(16, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(342, 47);
            this.button4.TabIndex = 11;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(16, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(342, 47);
            this.button3.TabIndex = 10;
            this.button3.Text = "UPDATE BOOKING";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(342, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "TRACK BOOKING";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "NEW BOOKING";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbldash
            // 
            this.lbldash.AutoSize = true;
            this.lbldash.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbldash.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldash.Location = new System.Drawing.Point(-9, 0);
            this.lbldash.Name = "lbldash";
            this.lbldash.Size = new System.Drawing.Size(304, 51);
            this.lbldash.TabIndex = 7;
            this.lbldash.Text = "DASHBOARD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.bookingdate);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.bookingslot);
            this.panel1.Controls.Add(this.bookingsport);
            this.panel1.Controls.Add(this.bookingdepartment);
            this.panel1.Controls.Add(this.bookingID);
            this.panel1.Controls.Add(this.bookingname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(394, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 428);
            this.panel1.TabIndex = 13;
            // 
            // bookingdate
            // 
            this.bookingdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingdate.Location = new System.Drawing.Point(161, 228);
            this.bookingdate.Name = "bookingdate";
            this.bookingdate.Size = new System.Drawing.Size(322, 28);
            this.bookingdate.TabIndex = 31;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(513, 381);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 37);
            this.button6.TabIndex = 30;
            this.button6.Text = "Book";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bookingslot
            // 
            this.bookingslot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingslot.FormattingEnabled = true;
            this.bookingslot.Items.AddRange(new object[] {
            "Slot-1 (10 AM - 11 AM)",
            "Slot-2 (2 PM - 3 PM)",
            "Slot-3 (4 PM - 5 PM)",
            "Slot-4 (5 PM - 6 PM) "});
            this.bookingslot.Location = new System.Drawing.Point(161, 334);
            this.bookingslot.Name = "bookingslot";
            this.bookingslot.Size = new System.Drawing.Size(322, 30);
            this.bookingslot.TabIndex = 29;
            // 
            // bookingsport
            // 
            this.bookingsport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsport.FormattingEnabled = true;
            this.bookingsport.Items.AddRange(new object[] {
            "Football",
            "Cricket",
            "Basketball",
            "Vollyball",
            "Tenis"});
            this.bookingsport.Location = new System.Drawing.Point(161, 277);
            this.bookingsport.Name = "bookingsport";
            this.bookingsport.Size = new System.Drawing.Size(322, 30);
            this.bookingsport.TabIndex = 28;
            // 
            // bookingdepartment
            // 
            this.bookingdepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingdepartment.FormattingEnabled = true;
            this.bookingdepartment.Items.AddRange(new object[] {
            "CSE",
            "CSSE",
            "EEE",
            "Architecture",
            "IPE",
            "ENGLISH",
            "LLB",
            "BBA"});
            this.bookingdepartment.Location = new System.Drawing.Point(161, 167);
            this.bookingdepartment.Name = "bookingdepartment";
            this.bookingdepartment.Size = new System.Drawing.Size(322, 30);
            this.bookingdepartment.TabIndex = 27;
            // 
            // bookingID
            // 
            this.bookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingID.Location = new System.Drawing.Point(161, 116);
            this.bookingID.Name = "bookingID";
            this.bookingID.Size = new System.Drawing.Size(322, 27);
            this.bookingID.TabIndex = 26;
            // 
            // bookingname
            // 
            this.bookingname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingname.Location = new System.Drawing.Point(161, 65);
            this.bookingname.Name = "bookingname";
            this.bookingname.Size = new System.Drawing.Size(322, 27);
            this.bookingname.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Slot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sports";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.lbldash);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 46);
            this.panel2.TabIndex = 14;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logout.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(958, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(153, 44);
            this.logout.TabIndex = 8;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1125, 495);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewBooking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbldash;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker bookingdate;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox bookingslot;
        private System.Windows.Forms.ComboBox bookingsport;
        private System.Windows.Forms.ComboBox bookingdepartment;
        private System.Windows.Forms.TextBox bookingID;
        private System.Windows.Forms.TextBox bookingname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout;
    }
}