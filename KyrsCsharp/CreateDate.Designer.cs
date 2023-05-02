namespace KyrcCsharp
{
    partial class CreateDate
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
            this.button1 = new System.Windows.Forms.Button();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textMonth = new System.Windows.Forms.TextBox();
            this.textDay = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowDate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancel";
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(334, 30);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(100, 20);
            this.textYear.TabIndex = 1;
            // 
            // textMonth
            // 
            this.textMonth.Location = new System.Drawing.Point(334, 72);
            this.textMonth.Name = "textMonth";
            this.textMonth.Size = new System.Drawing.Size(100, 20);
            this.textMonth.TabIndex = 2;
            // 
            // textDay
            // 
            this.textDay.Location = new System.Drawing.Point(334, 119);
            this.textDay.Name = "textDay";
            this.textDay.Size = new System.Drawing.Size(100, 20);
            this.textDay.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(279, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ok";
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Day";
            // 
            // ShowDate
            // 
            this.ShowDate.FormattingEnabled = true;
            this.ShowDate.Location = new System.Drawing.Point(12, 12);
            this.ShowDate.Name = "ShowDate";
            this.ShowDate.Size = new System.Drawing.Size(258, 199);
            this.ShowDate.TabIndex = 12;
            // 
            // CreateDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 218);
            this.Controls.Add(this.ShowDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textDay);
            this.Controls.Add(this.textMonth);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.button1);
            this.Name = "CreateDate";
            this.Text = "Date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textMonth;
        private System.Windows.Forms.TextBox textDay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ShowDate;
    }
}