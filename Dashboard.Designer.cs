namespace OSB
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dataGridViewmain = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comodpt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oSBDataSet = new OSB.OSBDataSet();
            this.lbldash = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.updatebooking = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.userAccountTableAdapter = new OSB.OSBDataSetTableAdapters.UserAccountTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.udview = new System.Windows.Forms.Button();
            this.udrefresh = new System.Windows.Forms.Button();
            this.udidtxt = new System.Windows.Forms.TextBox();
            this.udid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewmain
            // 
            this.dataGridViewmain.AllowUserToAddRows = false;
            this.dataGridViewmain.AllowUserToDeleteRows = false;
            this.dataGridViewmain.AutoGenerateColumns = false;
            this.dataGridViewmain.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewmain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtid,
            this.txtnm,
            this.comodpt,
            this.emailDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn});
            this.dataGridViewmain.DataSource = this.userAccountBindingSource;
            this.dataGridViewmain.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewmain.Location = new System.Drawing.Point(743, 122);
            this.dataGridViewmain.Name = "dataGridViewmain";
            this.dataGridViewmain.ReadOnly = true;
            this.dataGridViewmain.RowTemplate.Height = 24;
            this.dataGridViewmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewmain.Size = new System.Drawing.Size(466, 317);
            this.dataGridViewmain.TabIndex = 0;
            this.dataGridViewmain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewmain_CellClick);
            this.dataGridViewmain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewmain_CellContentClick);
            // 
            // txtid
            // 
            this.txtid.DataPropertyName = "ID";
            this.txtid.HeaderText = "ID";
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            // 
            // txtnm
            // 
            this.txtnm.DataPropertyName = "Name";
            this.txtnm.HeaderText = "Name";
            this.txtnm.Name = "txtnm";
            this.txtnm.ReadOnly = true;
            // 
            // comodpt
            // 
            this.comodpt.DataPropertyName = "Department";
            this.comodpt.HeaderText = "Department";
            this.comodpt.Name = "comodpt";
            this.comodpt.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            this.phoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userAccountBindingSource
            // 
            this.userAccountBindingSource.DataMember = "UserAccount";
            this.userAccountBindingSource.DataSource = this.oSBDataSet;
            // 
            // oSBDataSet
            // 
            this.oSBDataSet.DataSetName = "OSBDataSet";
            this.oSBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbldash
            // 
            this.lbldash.AutoSize = true;
            this.lbldash.BackColor = System.Drawing.Color.Transparent;
            this.lbldash.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldash.Location = new System.Drawing.Point(5, -1);
            this.lbldash.Name = "lbldash";
            this.lbldash.Size = new System.Drawing.Size(274, 50);
            this.lbldash.TabIndex = 1;
            this.lbldash.Text = "DASHBOARD";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "NEW BOOKING";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "TRACK BOOKING";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // updatebooking
            // 
            this.updatebooking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updatebooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebooking.Location = new System.Drawing.Point(6, 327);
            this.updatebooking.Name = "updatebooking";
            this.updatebooking.Size = new System.Drawing.Size(310, 47);
            this.updatebooking.TabIndex = 4;
            this.updatebooking.Text = "UPDATE BOOKING";
            this.updatebooking.UseVisualStyleBackColor = false;
            this.updatebooking.Click += new System.EventHandler(this.updatebooking_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(310, 47);
            this.button4.TabIndex = 5;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(736, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "USER DETAILS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.lbldash);
            this.panel1.Location = new System.Drawing.Point(-8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 50);
            this.panel1.TabIndex = 8;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logout.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(1107, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(153, 44);
            this.logout.TabIndex = 2;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // userAccountTableAdapter
            // 
            this.userAccountTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.udview);
            this.panel2.Controls.Add(this.udrefresh);
            this.panel2.Controls.Add(this.udidtxt);
            this.panel2.Controls.Add(this.udid);
            this.panel2.Location = new System.Drawing.Point(426, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 317);
            this.panel2.TabIndex = 9;
            // 
            // udview
            // 
            this.udview.Location = new System.Drawing.Point(158, 205);
            this.udview.Name = "udview";
            this.udview.Size = new System.Drawing.Size(97, 47);
            this.udview.TabIndex = 3;
            this.udview.Text = "View";
            this.udview.UseVisualStyleBackColor = true;
            this.udview.Click += new System.EventHandler(this.udview_Click);
            // 
            // udrefresh
            // 
            this.udrefresh.Location = new System.Drawing.Point(19, 205);
            this.udrefresh.Name = "udrefresh";
            this.udrefresh.Size = new System.Drawing.Size(97, 47);
            this.udrefresh.TabIndex = 2;
            this.udrefresh.Text = "Refresh";
            this.udrefresh.UseVisualStyleBackColor = true;
            this.udrefresh.Click += new System.EventHandler(this.udrefresh_Click);
            // 
            // udidtxt
            // 
            this.udidtxt.Location = new System.Drawing.Point(82, 99);
            this.udidtxt.Name = "udidtxt";
            this.udidtxt.Size = new System.Drawing.Size(182, 22);
            this.udidtxt.TabIndex = 1;
            // 
            // udid
            // 
            this.udid.AutoSize = true;
            this.udid.BackColor = System.Drawing.Color.Transparent;
            this.udid.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udid.Location = new System.Drawing.Point(3, 99);
            this.udid.Name = "udid";
            this.udid.Size = new System.Drawing.Size(61, 22);
            this.udid.TabIndex = 0;
            this.udid.Text = "User ID ";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.updatebooking);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewmain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oSBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewmain;
        private System.Windows.Forms.Label lbldash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button updatebooking;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private OSBDataSet oSBDataSet;
        private System.Windows.Forms.BindingSource userAccountBindingSource;
        private OSBDataSetTableAdapters.UserAccountTableAdapter userAccountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn comodpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button udview;
        private System.Windows.Forms.Button udrefresh;
        private System.Windows.Forms.TextBox udidtxt;
        private System.Windows.Forms.Label udid;
        private System.Windows.Forms.Button logout;
    }
}