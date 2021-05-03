using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateurDeMonnaies
{
    public partial class ChangeCalculatorForm : Form
    {
        public ChangeCalculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void PlayCoucaracha()
        {
            Console.Beep(1700, 100);
            Console.Beep(1700, 100);
            Console.Beep(1700, 100);
            Console.Beep(2300, 500);
            Console.Beep(2800, 300);
            Console.Beep(1700, 100);
            Console.Beep(1700, 100);
            Console.Beep(1700, 100);
            Console.Beep(2300, 500);
            Console.Beep(2800, 300);
            Console.Beep(2300, 100);
            Console.Beep(2300, 100);
            Console.Beep(2100, 100);
            Console.Beep(2100, 100);
            Console.Beep(1900, 100);
            Console.Beep(1900, 100);
            Console.Beep(1700, 500);
        }

        private void btn_Calculer_Click(object sender, EventArgs e)
        {
           
            decimal totalOf_5cents = numUpDwn_5cents.Value * decimal.Parse("0.05");
            decimal totalOf_10cents = numUpDwn_10cents.Value * decimal.Parse("0.1");
            decimal totalOf_25cents = numUpDwn_25cents.Value * decimal.Parse("0.25");
            decimal totalOf_1dollars = numUpDwn_1dollars.Value;
            decimal totalOf_2dollars = numUpDwn_2dollars.Value * decimal.Parse("2");
            decimal total = totalOf_5cents + totalOf_10cents + totalOf_25cents + totalOf_1dollars + totalOf_2dollars;

            lbl_total5cents.Text = totalOf_5cents.ToString("C");
            lbl_total10cents.Text = totalOf_10cents.ToString("C");
            lbl_total25cents.Text = totalOf_25cents.ToString("C");
            lbl_total1dollars.Text = totalOf_1dollars.ToString("C");
            lbl_total2dollars.Text = totalOf_2dollars.ToString("C");
            lbl_Total.Text = "Total : " + total.ToString("C");

            lbl_total5cents.Visible = true;
            lbl_total10cents.Visible = true;
            lbl_total25cents.Visible = true;
            lbl_total1dollars.Visible = true;
            lbl_total2dollars.Visible = true;
            lbl_Total.Visible = true;

        }
    }
}
