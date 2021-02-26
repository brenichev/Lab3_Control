namespace TestControlsApplication
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
            this.components = new System.ComponentModel.Container();
            this.colorControl1 = new LabControls.ColorControl();
            this.colorTextBox1 = new LabControls.ColorTextBox(this.components);
            this.filePathSelect1 = new LabControls.FilePathSelect();
            this.numberBox1 = new LabControls.NumberBox(this.components);
            this.SuspendLayout();
            // 
            // colorControl1
            // 
            this.colorControl1.Location = new System.Drawing.Point(334, 12);
            this.colorControl1.MyColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorControl1.Name = "colorControl1";
            this.colorControl1.Size = new System.Drawing.Size(230, 108);
            this.colorControl1.TabIndex = 3;
            // 
            // colorTextBox1
            // 
            this.colorTextBox1.Location = new System.Drawing.Point(12, 12);
            this.colorTextBox1.Name = "colorTextBox1";
            this.colorTextBox1.Number = true;
            this.colorTextBox1.Size = new System.Drawing.Size(100, 20);
            this.colorTextBox1.TabIndex = 2;
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.FileName = "123";
            this.filePathSelect1.Location = new System.Drawing.Point(12, 64);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(305, 22);
            this.filePathSelect1.TabIndex = 1;
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(12, 38);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(100, 20);
            this.numberBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 142);
            this.Controls.Add(this.colorControl1);
            this.Controls.Add(this.colorTextBox1);
            this.Controls.Add(this.filePathSelect1);
            this.Controls.Add(this.numberBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabControls.NumberBox numberBox1;
        private LabControls.FilePathSelect filePathSelect1;
        private LabControls.ColorTextBox colorTextBox1;
        private LabControls.ColorControl colorControl1;
    }
}

