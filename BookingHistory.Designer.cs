namespace OSB
{
    partial class BookingHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingHistory));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbldash = new System.Windows.Forms.Label();
            this.oSBDataSet = new OSB.OSBDataSet();
            this.newBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newBookingTableAdapter = new OSB.OSBDataSetTableAdapters.NewBookingTableAdapter();
            this.logout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newBookingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbstudentid = new System.Windows.Forms.TextBox();
            this.tbok = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.oSBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookingBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 47);
            this.button4.TabIndex = 17;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 47);
            this.button3.TabIndex = 16;
            this.button3.Text = "UPDATE BOOKING";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 47);
            this.button2.TabIndex = 15;
            this.button2.Text = "TRACK BOOKING";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 47);
            this.button1.TabIndex = 14;
            this.button1.Text = "NEW BOOKING";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbldash
            // 
            this.lbldash.AutoSize = true;
            this.lbldash.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbldash.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldash.Location = new System.Drawing.Point(3, 0);
            this.lbldash.Name = "lbldash";
            this.lbldash.Size = new System.Drawing.Size(304, 51);
            this.lbldash.TabIndex = 13;
            this.lbldash.Text = "DASHBOARD";
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
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logout.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(1415, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(153, 44);
            this.logout.TabIndex = 20;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lbldash);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Location = new System.Drawing.Point(6, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1585, 54);
            this.panel2.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.newBookingBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.Location = new System.Drawing.Point(383, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(654, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // newBookingBindingSource1
            // 
            this.newBookingBindingSource1.DataMember = "NewBooking";
            this.newBookingBindingSource1.DataSource = this.oSBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "To Show Bookings Please Enter Student ID";
            // 
            // tbstudentid
            // 
            this.tbstudentid.Location = new System.Drawing.Point(775, 130);
            this.tbstudentid.Name = "tbstudentid";
            this.tbstudentid.Size = new System.Drawing.Size(204, 22);
            this.tbstudentid.TabIndex = 24;
            // 
            // tbok
            // 
            this.tbok.Location = new System.Drawing.Point(1000, 118);
            this.tbok.Name = "tbok";
            this.tbok.Size = new System.Drawing.Size(94, 47);
            this.tbok.TabIndex = 25;
            this.tbok.Text = "OK";
            this.tbok.UseVisualStyleBackColor = true;
            this.tbok.Click += new System.EventHandler(this.tbok_Click);
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
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // BookingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1603, 604);
            this.Controls.Add(this.tbok);
            this.Controls.Add(this.tbstudentid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingHistory";
            this.Load += new System.EventHandler(this.BookingHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oSBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookingBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbldash;
        private OSBDataSet oSBDataSet;
        private System.Windows.Forms.BindingSource newBookingBindingSource;
        private OSBDataSetTableAdapters.NewBookingTableAdapter newBookingTableAdapter;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource newBookingBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbstudentid;
        private System.Windows.Forms.Button tbok;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}