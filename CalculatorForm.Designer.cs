namespace BT4_3_Calculator
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtDisplay  = new System.Windows.Forms.TextBox();
            btn0 = new System.Windows.Forms.Button(); btn1 = new System.Windows.Forms.Button();
            btn2 = new System.Windows.Forms.Button(); btn3 = new System.Windows.Forms.Button();
            btn4 = new System.Windows.Forms.Button(); btn5 = new System.Windows.Forms.Button();
            btn6 = new System.Windows.Forms.Button(); btn7 = new System.Windows.Forms.Button();
            btn8 = new System.Windows.Forms.Button(); btn9 = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button(); btnSub = new System.Windows.Forms.Button();
            btnMul = new System.Windows.Forms.Button(); btnDiv = new System.Windows.Forms.Button();
            btnEquals    = new System.Windows.Forms.Button();
            btnClear     = new System.Windows.Forms.Button();
            btnBackspace = new System.Windows.Forms.Button();
            btnDot       = new System.Windows.Forms.Button();
            SuspendLayout();

            // Form
            Text          = "Máy Tính";
            Size          = new System.Drawing.Size(320, 420);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox   = false;
            BackColor     = System.Drawing.Color.FromArgb(45, 45, 48);

            // txtDisplay
            txtDisplay.Location  = new System.Drawing.Point(15, 15);
            txtDisplay.Size      = new System.Drawing.Size(280, 45);
            txtDisplay.Text      = "0";
            txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtDisplay.Font      = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold);
            txtDisplay.ReadOnly  = true;
            txtDisplay.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtDisplay.ForeColor = System.Drawing.Color.White;

            // Helper để tạo button
            System.Drawing.Size btnSize = new System.Drawing.Size(60, 55);
            System.Drawing.Color numColor = System.Drawing.Color.FromArgb(70, 70, 75);
            System.Drawing.Color opColor  = System.Drawing.Color.FromArgb(0, 120, 215);
            System.Drawing.Color spColor  = System.Drawing.Color.FromArgb(150, 60, 60);

            void SetupBtn(System.Windows.Forms.Button b, string text, int x, int y,
                          System.Drawing.Color? bg = null, EventHandler? handler = null)
            {
                b.Text      = text;
                b.Location  = new System.Drawing.Point(x, y);
                b.Size      = btnSize;
                b.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
                b.BackColor = bg ?? numColor;
                b.ForeColor = System.Drawing.Color.White;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 95);
                if (handler != null) b.Click += handler;
            }

            // Số 7 8 9
            SetupBtn(btn7, "7", 15, 75, null, NumberButton_Click);
            SetupBtn(btn8, "8", 85, 75, null, NumberButton_Click);
            SetupBtn(btn9, "9", 155, 75, null, NumberButton_Click);
            SetupBtn(btnDiv, "/", 225, 75, opColor, OperatorButton_Click);

            // Số 4 5 6
            SetupBtn(btn4, "4", 15, 140, null, NumberButton_Click);
            SetupBtn(btn5, "5", 85, 140, null, NumberButton_Click);
            SetupBtn(btn6, "6", 155, 140, null, NumberButton_Click);
            SetupBtn(btnMul, "*", 225, 140, opColor, OperatorButton_Click);

            // Số 1 2 3
            SetupBtn(btn1, "1", 15, 205, null, NumberButton_Click);
            SetupBtn(btn2, "2", 85, 205, null, NumberButton_Click);
            SetupBtn(btn3, "3", 155, 205, null, NumberButton_Click);
            SetupBtn(btnSub, "-", 225, 205, opColor, OperatorButton_Click);

            // Số 0, dấu chấm, =, +
            SetupBtn(btn0, "0", 15, 270, null, NumberButton_Click);
            SetupBtn(btnDot, ".", 85, 270, null, btnDot_Click);
            SetupBtn(btnEquals, "=", 155, 270, System.Drawing.Color.FromArgb(0, 150, 100), btnEquals_Click);
            SetupBtn(btnAdd, "+", 225, 270, opColor, OperatorButton_Click);

            // Hàng dưới: C, CE
            btnClear.Text      = "C";
            btnClear.Location  = new System.Drawing.Point(15, 335);
            btnClear.Size      = new System.Drawing.Size(130, 45);
            btnClear.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            btnClear.BackColor = spColor;
            btnClear.ForeColor = System.Drawing.Color.White;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.Click    += btnClear_Click;

            btnBackspace.Text      = "⌫";
            btnBackspace.Location  = new System.Drawing.Point(155, 335);
            btnBackspace.Size      = new System.Drawing.Size(130, 45);
            btnBackspace.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            btnBackspace.BackColor = System.Drawing.Color.FromArgb(90, 60, 120);
            btnBackspace.ForeColor = System.Drawing.Color.White;
            btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBackspace.Click    += btnBackspace_Click;

            Controls.AddRange(new System.Windows.Forms.Control[] {
                txtDisplay,
                btn7, btn8, btn9, btnDiv,
                btn4, btn5, btn6, btnMul,
                btn1, btn2, btn3, btnSub,
                btn0, btnDot, btnEquals, btnAdd,
                btnClear, btnBackspace
            });

            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox  txtDisplay;
        private System.Windows.Forms.Button   btn0, btn1, btn2, btn3, btn4;
        private System.Windows.Forms.Button   btn5, btn6, btn7, btn8, btn9;
        private System.Windows.Forms.Button   btnAdd, btnSub, btnMul, btnDiv;
        private System.Windows.Forms.Button   btnEquals, btnClear, btnBackspace, btnDot;
    }
}
