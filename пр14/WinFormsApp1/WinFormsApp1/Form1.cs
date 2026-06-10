namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double firstNumber;
        string operation;
        bool isOperationSelected;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberClick(string number)
        {
            if (lblDisplay.Text == "0" || isOperationSelected == true)
            {
                lblDisplay.Text = "";
                isOperationSelected = false;
            }

            lblDisplay.Text += number;
        }

        private void SetOperation(string op)
        {
            firstNumber = double.Parse(lblDisplay.Text);
            operation = op;
            isOperationSelected = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(lblDisplay.Text);
            double result = 0;

            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("Ділення на нуль заборонено");
                    return;
                }

                result = firstNumber / secondNumber;
            }

            lblDisplay.Text = result.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetOperation("+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            SetOperation("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            SetOperation("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            SetOperation("/");
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double number = double.Parse(lblDisplay.Text);
            lblDisplay.Text = (number / 100).ToString();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length > 1)
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
            }
            else
            {
                lblDisplay.Text = "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
            isOperationSelected = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NumberClick("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NumberClick("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NumberClick("9");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NumberClick("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NumberClick("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NumberClick("6");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NumberClick("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NumberClick("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NumberClick("3");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            NumberClick("0");
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!lblDisplay.Text.Contains("."))
            {
                NumberClick(".");
            }
        }
    }
}