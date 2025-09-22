using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace Book
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private string printContent;
        Timer timer;

        public Form1()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;

            timer = new Timer();
            timer.Interval = 1000; // هر 1 ثانیه یکبار
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Tick(sender, e);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            PersianDateTime persianDateTime = new PersianDateTime(DateTime.Now);
            DateTimeNow.Text = persianDateTime.ToString("yyyy/MM/dd HH:mm:ss");
        }


        private void Money_TextChanged(object sender, EventArgs e)
        {
            //decimal amount = decimal.Parse(Money.Text);
            //Money.Text = amount.ToString("C2"); // نمایش به فرمت پولی
            if (decimal.TryParse(Money.Text.Replace(",", ""), out decimal value))
            {
                Money.TextChanged -= Money_TextChanged; // جلوگیری از اجرای مجدد رویداد
                Money.Text = string.Format("{0:N0}", value); // نمایش با جداکننده هزارگان
                Money.SelectionStart = Money.Text.Length; // نگه داشتن مکان‌نما در انتها
                Money.TextChanged += Money_TextChanged;
            }

        }
        private void Money_KeyPress(object sender, KeyPressEventArgs e)
        {

            // اجازه ورود فقط اعداد (0-9) و بک‌اسپیس
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // جلوگیری از ورود کاراکتر
            }
        }

        private void MoneyAll_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(MoneyAll.Text.Replace(",", ""), out decimal value))
            {
                MoneyAll.TextChanged -= MoneyAll_TextChanged; // جلوگیری از اجرای مجدد رویداد
                MoneyAll.Text = string.Format("{0:N0}", value); // نمایش با جداکننده هزارگان
                MoneyAll.SelectionStart = MoneyAll.Text.Length; // نگه داشتن مکان‌نما در انتها
                MoneyAll.TextChanged += MoneyAll_TextChanged;
            }
        }
        private void MoneyAll_KeyPress(object sender, KeyPressEventArgs e)
        {

            // اجازه ورود فقط اعداد (0-9) و بک‌اسپیس
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // جلوگیری از ورود کاراکتر
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            int customerNumber = GetNextCustomerNumber();
            // جمع‌آوری اطلاعات
            printContent =
                           $"\n شماره : {customerNumber}                    \t" +
                           $"تاریخ : {DateTimeNow.Text}\n" +
                           $"نام و نام خانوادگی: {NamePerson.Text}          \t" +
                           $"تعداد کتاب: {BookCount.Value}\n\n" +
                           // $"نوع فنر: {SpringType.SelectedItem}\n" +
                           $"پایه : {ClassNumber.SelectedItem}                        \t" +
                           $"تسویه شده : {CostAll.Checked}\n" +
                            $"مبلغ پیش پرداخت : {Money.Text}\n" +
                            $"مبلغ کل : {MoneyAll.Text}\n\n\n" +
                            $"شماره مشتری : {PersonPhone.Text}      \t" +
                            $"{parsian.Text} \n\n";
            // نمایش پنجره چاپ (اختیاری)
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Calibri", 12);
            float lineHeight = font.GetHeight(e.Graphics);
            string text = printContent;
            // Get the printable area size
            RectangleF printableArea = e.MarginBounds;
            // Measure the size of the text
            SizeF textSize = e.Graphics.MeasureString(text, font);
            // Calculate rectangle to center the text
            float rectX = printableArea.X;// + (printableArea.Width - textSize.Width) / 2;
            float rectY = printableArea.Y;// + (printableArea.Height - textSize.Height) / 2;
            RectangleF rect = new RectangleF(rectX, rectY, textSize.Width, textSize.Height);
            // Create StringFormat for center alignment and RTL if needed
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;          // Horizontal center
            format.LineAlignment = StringAlignment.Near;      // Vertical center
            format.FormatFlags = StringFormatFlags.DirectionRightToLeft;  // For RTL text
                                                                          // Draw border rectangle
            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
            }
            // Draw the text inside the rectangle, centered
            e.Graphics.DrawString(text, font, Brushes.Black, rect, format);
            e.HasMorePages = false;


            //float x = e.MarginBounds.X;
            //float y = e.MarginBounds.Top;


            //StringFormat format = new StringFormat();
            //format.Alignment = StringAlignment.Far; // راست‌چین کردن متن
            //format.FormatFlags = StringFormatFlags.DirectionRightToLeft; // جهت راست به چپ

            //// متن چاپ شده
            //string text = printContent;
            //// اندازه مستطیل دور متن را محاسبه می‌کنیم
            //SizeF textSize = e.Graphics.MeasureString(text, font);
            //RectangleF borderRect = new RectangleF(x - 10, y - 10, textSize.Width + 20, textSize.Height + 20);
            //e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(borderRect));
            //// چاپ متن داخل کادر

            //// چاپ نسخه اول
            //e.Graphics.DrawString(printContent, font, Brushes.Black, new PointF(x, y), format);
            ////// چاپ نسخه دوم کمی پایین‌تر (مثلاً 150 پیکسل پایین‌تر)
            ////e.Graphics.DrawString(printContent, font, Brushes.Black, x, y + 150);
            //// اگر فقط یک صفحه چاپ می‌شود
            //e.HasMorePages = false;
        }
        private (DateTime date, int number) ReadCustomerNumber()
        {
            string path = "CustomerNumber.txt";
            if (!File.Exists(path))
                return (DateTime.MinValue, 0);
            var lines = File.ReadAllLines(path);
            if (lines.Length < 2)
                return (DateTime.MinValue, 0);
            if (DateTime.TryParse(lines[0], out DateTime savedDate) && int.TryParse(lines[1], out int savedNumber))
            {
                return (savedDate, savedNumber);
            }
            return (DateTime.MinValue, 0);
        }
        private void SaveCustomerNumber(DateTime date, int number)
        {
            string path = "CustomerNumber.txt";
            File.WriteAllLines(path, new string[] { date.ToString("yyyy-MM-dd"), number.ToString() });
        }
        private int GetNextCustomerNumber()
        {
            var (savedDate, savedNumber) = ReadCustomerNumber();
            DateTime today = DateTime.Today;
            int nextNumber = 1;
            if (savedDate == today)
            {
                nextNumber = savedNumber + 1;
            }
            // ذخیره شماره جدید
            SaveCustomerNumber(today, nextNumber);
            return nextNumber;
        }
        private void PersonelPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // اجازه ورود فقط اعداد (0-9) و بک‌اسپیس
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // جلوگیری از ورود کاراکتر
            }
        }
    }
}
