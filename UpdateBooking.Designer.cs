namespace OSB
{
    partial class UpdateBooking
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBooking));
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.lbldash = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updatesave = new System.Windows.Forms.Button();
            this.updatedate = new System.Windows.Forms.DateTimePicker();
            this.updateslot = new System.Windows.Forms.ComboBox();
            this.updatesport = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Label();
            this.updatebookingid = new System.Windows.Forms.TextBox();
            this.updateid = new System.Windows.Forms.Label();
            this.oSBDataSet = new OSB.OSBDataSet();
            this.newBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newBookingTableAdapter = new OSB.OSBDataSetTableAdapters.NewBookingTableAdapter();
            this.ubok = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newBookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oSBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(30, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(310, 47);
            this.button4.TabIndex = 9;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "UPDATE BOOKING";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(30, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "TRACK BOOKING";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(30, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(310, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "NEW BOOKING";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logout.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(990, 10);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(153, 44);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // lbldash
            // 
            this.lbldash.AutoSize = true;
            this.lbldash.BackColor = System.Drawing.Color.Transparent;
            this.lbldash.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldash.Location = new System.Drawing.Point(11, 0);
            this.lbldash.Name = "lbldash";
            this.lbldash.Size = new System.Drawing.Size(274, 50);
            this.lbldash.TabIndex = 1;
            this.lbldash.Text = "DASHBOARD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lbldash);
            this.panel1.Controls.Add(this.logout);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 60);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updatesave);
            this.panel2.Controls.Add(this.updatedate);
            this.panel2.Controls.Add(this.updateslot);
            this.panel2.Controls.Add(this.updatesport);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.update);
            this.panel2.Location = new System.Drawing.Point(405, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 276);
            this.panel2.TabIndex = 20;
            // 
            // updatesave
            // 
            this.updatesave.BackColor = System.Drawing.Color.Navy;
            this.updatesave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatesave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatesave.Location = new System.Drawing.Point(34, 214);
            this.updatesave.Name = "updatesave";
            this.updatesave.Size = new System.Drawing.Size(89, 45);
            this.updatesave.TabIndex = 7;
            this.updatesave.Text = "Save";
            this.updatesave.UseVisualStyleBackColor = false;
            this.updatesave.Click += new System.EventHandler(this.updatesave_Click);
            // 
            // updatedate
            // 
            this.updatedate.Location = new System.Drawing.Point(148, 149);
            this.updatedate.Name = "updatedate";
            this.updatedate.Size = new System.Drawing.Size(244, 22);
            this.updatedate.TabIndex = 6;
            // 
            // updateslot
            // 
            this.updateslot.FormattingEnabled = true;
            this.updateslot.Items.AddRange(new object[] {
            "Slot-1 (10 AM - 11 AM)",
            "Slot-2 (2 PM - 3 PM)",
            "Slot-3 (4 PM - 5 PM)",
            "Slot-4 (5 PM - 6 PM) "});
            this.updateslot.Location = new System.Drawing.Point(539, 147);
            this.updateslot.Name = "updateslot";
            this.updateslot.Size = new System.Drawing.Size(244, 24);
            this.updateslot.TabIndex = 5;
            // 
            // updatesport
            // 
            this.updatesport.FormattingEnabled = true;
            this.updatesport.Items.AddRange(new object[] {
            "Football",
            "Cricket",
            "Basketball",
            "Vollyball",
            "Tenis"});
            this.updatesport.Location = new System.Drawing.Point(332, 76);
            this.updatesport.Name = "updatesport";
            this.updatesport.Size = new System.Drawing.Size(244, 24);
            this.updatesport.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(78, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(464, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Slot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(235, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sport";
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.update.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(378, 10);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(102, 30);
            this.update.TabIndex = 0;
            this.update.Text = "UPDATE";
            // 
            // updatebookingid
            // 
            this.updatebookingid.Location = new System.Drawing.Point(747, 169);
            this.updatebookingid.Name = "updatebookingid";
            this.updatebookingid.Size = new System.Drawing.Size(244, 22);
            this.updatebookingid.TabIndex = 9;
            // 
            // updateid
            // 
            this.updateid.AutoSize = true;
            this.updateid.BackColor = System.Drawing.Color.MediumTurquoise;
            this.updateid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateid.Location = new System.Drawing.Point(413, 169);
            this.updateid.Name = "updateid";
            this.updateid.Size = new System.Drawing.Size(288, 24);
            this.updateid.TabIndex = 8;
            this.updateid.Text = "Please Enter Your Booking ID";
            // 
            // oSBDataSet
            // 
            this.oSBDataSet.DataSetName = "OSBDataSet";
            this.oSBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newBookingBindingSource
            // 
            this.newBookingBindingSource.DataMember = "NewBooking";
            this.newBookingBindingSource.DataSource = this.oSBDataSet;
            // 
            // newBookingTableAdapter
            // 
            this.newBookingTableAdapter.ClearBeforeFill = true;
            // 
            // ubok
            // 
            this.ubok.Location = new System.Drawing.Point(1032, 161);
            this.ubok.Name = "ubok";
            this.ubok.Size = new System.Drawing.Size(80, 38);
            this.ubok.TabIndex = 22;
            this.ubok.Text = "OK";
            this.ubok.UseVisualStyleBackColor = true;
            this.ubok.Click += new System.EventHandler(this.ubok_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.sportsDataGridViewTextBoxColumn,
            this.slotDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.newBookingBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(405, 549);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(836, 102);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookingIDDataGridViewTextBoxColumn
            // 
            this.bookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID";
            this.bookingIDDataGridViewTextBoxColumn.Name = "bookingIDDataGridViewTextBoxColumn";
            this.bookingIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // sportsDataGridViewTextBoxColumn
            // 
            this.sportsDataGridViewTextBoxColumn.DataPropertyName = "Sports";
            this.sportsDataGridViewTextBoxColumn.HeaderText = "Sports";
            this.sportsDataGridViewTextBoxColumn.Name = "sportsDataGridViewTextBoxColumn";
            // 
            // slotDataGridViewTextBoxColumn
            // 
            this.slotDataGridViewTextBoxColumn.DataPropertyName = "Slot";
            this.slotDataGridViewTextBoxColumn.HeaderText = "Slot";
            this.slotDataGridViewTextBoxColumn.Name = "slotDataGridViewTextBoxColumn";
            // 
            // newBookingBindingSource1
            // 
            this.newBookingBindingSource1.DataMember = "NewBooking";
            this.newBookingBindingSource1.DataSource = this.oSBDataSet;
            // 
            // UpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1168, 701);
            this.Controls.Add(this.ubok);
            this.Controls.Add(this.updatebookingid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateBooking";
            this.Load += new System.EventHandler(this.UpdateBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oSBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label lbldash;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox updatebookingid;
        private System.Windows.Forms.Label updateid;
        private System.Windows.Forms.Button updatesave;
        private System.Windows.Forms.DateTimePicker updatedate;
        private System.Windows.Forms.ComboBox updateslot;
        private System.Windows.Forms.ComboBox updatesport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label update;
        private OSBDataSet oSBDataSet;
        private System.Windows.Forms.BindingSource newBookingBindingSource;
        private OSBDataSetTableAdapters.NewBookingTableAdapter newBookingTableAdapter;
        private System.Windows.Forms.Button ubok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource newBookingBindingSource1;
    }
}