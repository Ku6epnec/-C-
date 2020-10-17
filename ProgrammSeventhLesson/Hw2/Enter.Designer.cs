namespace Hw2
{
    partial class Enter
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
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.lblEqual = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(12, 12);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(100, 20);
            this.txtEnter.TabIndex = 0;
            this.txtEnter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEqual
            // 
            this.lblEqual.Location = new System.Drawing.Point(145, 10);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(75, 23);
            this.lblEqual.TabIndex = 5;
            this.lblEqual.Text = "Проверить";
            this.lblEqual.UseVisualStyleBackColor = true;
            this.lblEqual.Click += new System.EventHandler(this.lblEqual_Click);
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(166, 50);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(13, 13);
            this.counter.TabIndex = 6;
            this.counter.Text = "0";
            this.counter.Visible = false;
            this.counter.Click += new System.EventHandler(this.counter_Click);
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 72);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.txtEnter);
            this.Name = "Enter";
            this.Text = "Enter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Button lblEqual;
        private System.Windows.Forms.Label counter;
    }
}