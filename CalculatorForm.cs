using System;
using System.Windows.Forms;

namespace BT4_3_Calculator
{
    public partial class CalculatorForm : Form
    {
        private double firstNumber = 0;
        private string currentOperator = "";
        private bool isNewInput = true;   // Cờ đánh dấu bắt đầu số mới

        public CalculatorForm()
        {
            InitializeComponent();
        }

        // Dùng CHUNG cho 10 nút bấm số (btn0 → btn9)
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;   // Ép kiểu để lấy Text của nút

            if (isNewInput)
            {
                txtDisplay.Text = btn.Text;
                isNewInput = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        // Nút dấu thập phân (.)
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }

        // Các nút phép toán: +, -, *, /
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNumber     = double.Parse(txtDisplay.Text);
            currentOperator = btn.Text;
            isNewInput      = true;   // Lần gõ tiếp theo là số mới
        }

        // Nút = (tính kết quả)
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentOperator)) return;

            double secondNumber = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+": result = firstNumber + secondNumber; break;
                case "-": result = firstNumber - secondNumber; break;
                case "*": result = firstNumber * secondNumber; break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
            }

            txtDisplay.Text = result.ToString();
            currentOperator = "";
            isNewInput      = true;
        }

        // Nút C (Clear)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber     = 0;
            currentOperator = "";
            isNewInput      = true;
        }

        // Nút CE (xóa ký tự cuối)
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text[..^1];
            else
                txtDisplay.Text = "0";
        }
    }
}
