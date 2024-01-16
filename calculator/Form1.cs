namespace calculator
{
    public partial class Calculator : Form
    {
    
        public int FirstNumber = 0;
        public int SecondNumber= 0;

        public string Operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "1";
            }
            else
            {
                txtResult.Text += "1";
            }

            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "2";
            }
            else
            {
                txtResult.Text += "2";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "3";
            }
            else
            {
                txtResult.Text += "3";
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "4";
            }
            else
            {
                txtResult.Text += "4";
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "5";
            }
            else
            {
                txtResult.Text += "5";
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "6";
            }
            else
            {
                txtResult.Text += "6";
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "7";
            }
            else
            {
                txtResult.Text += "7";
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "8";
            }
            else
            {
                txtResult.Text += "8";
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "9";
            }
            else
            {
                txtResult.Text += "9";
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "0";
            }
            else
            {
                txtResult.Text += "0";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Operation = "+";
            FirstNumber = Convert.ToInt32(txtResult.Text);
            txtResult.Text = "0";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Operation = "-";
            FirstNumber = Convert.ToInt32(txtResult.Text);
            txtResult.Text = "0";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operation = "*";
            FirstNumber = Convert.ToInt32(txtResult.Text);
            txtResult.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operation = "/";
            FirstNumber = Convert.ToInt32(txtResult.Text);
            txtResult.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            try
            {

                int SecondNumber = Convert.ToInt32(txtResult.Text);
                decimal result;
                if (Operation == "+")
                {
                    result = FirstNumber + SecondNumber;

                }
                else if (Operation == "-")
                {
                    result = FirstNumber - SecondNumber;

                }
                else if (Operation == "*")
                {
                    result = FirstNumber * SecondNumber;

                }
                else
                {
                    result = ((decimal)(FirstNumber)) / SecondNumber;

                }

                txtResult.Text = result.ToString();
            }

            catch (Exception ex)
            {
                txtResult.Text = "Cannot Divide by Zero";
            }

        }
    }
}
