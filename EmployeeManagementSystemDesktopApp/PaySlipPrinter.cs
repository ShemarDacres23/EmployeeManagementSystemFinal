using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace EmployeeManagementSystemDesktopApp
{
    internal class PaySlipPrinter
    {
        private string employeeID;
        private string employeeName;
        private string position;
        private decimal salary;
        private decimal educationTax;
        private decimal nht;
        private decimal nis;
        private decimal netSalary;

        public PaySlipPrinter(string empID, string empName, string empPosition, decimal empSalary, decimal eduTax, decimal nhtD, decimal nisD, decimal netSal)
        {
            employeeID = empID;
            employeeName = empName;
            position = empPosition;
            salary = empSalary;
            educationTax = eduTax;
            nht = nhtD;
            nis = nisD;
            netSalary = netSal;
        }

        public void PrintPaySlip()
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintPaySlipPage);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDoc
            };

            if (previewDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintPaySlipPage(object sender, PrintPageEventArgs e)
        {
            // Set landscape dimensions
            e.PageSettings.Landscape = true;

            // Define fonts and colors
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font contentFont = new Font("Arial", 12);
            Font highlightFont = new Font("Arial", 14, FontStyle.Bold);
            Brush brush = Brushes.Black;
            Brush whiteBrush = Brushes.White;
            Pen borderPen = new Pen(Color.Gray, 3);

            // Set margins
            float marginLeft = 50;
            float marginTop = 50;
            float pageWidth = e.PageBounds.Width - 100; // Full width minus margins
            float sectionWidth = pageWidth / 2; // Split into two sections
            float contentStartY = marginTop + 100;

            // Draw header background across full width
            e.Graphics.FillRectangle(Brushes.DarkBlue, marginLeft, marginTop, pageWidth, 100);

            // Try adding company logo
            try
            {
                Image logo = Image.FromFile(@"C:\Users\gcfc\Downloads\Microsoft-Logo.png"); // Change path
                e.Graphics.DrawImage(logo, marginLeft + 20, marginTop + 20, 80, 80); // Adjust logo position
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logo: " + ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Company name & title (Centered)
            e.Graphics.DrawString("XYZ Company", titleFont, whiteBrush, marginLeft + 120, marginTop + 30);
            e.Graphics.DrawString("PAY SLIP", headerFont, whiteBrush, marginLeft + 120, marginTop + 65);

            // Draw border for the payslip
            e.Graphics.DrawRectangle(borderPen, marginLeft, contentStartY, pageWidth, 350);

            float y = contentStartY + 20;

            // Left Column - Employee Information
            e.Graphics.DrawString("Employee Information", headerFont, brush, marginLeft + 20, y);
            y += 30;
            e.Graphics.DrawString($"Employee ID: {employeeID}", contentFont, brush, marginLeft + 20, y);
            y += 25;
            e.Graphics.DrawString($"Name: {employeeName}", contentFont, brush, marginLeft + 20, y);
            y += 25;
            e.Graphics.DrawString($"Position: {position}", contentFont, brush, marginLeft + 20, y);
            y += 50;

            // Right Column - Salary Breakdown (Aligned to second half of page)
            float rightColumnX = marginLeft + sectionWidth + 50;
            float rightColumnY = contentStartY + 20;
            e.Graphics.DrawString("Salary Breakdown", headerFont, brush, rightColumnX, rightColumnY);
            rightColumnY += 30;
            e.Graphics.DrawString($"Gross Salary: {salary:C}", contentFont, brush, rightColumnX, rightColumnY);
            rightColumnY += 25;
            e.Graphics.DrawString($"Education Tax (2.5%): {educationTax:C}", contentFont, brush, rightColumnX, rightColumnY);
            rightColumnY += 25;
            e.Graphics.DrawString($"NHT (3%): {nht:C}", contentFont, brush, rightColumnX, rightColumnY);
            rightColumnY += 25;
            e.Graphics.DrawString($"NIS (5%): {nis:C}", contentFont, brush, rightColumnX, rightColumnY);
            rightColumnY += 50;

            // Net Salary Highlight (Centered at the bottom)
            float netSalaryY = Math.Max(y, rightColumnY) + 20;
            e.Graphics.FillRectangle(Brushes.LightGray, marginLeft + 10, netSalaryY, pageWidth - 20, 40);
            e.Graphics.DrawString($"Net Salary: {netSalary:C}", highlightFont, brush, marginLeft + 30, netSalaryY + 10);
        }


    }
}
