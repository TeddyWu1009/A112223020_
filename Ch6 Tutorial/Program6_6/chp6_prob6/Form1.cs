using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chp6_prob6
{
    public partial class Form1 : Form
    {
        const decimal stayPerDay = 550.00m;
        public Form1()
        {
            InitializeComponent();
        }

        private decimal CalcStayCharges(int day)
        {
            return stayPerDay * day;
        }
        private decimal CalcMiscCharges(decimal foodBill, decimal spaBill, decimal carRental, decimal medicalBill)
        {
            return foodBill + spaBill + carRental + medicalBill;
        }
        private decimal CalcTotalCharges(decimal stayBill, decimal miscellaneous)
        {
            return stayBill = miscellaneous;
        }

        private bool InputIsValid(ref int days, ref decimal fb, ref decimal sb, ref decimal cb, ref decimal mb)
        {
            if (int.TryParse(textBox1.Text,out days) && 
                decimal.TryParse(textBox2.Text,out fb) &&
                decimal.TryParse(textBox3.Text,out sb) &&
                decimal.TryParse(textBox4.Text,out cb) &&
                decimal.TryParse(textBox5.Text,out mb))
            {
                return true;
            }
            else
            {
                MessageBox.Show("輸入資料格式有誤");
                return false;
            }
        }
        


            private void button1_Click(object sender, EventArgs e)
        {
            int days = 0;
            decimal fb = 0m, sb = 0m, cb = 0m , mb = 0m;
            decimal stayCharge, miscCharge;
            decimal totalCharge;
         
            if(InputIsValid(ref days, ref fb, ref cb, ref sb, ref mb))
            {
                stayCharge = CalcStayCharges(days);
                miscCharge = CalcMiscCharges(fb, sb, cb, mb);
                totalCharge = CalcTotalCharges(stayCharge, miscCharge);
                MessageBox.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
