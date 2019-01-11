using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCalculator {
    public partial class FRMAdvancedCalculatorDSte : Form {
        public FRMAdvancedCalculatorDSte() {
            InitializeComponent();
        }

        private void FRMAdvancedCalculatorDSte_Load(object sender, EventArgs e) {
            LblOutputDSte.Text = "";
        }

        private void BtnPlusDSte_Click(object sender, EventArgs e) {
            CalculateDSte(TbxNumb1DSte.Text, "+", TbxNumb2DSte.Text);
        }

        private void BtnTimesDSte_Click(object sender, EventArgs e) {
            CalculateDSte(TbxNumb1DSte.Text, "*", TbxNumb2DSte.Text);

        }

        private void BtnMinDSte_Click(object sender, EventArgs e) {
            CalculateDSte(TbxNumb1DSte.Text, "-", TbxNumb2DSte.Text);
        }

        private void BtnDevideDSte_Click(object sender, EventArgs e) {
            CalculateDSte(TbxNumb1DSte.Text, "/", TbxNumb2DSte.Text);
        }

        private void CalculateDSte(String number1, String Operator, String number2) {

            if (number1 == "" || number2 == "") {
                MessageBox.Show("Please enter two numbers.");
                return;
            }

            double num1 = ToIntDSte(number1);
            double num2 = ToIntDSte(number2);

            switch (Operator) {
                case "+":
                    LblOutputDSte.Text = "" + (num1 + num2);
                    break;
                case "*":
                    LblOutputDSte.Text = "" + (num1 * num2);
                    break;
                case "-":
                    LblOutputDSte.Text = "" + (num1 - num2);
                    break;
                case "/":
                    if (num1 != 0 && num2 != 0) {
                        LblOutputDSte.Text = "" + (num1 / num2);
                    } else {
                        MessageBox.Show("WHOOPS, can't divide by 0 dumy");
                    }
                    break;

                default:
                    MessageBox.Show("Unknown value entered");
                    break;
            }
        }

        private int ToIntDSte(String num) {
            try {
                return Convert.ToInt32(num);
            }
            catch(Exception e) {
                Console.WriteLine(e.StackTrace);
                return 1;
            }
        }
    }
}
