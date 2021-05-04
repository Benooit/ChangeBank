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
        private StructMonnaies monnaies;
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
            monnaies = new StructMonnaies(numUpDwn_5cents.Value, numUpDwn_10cents.Value, numUpDwn_25cents.Value, numUpDwn_1dollars.Value, numUpDwn_2dollars.Value);
         
            lbl_total5cents.Text = monnaies.ValueOf5cents.ToString("C");
            lbl_total10cents.Text = monnaies.ValueOf10cents.ToString("C");
            lbl_total25cents.Text = monnaies.ValueOf25cents.ToString("C");
            lbl_total1dollars.Text = monnaies.ValueOf1dollars.ToString("C");
            lbl_total2dollars.Text = monnaies.ValueOf2dollars.ToString("C");
            lbl_Total.Text = "Total : " + monnaies.TotalValue.ToString("C");

            lbl_total5cents.Visible = true;
            lbl_total10cents.Visible = true;
            lbl_total25cents.Visible = true;
            lbl_total1dollars.Visible = true;
            lbl_total2dollars.Visible = true;
            lbl_Total.Visible = true;

            

        }
    }
}
