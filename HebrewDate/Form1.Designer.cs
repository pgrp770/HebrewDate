namespace HebrewDate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxYear = new ComboBox();
            comboBoxMonth = new ComboBox();
            comboBoxDaysInAMonth = new ComboBox();
            comboBoxDaysInAWeek = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            comboBoxYear.Location = new Point(107, 269);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.RightToLeft = RightToLeft.Yes;
            comboBoxYear.Size = new Size(242, 40);
            comboBoxYear.TabIndex = 0;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            comboBoxMonth.Location = new Point(402, 269);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.RightToLeft = RightToLeft.Yes;
            comboBoxMonth.Size = new Size(242, 40);
            comboBoxMonth.TabIndex = 1;
            // 
            // comboBoxDaysInAMonth
            // 
            comboBoxDaysInAMonth.FormattingEnabled = true;
            comboBoxDaysInAMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            comboBoxDaysInAMonth.Location = new Point(700, 269);
            comboBoxDaysInAMonth.Name = "comboBoxDaysInAMonth";
            comboBoxDaysInAMonth.RightToLeft = RightToLeft.Yes;
            comboBoxDaysInAMonth.Size = new Size(242, 40);
            comboBoxDaysInAMonth.TabIndex = 2;
            // 
            // comboBoxDaysInAWeek
            // 
            comboBoxDaysInAWeek.FormattingEnabled = true;
            comboBoxDaysInAWeek.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            comboBoxDaysInAWeek.Location = new Point(1003, 269);
            comboBoxDaysInAWeek.Name = "comboBoxDaysInAWeek";
            comboBoxDaysInAWeek.RightToLeft = RightToLeft.Yes;
            comboBoxDaysInAWeek.Size = new Size(242, 40);
            comboBoxDaysInAWeek.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 209);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(59, 32);
            label1.TabIndex = 4;
            label1.Text = "שנה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 209);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(67, 32);
            label2.TabIndex = 5;
            label2.Text = "חודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1063, 209);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(134, 32);
            label3.TabIndex = 7;
            label3.Text = "היום בשבוע";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(756, 209);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(133, 32);
            label4.TabIndex = 6;
            label4.Text = "היום בחודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(598, 108);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(152, 32);
            label5.TabIndex = 8;
            label5.Text = "כתיבת תאריך";
            // 
            // button1
            // 
            button1.Location = new Point(568, 437);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(239, 46);
            button1.TabIndex = 9;
            button1.Text = "שלח שאילתה";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 1047);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxDaysInAWeek);
            Controls.Add(comboBoxDaysInAMonth);
            Controls.Add(comboBoxMonth);
            Controls.Add(comboBoxYear);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxYear;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxDaysInAMonth;
        private ComboBox comboBoxDaysInAWeek;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
