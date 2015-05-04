using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentYearlyCostCalculatorApp
{
    public partial class yarlyCostCalculator : Form
    {
        public yarlyCostCalculator()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                classListComboBox.Items.Add("Class " + i);
            }
        }
        private List<double> admissionFeeList = new List<double>()
        {
            10000,10000,10000,10000,10000,12000,12000,12000,15000,15000,15000,15000
        };
        private List<double> monthlyFeeList = new List<double>()
        {
            500,500,1000,1000,1000,1500,1500,1500,2000,2000,2700,2700
        };
        private void totalCalculationButton_Click(object sender, EventArgs e)
        {
            if (classListComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item from list.");
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {
                    if (classListComboBox.SelectedIndex == i)
                    {
                        double totalAmount = admissionFeeList[i] + (monthlyFeeList[i] * 12);
                        if (discountCheckBox.Checked == false)
                        {
                            MessageBox.Show("Total Amount for one year : " + totalAmount);
                        }
                        else
                        {
                            double totalAmountWithDiscount = totalAmount - (totalAmount * 5) / 100;
                            MessageBox.Show("Total amount for one year with discount : " + totalAmountWithDiscount);
                        }
                    }
                }
            }
        }
    }
}

