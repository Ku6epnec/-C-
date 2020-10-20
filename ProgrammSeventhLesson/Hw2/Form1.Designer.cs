namespace Hw2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lblRnd = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Загадано число от 1 до 100, попробуй угадай!";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(315, 189);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 2;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // lblRnd
            // 
            this.lblRnd.AutoSize = true;
            this.lblRnd.Location = new System.Drawing.Point(119, 269);
            this.lblRnd.Name = "lblRnd";
            this.lblRnd.Size = new System.Drawing.Size(13, 13);
            this.lblRnd.TabIndex = 3;
            this.lblRnd.Text = "0";
            this.lblRnd.Visible = false;
            this.lblRnd.Click += new System.EventHandler(this.lvlRnd_Click);
            // 
            // lblEqual
            // 
            this.lblEqual.Location = new System.Drawing.Point(122, 187);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(75, 23);
            this.lblEqual.TabIndex = 4;
            this.lblEqual.Text = "Проверить";
            this.lblEqual.UseVisualStyleBackColor = true;
            this.lblEqual.Click += new System.EventHandler(this.lblEqual_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblRnd);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button lblEqual;
        public System.Windows.Forms.Label lblRnd;
    }
}

