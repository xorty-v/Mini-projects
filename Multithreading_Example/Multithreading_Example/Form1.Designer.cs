namespace Multithreading_Example
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
            this.prog_bar = new System.Windows.Forms.ProgressBar();
            this.butStart = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prog_bar
            // 
            this.prog_bar.Location = new System.Drawing.Point(15, 24);
            this.prog_bar.Name = "prog_bar";
            this.prog_bar.Size = new System.Drawing.Size(766, 37);
            this.prog_bar.TabIndex = 0;
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(274, 98);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(105, 37);
            this.butStart.TabIndex = 1;
            this.butStart.Text = "Старт";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.but_Start_Click);
            // 
            // butStop
            // 
            this.butStop.Enabled = false;
            this.butStop.Location = new System.Drawing.Point(422, 98);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(105, 37);
            this.butStop.TabIndex = 2;
            this.butStop.Text = "Стоп";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.but_Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 159);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.prog_bar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prog_bar;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butStop;
    }
}

