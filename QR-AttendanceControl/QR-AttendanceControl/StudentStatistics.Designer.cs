namespace QR_AttendanceControl
{
    partial class StudentStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentStatistics));
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.tb_Search1 = new System.Windows.Forms.TextBox();
            this.btn_diagram = new System.Windows.Forms.Button();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AllowUserToResizeColumns = false;
            this.dgvSearch.AllowUserToResizeRows = false;
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1});
            this.dgvSearch.GridColor = System.Drawing.Color.White;
            this.dgvSearch.Location = new System.Drawing.Point(140, 324);
            this.dgvSearch.MultiSelect = false;
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowHeadersWidth = 51;
            this.dgvSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.ShowEditingIcon = false;
            this.dgvSearch.Size = new System.Drawing.Size(778, 336);
            this.dgvSearch.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.FillWeight = 116.8105F;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "surname";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Averta Demo PE Cutted Demo", 10F);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.FillWeight = 116.8105F;
            this.Column3.HeaderText = "Surname";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "middle_name";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Averta Demo PE Cutted Demo", 10F);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.FillWeight = 116.8105F;
            this.Column4.HeaderText = "Middle name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "date_time";
            this.Column1.FillWeight = 80.69143F;
            this.Column1.HeaderText = "Datetime";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.White;
            this.btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Clear.FlatAppearance.BorderSize = 2;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Averta Demo PE Cutted Demo", 10F);
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(792, 271);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(126, 37);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.White;
            this.btn_Export.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Export.FlatAppearance.BorderSize = 2;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Averta Demo PE Cutted Demo", 10F);
            this.btn_Export.ForeColor = System.Drawing.Color.Black;
            this.btn_Export.Location = new System.Drawing.Point(590, 271);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(180, 37);
            this.btn_Export.TabIndex = 11;
            this.btn_Export.Text = "Export to Excel";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // tb_Search1
            // 
            this.tb_Search1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_Search1.Location = new System.Drawing.Point(140, 271);
            this.tb_Search1.Multiline = true;
            this.tb_Search1.Name = "tb_Search1";
            this.tb_Search1.Size = new System.Drawing.Size(230, 37);
            this.tb_Search1.TabIndex = 12;
            this.tb_Search1.TextChanged += new System.EventHandler(this.tb_Search1_TextChanged);
            this.tb_Search1.Enter += new System.EventHandler(this.tb_Search1_Enter);
            this.tb_Search1.Leave += new System.EventHandler(this.tb_Search1_Leave);
            // 
            // btn_diagram
            // 
            this.btn_diagram.BackColor = System.Drawing.Color.White;
            this.btn_diagram.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_diagram.FlatAppearance.BorderSize = 2;
            this.btn_diagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diagram.Font = new System.Drawing.Font("Averta Demo PE Cutted Demo", 10F);
            this.btn_diagram.ForeColor = System.Drawing.Color.Black;
            this.btn_diagram.Location = new System.Drawing.Point(388, 271);
            this.btn_diagram.Name = "btn_diagram";
            this.btn_diagram.Size = new System.Drawing.Size(180, 37);
            this.btn_diagram.TabIndex = 15;
            this.btn_diagram.Text = "Number of visits";
            this.btn_diagram.UseVisualStyleBackColor = false;
            this.btn_diagram.Click += new System.EventHandler(this.btn_diagram_Click);
            // 
            // tb_1
            // 
            this.tb_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_1.Font = new System.Drawing.Font("Averta Demo PE Cutted Demo", 10F);
            this.tb_1.Location = new System.Drawing.Point(343, 237);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(36, 22);
            this.tb_1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Averta Demo PE Cutted Demo", 10F);
            this.label1.Location = new System.Drawing.Point(140, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Количество посещений:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Averta Demo PE", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Student attendance";
            // 
            // StudentStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 699);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.btn_diagram);
            this.Controls.Add(this.tb_Search1);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dgvSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentStatistics";
            this.Text = "StudentStatistics";
            this.Shown += new System.EventHandler(this.StudentStatistics_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.TextBox tb_Search1;
        private System.Windows.Forms.Button btn_diagram;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}