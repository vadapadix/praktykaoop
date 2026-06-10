using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private string operation = "";
        private bool isOperationSelected;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                NumberClick((e.KeyCode - Keys.D0).ToString());
                e.Handled = true;
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                NumberClick((e.KeyCode - Keys.NumPad0).ToString());
                e.Handled = true;
            }
        }

        private void NumberClick(string number) 
        {
            if (lblDisplay.Text == "0" || isOperationSelected)
            {
                lblDisplay.Text = "";
                isOperationSelected = false;
            }

            lblDisplay.Text += number;
        }

        private void SetOperation(string op)
        {
            firstNumber = ParseDisplayNumber();
            operation = op;
            isOperationSelected = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondNumber = ParseDisplayNumber();
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
                    MessageBox.Show("\u0414\u0456\u043b\u0435\u043d\u043d\u044f \u043d\u0430 \u043d\u0443\u043b\u044c \u0437\u0430\u0431\u043e\u0440\u043e\u043d\u0435\u043d\u043e");
                    return;
                }

                result = firstNumber / secondNumber;
            }

            lblDisplay.Text = FormatDisplayNumber(result);
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
            double number = ParseDisplayNumber();
            lblDisplay.Text = FormatDisplayNumber(number / 100);
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
            ClearCalculator();
        }

        private void ClearCalculator()
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

        private double ParseDisplayNumber()
        {
            return double.Parse(lblDisplay.Text, CultureInfo.InvariantCulture);
        }

        private static string FormatDisplayNumber(double number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}
