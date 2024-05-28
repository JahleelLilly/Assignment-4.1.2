namespace Assignment_4._1._2
{
    public partial class Calculator : Form, ICalculator
    {
        double firstNumber = 0;
        string Operation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        public void Add()
        {
            firstNumber = Convert.ToDouble(ResulttextBox.Text);
            ResulttextBox.Text = "0";
            Operation = "+";
        }

        public void Subtract()
        {
            firstNumber = Convert.ToDouble(ResulttextBox.Text);
            ResulttextBox.Text = "0";
            Operation = "-";
        }

        public void Multiply()
        {
            firstNumber = Convert.ToDouble(ResulttextBox.Text);
            ResulttextBox.Text = "0";
            Operation = "*";
        }
        public void Divide()
        {
            firstNumber = Convert.ToDouble(ResulttextBox.Text);
            ResulttextBox.Text = "0";
            Operation = "/";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = "1";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = "2";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = "3";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = "4";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = "5";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = "6";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = "7";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = "8";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = "9";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + "9";
            }
        }

        private void buttonzero_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = "0";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + "0";
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = "0";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + "0";
            }
        }

        private void buttondecimal_Click(object sender, EventArgs e)
        {
            if (ResulttextBox.Text == "0" && ResulttextBox.Text != null)
            {
                ResulttextBox.Text = ".";

            }
            else
            {
                ResulttextBox.Text = ResulttextBox.Text + ".";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case "+":
                    double addNumber = Convert.ToDouble(ResulttextBox.Text);
                    double addTotal = firstNumber + addNumber;
                    ResulttextBox.Text = Convert.ToString(addTotal);
                    break;
                case "-":
                    double minusNumber = Convert.ToDouble(ResulttextBox.Text);
                    double minusTotal = firstNumber - minusNumber;
                    ResulttextBox.Text = Convert.ToString(minusTotal);
                    break;
                case "*":
                    double multiplyNumber = Convert.ToDouble(ResulttextBox.Text);
                    double multiplyTotal = firstNumber - multiplyNumber;
                    ResulttextBox.Text = Convert.ToString(multiplyTotal);
                    break;
                    case "/":
                    double divideNumber = Convert.ToDouble(ResulttextBox.Text);
                    double divideTotal = firstNumber - divideNumber;
                    ResulttextBox.Text += Convert.ToString(divideTotal);
                    break;

            }
        }
    }


}



