namespace Joke
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Yes = new System.Windows.Forms.Button();
            this.btn_No = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_Arrows = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Arrows)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Yes
            // 
            this.btn_Yes.Location = new System.Drawing.Point(100, 260);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(123, 37);
            this.btn_Yes.TabIndex = 0;
            this.btn_Yes.TabStop = false;
            this.btn_Yes.Text = "Да";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // btn_No
            // 
            this.btn_No.Location = new System.Drawing.Point(304, 260);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(123, 37);
            this.btn_No.TabIndex = 1;
            this.btn_No.TabStop = false;
            this.btn_No.Text = "Нет";
            this.btn_No.UseVisualStyleBackColor = true;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Averta Demo PE", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Нравится ли вам наша программа обучения ?";
            // 
            // pb_Arrows
            // 
            this.pb_Arrows.Image = ((System.Drawing.Image)(resources.GetObject("pb_Arrows.Image")));
            this.pb_Arrows.Location = new System.Drawing.Point(61, 147);
            this.pb_Arrows.Name = "pb_Arrows";
            this.pb_Arrows.Size = new System.Drawing.Size(201, 107);
            this.pb_Arrows.TabIndex = 3;
            this.pb_Arrows.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 318);
            this.Controls.Add(this.pb_Arrows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_No);
            this.Controls.Add(this.btn_Yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_Arrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_Arrows;
    }
}

