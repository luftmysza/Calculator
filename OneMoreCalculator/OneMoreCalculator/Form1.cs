using System.Diagnostics.Contracts;

namespace OneMoreCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string input = "";
        int previousOperationResult = 0;
        bool operationCompleted = false;

        private void one_Click(object sender, EventArgs e)
        {
            if (operationCompleted)
            {
                input = "1";
                Input.Text = input;
            }
            input += "1";
            Input.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (operationCompleted)
            {
                input = "2";
                Input.Text = input;
            }
            input += "2";
            Input.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (operationCompleted)
            {
                input = "3";
                Input.Text = input;
            }
            input += "3";
            Input.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (operationCompleted)
            {
                input = "4";
                Input.Text = input;
            }
            input += "4";
            Input.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (operationCompleted)
            {
                input = "5";
                Input.Text = input;
            }
            input += "5";
            Input.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (operationCompleted)
            {
                input = "6";
                Input.Text = input;
            }
            input += "6";
            Input.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (operationCompleted)
            {
                input = "7";
                Input.Text = input;
            }
            input += "7";
            Input.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (operationCompleted)
            {
                input = "8";
                Input.Text = input;
                //operationCompleted = false;
            }
            input += "8";
            Input.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (operationCompleted)
            {
                input = "9";
                Input.Text = input;
                //operationCompleted = false;
            }
            input += "9";
            Input.Text += "9";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (operationCompleted)
            {
                input = "0";
                Input.Text = input;
                //operationCompleted = false;
            }
            input += "0";
            Input.Text += "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            //if (operationCompleted)
            //{
            //    input = "";
            //    Input.Text = input;
            //    operationCompleted = false;
            //}
            if (input.Length > 0)
            {
                input += " + ";
                Input.Text += " + ";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (operationCompleted)
            //{
            //    input = "";
            //    Input.Text = input;
            //    operationCompleted = false;
            //}
            if (input.Length > 0)
            {
                input += " - ";
                Input.Text += " - ";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            //if (operationCompleted) 
            //{
            //    input = "";
            //    Input.Text = input;
            //    operationCompleted = false;
            //}
            if (input.Length > 0)
            {
                input += " * ";
                Input.Text += " * ";
            }
        }

        private void devide_Click(object sender, EventArgs e)
        {
            //if (operationCompleted)
            //{
                //input = "";
                //Input.Text = input;
                //operationCompleted = false;
            //}
            if (input.Length > 0)
            {
                input += " / ";
                Input.Text += " / ";
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("");
        }

        private void equals_Click(object sender, EventArgs e)
        {
            string[] inputBreakdown = input.Split(" ");
            int var1, var2;

            if (!operationCompleted) {
                int.TryParse(inputBreakdown[0], out var1);
                int.TryParse(inputBreakdown[2], out var2);
                Caclculate(var1, var2);
            }
            if (operationCompleted)
            {
                var1 = previousOperationResult;
                int.TryParse(inputBreakdown[2], out var2);
                Caclculate(previousOperationResult, var2);
            }

            void Caclculate(int var1, int var2)
            {
                checked
                {
                    int result = 0;
                    switch (inputBreakdown[1])
                    {
                        case "+":
                            result = var1 + var2;
                            break;
                        case "-":
                            result = var1 - var2;
                            break;
                        case "*":
                            result = var1 * var2;
                            break;
                        case "/":
                            result = var1 / var2;
                            break;
                    }
                    Input.Text = result.ToString();
                    previousOperationResult = result;
                }
                operationCompleted = true;
                
            }
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
           // MessageBox.Show(e.KeyCode.ToString());
        }
    }
}
