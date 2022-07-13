namespace QR_AttendanceControl
{
    partial class Scanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scanner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Camera = new System.Windows.Forms.Label();
            this.pbWebCam = new System.Windows.Forms.PictureBox();
            this.lbCams = new System.Windows.Forms.ComboBox();
            this.btn_menu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Scan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lb_Camera);
            this.panel1.Controls.Add(this.pbWebCam);
            this.panel1.Controls.Add(this.lbCams);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 542);
            this.panel1.TabIndex = 6;
            // 
            // lb_Camera
            // 
            this.lb_Camera.AutoSize = true;
            this.lb_Camera.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lb_Camera.ForeColor = System.Drawing.Color.White;
            this.lb_Camera.Location = new System.Drawing.Point(12, 494);
            this.lb_Camera.Name = "lb_Camera";
            this.lb_Camera.Size = new System.Drawing.Size(100, 32);
            this.lb_Camera.TabIndex = 4;
            this.lb_Camera.Text = "Camera:";
            // 
            // pbWebCam
            // 
            this.pbWebCam.Location = new System.Drawing.Point(12, 12);
            this.pbWebCam.Name = "pbWebCam";
            this.pbWebCam.Size = new System.Drawing.Size(560, 470);
            this.pbWebCam.TabIndex = 1;
            this.pbWebCam.TabStop = false;
            // 
            // lbCams
            // 
            this.lbCams.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbCams.FormattingEnabled = true;
            this.lbCams.Location = new System.Drawing.Point(119, 495);
            this.lbCams.Margin = new System.Windows.Forms.Padding(4);
            this.lbCams.Name = "lbCams";
            this.lbCams.Size = new System.Drawing.Size(453, 31);
            this.lbCams.TabIndex = 0;
            this.lbCams.TabStop = false;
            // 
            // btn_menu
            // 
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(1100, 494);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(47, 42);
            this.btn_menu.TabIndex = 11;
            this.btn_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(585, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 16);
            this.panel2.TabIndex = 10;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(1097, 31);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(51, 23);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Scan
            // 
            this.btn_Scan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Scan.FlatAppearance.BorderSize = 0;
            this.btn_Scan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Scan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Scan.ForeColor = System.Drawing.Color.White;
            this.btn_Scan.Location = new System.Drawing.Point(811, 496);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(118, 40);
            this.btn_Scan.TabIndex = 8;
            this.btn_Scan.Text = "Scan";
            this.btn_Scan.UseVisualStyleBackColor = false;
            this.btn_Scan.Click += new System.EventHandler(this.btn_Scan_Click);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 542);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Scan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanner";
            this.Load += new System.EventHandler(this.Scanner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Camera;
        private System.Windows.Forms.PictureBox pbWebCam;
        private System.Windows.Forms.ComboBox lbCams;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Scan;
    }
}