using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NikaoCalculatorApp
{
    public partial class Form1 : Form
    {

        private double? firstNumber;
        private double? secondNumber;
        private double? result;
        private string processType;
        private bool numberEntry;

        public Form1()
        {
            InitializeComponent();

            firstNumber = null;
            secondNumber = null;
            result = null;
            processType = null;
            richTextBox1.Text = "0";
            numberEntry = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculator(Button button)
        {

            var type = button.Tag.ToString();
            var processBox = richTextBox1;
            switch (type)
            {
                case "number":

                    if (processBox.Text == "0" || processBox.Text == null || numberEntry == false)
                    {

                        processBox.Text = button.Text;
                        numberEntry = true;
                    }
                    else if (numberEntry == true)
                    {

                        processBox.Text = processBox.Text + button.Text;
                    }
                    break;

                case "processType":

                    if (button.Text == "," && processBox.Text.IndexOf(',') == -1)
                    {

                        processBox.Text = processBox.Text + button.Text;
                    }
                    else if (button.Text == "+" || button.Text == "-" || button.Text == "x" || button.Text == "/")
                    {


                        if (firstNumber == null)
                        {
                            firstNumber = Convert.ToDouble(processBox.Text);
                            processType = button.Text;
                            numberEntry = false;
                        }
                        else
                        {

                            MessageBox.Show("İşlem tipi seçili !!!");
                        }

                    }
                    else if (button.Text == "=")
                    {
                        secondNumber = Convert.ToDouble(processBox.Text);


                        if (processType == null)
                        {

                            MessageBox.Show("İşlem Tipi Seçiniz !!!");
                        }
                        else if (secondNumber == null)
                        {

                            MessageBox.Show("Sayı giriniz !!!");
                        }
                        else if (firstNumber != null && secondNumber != null)
                        {

                            if (processType == "+")
                            {

                                result = firstNumber + secondNumber;
                                processBox.Text = result.ToString();

                            }
                            else if (processType == "-")
                            {

                                result = firstNumber - secondNumber;
                                processBox.Text = result.ToString();

                            }
                            else if (processType == "x")
                            {

                                result = firstNumber * secondNumber;
                                processBox.Text = result.ToString();

                            }
                            else if (processType == "/")
                            {

                                if (secondNumber == 0)
                                {

                                    MessageBox.Show("Bölme hatası !!!");
                                }
                                else
                                {
                                    result = firstNumber / secondNumber;
                                    processBox.Text = result.ToString();

                                }
                            }

                            firstNumber = null;
                            secondNumber = null;
                            processType = null;
                        }




                    }
                    else if (button.Text == "Clear")
                    {

                        processBox.Text = "0";
                        firstNumber = null;
                        secondNumber = null;
                        processType = null;
                    }
                    else if (button.Text == "Delete")
                    {

                        var item = processBox.Text.Substring(0, processBox.TextLength - 1);

                        if (item.Length == 0)
                        {

                            processBox.Text = "0";
                        }
                        else
                        {
                            processBox.Text = item;
                        }
                    }

                    break;


            }

        }


        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void equalsChacter_Click(object sender, EventArgs e)
        {
            Calculator(equalsChacter);
        }

        private void addition_Click(object sender, EventArgs e)
        {

            Calculator(addition);
        }

        private void extractionProcess_Click(object sender, EventArgs e)
        {

            Calculator(extractionProcess);
        }

        private void multiplication_Click(object sender, EventArgs e)
        {

            Calculator(multiplication);
        }

        private void division_Click(object sender, EventArgs e)
        {

            Calculator(division);
        }

        private void delete_Click(object sender, EventArgs e)
        {

            Calculator(delete);
        }

        private void clean_Click(object sender, EventArgs e)
        {

            Calculator(clean);
        }

        private void commaChacter_Click(object sender, EventArgs e)
        {

            Calculator(commaChacter);
        }

        private void numberZero_Click(object sender, EventArgs e)
        {

            Calculator(numberZero);
        }

        private void numberOne_Click(object sender, EventArgs e)
        {

            Calculator(numberOne);
        }

        private void numberTwo_Click(object sender, EventArgs e)
        {

            Calculator(numberTwo);
        }
        private void numberThree_Click(object sender, EventArgs e)
        {

            Calculator(numberThree);
        }

        private void numberFour_Click(object sender, EventArgs e)
        {

            Calculator(numberFour);
        }

        private void numberFive_Click(object sender, EventArgs e)
        {

            Calculator(numberFive);
        }

        private void numberSix_Click(object sender, EventArgs e)
        {

            Calculator(numberSix);
        }
        private void numberSeven_Click(object sender, EventArgs e)
        {

            Calculator(numberSeven);
        }
        private void numberHeight_Click(object sender, EventArgs e)
        {

            Calculator(numberHeight);
        }
        private void numberNine_Click(object sender, EventArgs e)
        {

            Calculator(numberNine);
        }



    }
}
