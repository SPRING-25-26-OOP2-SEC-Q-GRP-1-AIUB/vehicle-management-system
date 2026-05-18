namespace salesexecutivepanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btndashboard = new System.Windows.Forms.Button();
            this.sbmenu_customercontrol = new System.Windows.Forms.Panel();
            this.btnupdatecustomer = new System.Windows.Forms.Button();
            this.btnviewcustomer = new System.Windows.Forms.Button();
            this.btnaddnewcustomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnpaymentinfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.sbmenu_customercontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.sbmenu_customercontrol);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 694);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::salesexecutivepanel.Properties.Resources.giphy__1_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 357);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Lime;
            this.username.Location = new System.Drawing.Point(69, 106);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(115, 25);
            this.username.TabIndex = 13;
            this.username.Text = "Sales panel";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::salesexecutivepanel.Properties.Resources._38910a2a8d615cf8ca485212e8f1e592;
            this.pictureBox3.Location = new System.Drawing.Point(77, 34);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(107, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btndashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(1, 151);
            this.btndashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(259, 39);
            this.btndashboard.TabIndex = 7;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // sbmenu_customercontrol
            // 
            this.sbmenu_customercontrol.Controls.Add(this.btnpaymentinfo);
            this.sbmenu_customercontrol.Controls.Add(this.btnupdatecustomer);
            this.sbmenu_customercontrol.Controls.Add(this.btnviewcustomer);
            this.sbmenu_customercontrol.Controls.Add(this.btnaddnewcustomer);
            this.sbmenu_customercontrol.Location = new System.Drawing.Point(0, 194);
            this.sbmenu_customercontrol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbmenu_customercontrol.Name = "sbmenu_customercontrol";
            this.sbmenu_customercontrol.Size = new System.Drawing.Size(269, 161);
            this.sbmenu_customercontrol.TabIndex = 0;
            // 
            // btnupdatecustomer
            // 
            this.btnupdatecustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnupdatecustomer.FlatAppearance.BorderSize = 0;
            this.btnupdatecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdatecustomer.ForeColor = System.Drawing.Color.White;
            this.btnupdatecustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdatecustomer.Location = new System.Drawing.Point(0, 78);
            this.btnupdatecustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdatecustomer.Name = "btnupdatecustomer";
            this.btnupdatecustomer.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnupdatecustomer.Size = new System.Drawing.Size(269, 39);
            this.btnupdatecustomer.TabIndex = 5;
            this.btnupdatecustomer.Text = "Order portal";
            this.btnupdatecustomer.UseVisualStyleBackColor = true;
            this.btnupdatecustomer.Click += new System.EventHandler(this.btnupdatecustomer_Click);
            // 
            // btnviewcustomer
            // 
            this.btnviewcustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnviewcustomer.FlatAppearance.BorderSize = 0;
            this.btnviewcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewcustomer.ForeColor = System.Drawing.Color.White;
            this.btnviewcustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewcustomer.Location = new System.Drawing.Point(0, 39);
            this.btnviewcustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnviewcustomer.Name = "btnviewcustomer";
            this.btnviewcustomer.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.btnviewcustomer.Size = new System.Drawing.Size(269, 39);
            this.btnviewcustomer.TabIndex = 9;
            this.btnviewcustomer.Text = "Car portal";
            this.btnviewcustomer.UseVisualStyleBackColor = true;
            this.btnviewcustomer.Click += new System.EventHandler(this.btnviewcustomer_Click);
            // 
            // btnaddnewcustomer
            // 
            this.btnaddnewcustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnaddnewcustomer.FlatAppearance.BorderSize = 0;
            this.btnaddnewcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddnewcustomer.ForeColor = System.Drawing.Color.White;
            this.btnaddnewcustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddnewcustomer.Location = new System.Drawing.Point(0, 0);
            this.btnaddnewcustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnaddnewcustomer.Name = "btnaddnewcustomer";
            this.btnaddnewcustomer.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnaddnewcustomer.Size = new System.Drawing.Size(269, 39);
            this.btnaddnewcustomer.TabIndex = 8;
            this.btnaddnewcustomer.Text = "Customer portal";
            this.btnaddnewcustomer.UseVisualStyleBackColor = true;
            this.btnaddnewcustomer.Click += new System.EventHandler(this.btnaddnewcustomer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Location = new System.Drawing.Point(268, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 694);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnpaymentinfo
            // 
            this.btnpaymentinfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpaymentinfo.FlatAppearance.BorderSize = 0;
            this.btnpaymentinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpaymentinfo.ForeColor = System.Drawing.Color.White;
            this.btnpaymentinfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpaymentinfo.Location = new System.Drawing.Point(0, 117);
            this.btnpaymentinfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnpaymentinfo.Name = "btnpaymentinfo";
            this.btnpaymentinfo.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnpaymentinfo.Size = new System.Drawing.Size(269, 39);
            this.btnpaymentinfo.TabIndex = 10;
            this.btnpaymentinfo.Text = "Payment info";
            this.btnpaymentinfo.UseVisualStyleBackColor = true;
            this.btnpaymentinfo.Click += new System.EventHandler(this.btnpaymentinfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Executive Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.sbmenu_customercontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sbmenu_customercontrol;
        private System.Windows.Forms.Button btnaddnewcustomer;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button btnupdatecustomer;
        private System.Windows.Forms.Button btnviewcustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnpaymentinfo;
    }
}

