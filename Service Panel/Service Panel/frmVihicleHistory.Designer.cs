namespace Service_Panel
{
    partial class ucVehicleHistory
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtSearchModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.groupBoxVehicles = new System.Windows.Forms.GroupBox();
            this.lblVehicleCount = new System.Windows.Forms.Label();
            this.listBoxVehicles = new System.Windows.Forms.ListBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxHistory = new System.Windows.Forms.GroupBox();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.colServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMileage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxVehicles.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.panelRight);
            this.splitContainer.Size = new System.Drawing.Size(560, 500);
            this.splitContainer.SplitterDistance = 200;
            this.splitContainer.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxSearch);
            this.panelLeft.Controls.Add(this.groupBoxVehicles);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 500);
            this.panelLeft.TabIndex = 0;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBoxSearch.Controls.Add(this.btnClearSearch);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.txtSearchPhone);
            this.groupBoxSearch.Controls.Add(this.lblPhone);
            this.groupBoxSearch.Controls.Add(this.txtSearchModel);
            this.groupBoxSearch.Controls.Add(this.lblModel);
            this.groupBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.ForeColor = System.Drawing.Color.White;
            this.groupBoxSearch.Location = new System.Drawing.Point(3, 6);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(188, 168);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search Vehicle";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(96, 104);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(75, 25);
            this.btnClearSearch.TabIndex = 5;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(15, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchPhone.ForeColor = System.Drawing.Color.White;
            this.txtSearchPhone.Location = new System.Drawing.Point(15, 77);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(160, 21);
            this.txtSearchPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.LightGray;
            this.lblPhone.Location = new System.Drawing.Point(17, 59);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(107, 15);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone Number:";
//            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtSearchModel
            // 
            this.txtSearchModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchModel.ForeColor = System.Drawing.Color.White;
            this.txtSearchModel.Location = new System.Drawing.Point(15, 35);
            this.txtSearchModel.Name = "txtSearchModel";
            this.txtSearchModel.Size = new System.Drawing.Size(160, 21);
            this.txtSearchModel.TabIndex = 1;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.LightGray;
            this.lblModel.Location = new System.Drawing.Point(17, 17);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(102, 15);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Vehicle Model:";
            // 
            // groupBoxVehicles
            // 
            this.groupBoxVehicles.Controls.Add(this.lblVehicleCount);
            this.groupBoxVehicles.Controls.Add(this.listBoxVehicles);
            this.groupBoxVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVehicles.ForeColor = System.Drawing.Color.White;
            this.groupBoxVehicles.Location = new System.Drawing.Point(3, 180);
            this.groupBoxVehicles.Name = "groupBoxVehicles";
            this.groupBoxVehicles.Size = new System.Drawing.Size(197, 285);
            this.groupBoxVehicles.TabIndex = 1;
            this.groupBoxVehicles.TabStop = false;
            this.groupBoxVehicles.Text = "Vehicles";
            // 
            // lblVehicleCount
            // 
            this.lblVehicleCount.AutoSize = true;
            this.lblVehicleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleCount.ForeColor = System.Drawing.Color.LightGray;
            this.lblVehicleCount.Location = new System.Drawing.Point(-3, 258);
            this.lblVehicleCount.Name = "lblVehicleCount";
            this.lblVehicleCount.Size = new System.Drawing.Size(103, 13);
            this.lblVehicleCount.TabIndex = 1;
            this.lblVehicleCount.Text = "Total Vehicles: 0";
            // 
            // listBoxVehicles
            // 
            this.listBoxVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(83)))));
            this.listBoxVehicles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxVehicles.ForeColor = System.Drawing.Color.White;
            this.listBoxVehicles.FormattingEnabled = true;
            this.listBoxVehicles.Location = new System.Drawing.Point(0, 19);
            this.listBoxVehicles.Name = "listBoxVehicles";
            this.listBoxVehicles.Size = new System.Drawing.Size(182, 236);
            this.listBoxVehicles.TabIndex = 0;
            this.listBoxVehicles.SelectedIndexChanged += new System.EventHandler(this.listBoxVehicles_SelectedIndexChanged);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBoxHistory);
            this.panelRight.Controls.Add(this.groupBoxDetails);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(356, 500);
            this.panelRight.TabIndex = 0;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.groupBoxDetails.Controls.Add(this.txtPhoneNumber);
            this.groupBoxDetails.Controls.Add(this.label2);
            this.groupBoxDetails.Controls.Add(this.txtVehicleModel);
            this.groupBoxDetails.Controls.Add(this.label1);
            this.groupBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetails.ForeColor = System.Drawing.Color.White;
            this.groupBoxDetails.Location = new System.Drawing.Point(6, 6);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(344, 129);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Vehicle Details";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNumber.Location = new System.Drawing.Point(107, 62);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(230, 20);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number:";
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.txtVehicleModel.ForeColor = System.Drawing.Color.White;
            this.txtVehicleModel.Location = new System.Drawing.Point(108, 24);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.ReadOnly = true;
            this.txtVehicleModel.Size = new System.Drawing.Size(230, 20);
            this.txtVehicleModel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Model:";
            // 
            // groupBoxHistory
            // 
            this.groupBoxHistory.Controls.Add(this.dataGridViewHistory);
            this.groupBoxHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHistory.ForeColor = System.Drawing.Color.White;
            this.groupBoxHistory.Location = new System.Drawing.Point(6, 142);
            this.groupBoxHistory.Name = "groupBoxHistory";
            this.groupBoxHistory.Size = new System.Drawing.Size(344, 323);
            this.groupBoxHistory.TabIndex = 1;
            this.groupBoxHistory.TabStop = false;
            this.groupBoxHistory.Text = "Service History";
//            this.groupBoxHistory.Enter += new System.EventHandler(this.groupBoxHistory_Enter);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dataGridViewHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceType,
            this.colMileage,
            this.colDate});
            this.dataGridViewHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistory.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersVisible = false;
            this.dataGridViewHistory.Size = new System.Drawing.Size(338, 304);
            this.dataGridViewHistory.TabIndex = 0;
            // 
            // colServiceType
            // 
            this.colServiceType.HeaderText = "Service Type";
            this.colServiceType.Name = "colServiceType";
            this.colServiceType.ReadOnly = true;
            this.colServiceType.Width = 130;
            // 
            // colMileage
            // 
            this.colMileage.HeaderText = "Mileage";
            this.colMileage.Name = "colMileage";
            this.colMileage.ReadOnly = true;
            this.colMileage.Width = 80;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // ucVehicleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.splitContainer);
            this.Name = "ucVehicleHistory";
            this.Size = new System.Drawing.Size(560, 500);
            this.Load += new System.EventHandler(this.ucVehicleHistory_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxVehicles.ResumeLayout(false);
            this.groupBoxVehicles.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.groupBoxHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtSearchModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.GroupBox groupBoxVehicles;
        private System.Windows.Forms.Label lblVehicleCount;
        private System.Windows.Forms.ListBox listBoxVehicles;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxHistory;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMileage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    }
}