namespace Book
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NamePerson = new System.Windows.Forms.TextBox();
            this.Money = new System.Windows.Forms.TextBox();
            this.ClassNumber = new System.Windows.Forms.ComboBox();
            this.SpringType = new System.Windows.Forms.ComboBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.CostAll = new System.Windows.Forms.CheckBox();
            this.BookCount = new System.Windows.Forms.NumericUpDown();
            this.DateTimeNow = new System.Windows.Forms.Label();
            this.MoneyAll = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PersonPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.parsian = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BookCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(524, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "نرم افزار فنر زنی پارسیان نو";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(580, 97);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "تعداد کتاب :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(580, 144);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "نوع فنر :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(580, 190);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "نام و نام خانوادگی :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(580, 234);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(41, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "پایه :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(580, 278);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "پیش پرداخت :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NamePerson
            // 
            this.NamePerson.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NamePerson.Location = new System.Drawing.Point(227, 187);
            this.NamePerson.Name = "NamePerson";
            this.NamePerson.Size = new System.Drawing.Size(347, 31);
            this.NamePerson.TabIndex = 3;
            this.NamePerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Money
            // 
            this.Money.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Money.Location = new System.Drawing.Point(314, 275);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(260, 31);
            this.Money.TabIndex = 5;
            this.Money.TextChanged += new System.EventHandler(this.Money_TextChanged);
            this.Money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Money_KeyPress);
            // 
            // ClassNumber
            // 
            this.ClassNumber.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ClassNumber.FormattingEnabled = true;
            this.ClassNumber.Items.AddRange(new object[] {
            "اول",
            "دوم",
            "سوم",
            "چهارم",
            "پنجم",
            "ششم",
            "هفتم",
            "هشتم",
            "نهم",
            "دهم",
            "یازدهم",
            "دوازدهم",
            "غیره"});
            this.ClassNumber.Location = new System.Drawing.Point(392, 231);
            this.ClassNumber.Name = "ClassNumber";
            this.ClassNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ClassNumber.Size = new System.Drawing.Size(182, 31);
            this.ClassNumber.TabIndex = 4;
            // 
            // SpringType
            // 
            this.SpringType.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.SpringType.FormattingEnabled = true;
            this.SpringType.Items.AddRange(new object[] {
            "با جلد ضخیم",
            "با جلد نازک",
            "بدون جلد "});
            this.SpringType.Location = new System.Drawing.Point(392, 141);
            this.SpringType.Name = "SpringType";
            this.SpringType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SpringType.Size = new System.Drawing.Size(182, 31);
            this.SpringType.TabIndex = 2;
            // 
            // PrintBtn
            // 
            this.PrintBtn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PrintBtn.Location = new System.Drawing.Point(81, 455);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(147, 44);
            this.PrintBtn.TabIndex = 9;
            this.PrintBtn.Text = "چاپ ";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // CostAll
            // 
            this.CostAll.AutoSize = true;
            this.CostAll.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CostAll.Location = new System.Drawing.Point(148, 328);
            this.CostAll.Name = "CostAll";
            this.CostAll.Size = new System.Drawing.Size(80, 27);
            this.CostAll.TabIndex = 7;
            this.CostAll.Text = ": تسویه ";
            this.CostAll.UseVisualStyleBackColor = true;
            // 
            // BookCount
            // 
            this.BookCount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BookCount.Location = new System.Drawing.Point(454, 95);
            this.BookCount.Name = "BookCount";
            this.BookCount.Size = new System.Drawing.Size(120, 31);
            this.BookCount.TabIndex = 1;
            this.BookCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BookCount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.BookCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DateTimeNow
            // 
            this.DateTimeNow.AutoSize = true;
            this.DateTimeNow.Location = new System.Drawing.Point(104, 95);
            this.DateTimeNow.Name = "DateTimeNow";
            this.DateTimeNow.Size = new System.Drawing.Size(19, 13);
            this.DateTimeNow.TabIndex = 8;
            this.DateTimeNow.Text = "----";
            // 
            // MoneyAll
            // 
            this.MoneyAll.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MoneyAll.Location = new System.Drawing.Point(314, 324);
            this.MoneyAll.Name = "MoneyAll";
            this.MoneyAll.Size = new System.Drawing.Size(260, 31);
            this.MoneyAll.TabIndex = 6;
            this.MoneyAll.TextChanged += new System.EventHandler(this.MoneyAll_TextChanged);
            this.MoneyAll.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoneyAll_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(580, 327);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "مبلغ کل :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PersonPhone
            // 
            this.PersonPhone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PersonPhone.Location = new System.Drawing.Point(392, 373);
            this.PersonPhone.Name = "PersonPhone";
            this.PersonPhone.Size = new System.Drawing.Size(182, 31);
            this.PersonPhone.TabIndex = 8;
            this.PersonPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PersonPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonelPhone_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(580, 376);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "شماره مشتری :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // parsian
            // 
            this.parsian.AutoSize = true;
            this.parsian.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.parsian.Location = new System.Drawing.Point(81, 373);
            this.parsian.Name = "parsian";
            this.parsian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parsian.Size = new System.Drawing.Size(166, 23);
            this.parsian.TabIndex = 13;
            this.parsian.Text = "پارسیان نو : 34475280";
            this.parsian.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.parsian);
            this.Controls.Add(this.PersonPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MoneyAll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateTimeNow);
            this.Controls.Add(this.BookCount);
            this.Controls.Add(this.CostAll);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.SpringType);
            this.Controls.Add(this.ClassNumber);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.NamePerson);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "چاپ اطلاعات مشتری";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NamePerson;
        private System.Windows.Forms.TextBox Money;
        private System.Windows.Forms.ComboBox ClassNumber;
        private System.Windows.Forms.ComboBox SpringType;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.CheckBox CostAll;
        private System.Windows.Forms.NumericUpDown BookCount;
        private System.Windows.Forms.Label DateTimeNow;
        private System.Windows.Forms.TextBox MoneyAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PersonPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label parsian;
    }
}

