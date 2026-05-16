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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 564);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::salesexecutivepanel.Properties.Resources.giphy__1_;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 301);
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
            this.username.Location = new System.Drawing.Point(52, 86);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(92, 20);
            this.username.TabIndex = 13;
            this.username.Text = "Sales panel";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::salesexecutivepanel.Properties.Resources._38910a2a8d615cf8ca485212e8f1e592;
            this.pictureBox3.Location = new System.Drawing.Point(58, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 50);
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
            this.btndashboard.Location = new System.Drawing.Point(1, 123);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(194, 32);
            this.btndashboard.TabIndex = 7;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // sbmenu_customercontrol
            // 
            this.sbmenu_customercontrol.Controls.Add(this.btnupdatecustomer);
            this.sbmenu_customercontrol.Controls.Add(this.btnviewcustomer);
            this.sbmenu_customercontrol.Controls.Add(this.btnaddnewcustomer);
            this.sbmenu_customercontrol.Location = new System.Drawing.Point(0, 158);
            this.sbmenu_customercontrol.Name = "sbmenu_customercontrol";
            this.sbmenu_customercontrol.Size = new System.Drawing.Size(202, 100);
            this.sbmenu_customercontrol.TabIndex = 0;
            // 
            // btnupdatecustomer
            // 
            this.btnupdatecustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnupdatecustomer.FlatAppearance.BorderSize = 0;
            this.btnupdatecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdatecustomer.ForeColor = System.Drawing.Color.White;
            this.btnupdatecustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdatecustomer.Location = new System.Drawing.Point(0, 64);
            this.btnupdatecustomer.Name = "btnupdatecustomer";
            this.btnupdatecustomer.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnupdatecustomer.Size = new System.Drawing.Size(202, 32);
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
            this.btnviewcustomer.Location = new System.Drawing.Point(0, 32);
            this.btnviewcustomer.Name = "btnviewcustomer";
            this.btnviewcustomer.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnviewcustomer.Size = new System.Drawing.Size(202, 32);
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
            this.btnaddnewcustomer.Name = "btnaddnewcustomer";
            this.btnaddnewcustomer.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnaddnewcustomer.Size = new System.Drawing.Size(202, 32);
            this.btnaddnewcustomer.TabIndex = 8;
            this.btnaddnewcustomer.Text = "Customer portal";
            this.btnaddnewcustomer.UseVisualStyleBackColor = true;
            this.btnaddnewcustomer.Click += new System.EventHandler(this.btnaddnewcustomer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Location = new System.Drawing.Point(201, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 564);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}

