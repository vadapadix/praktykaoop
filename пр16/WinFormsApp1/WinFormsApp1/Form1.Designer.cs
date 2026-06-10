namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlDisplay = new Panel();
            lblDisplay = new Label();
            pnlState = new FlowLayoutPanel();
            radioOn = new RadioButton();
            radioOff = new RadioButton();
            tlpButtonsPanel = new TableLayoutPanel();
            btnCE = new Button();
            btnBackspace = new Button();
            btnPercent = new Button();
            btnDivide = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSubtract = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btn0 = new Button();
            btnDecimal = new Button();
            btnEquals = new Button();
            pnlDisplay.SuspendLayout();
            pnlState.SuspendLayout();
            tlpButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = SystemColors.Control;
            pnlDisplay.Controls.Add(lblDisplay);
            pnlDisplay.Dock = DockStyle.Top;
            pnlDisplay.Location = new Point(0, 0);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Padding = new Padding(5);
            pnlDisplay.Size = new Size(384, 80);
            pnlDisplay.TabIndex = 0;
            // 
            // lblDisplay
            // 
            lblDisplay.BackColor = Color.White;
            lblDisplay.Dock = DockStyle.Fill;
            lblDisplay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplay.Location = new Point(5, 5);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(374, 70);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "0";
            lblDisplay.TextAlign = ContentAlignment.MiddleRight;
            lblDisplay.TextChanged += lblDisplay_TextChanged;
            // 
            // pnlState
            // 
            pnlState.Controls.Add(radioOn);
            pnlState.Controls.Add(radioOff);
            pnlState.Dock = DockStyle.Top;
            pnlState.Location = new Point(0, 80);
            pnlState.Name = "pnlState";
            pnlState.Padding = new Padding(8, 6, 8, 4);
            pnlState.Size = new Size(384, 42);
            pnlState.TabIndex = 1;
            // 
            // radioOn
            // 
            radioOn.AutoSize = true;
            radioOn.Checked = true;
            radioOn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioOn.ForeColor = Color.FromArgb(0, 192, 0);
            radioOn.Location = new Point(11, 9);
            radioOn.Name = "radioOn";
            radioOn.Size = new Size(52, 25);
            radioOn.TabIndex = 0;
            radioOn.TabStop = true;
            radioOn.Text = "ON";
            radioOn.UseVisualStyleBackColor = true;
            radioOn.CheckedChanged += radioOn_CheckedChanged;
            // 
            // radioOff
            // 
            radioOff.AutoSize = true;
            radioOff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioOff.ForeColor = Color.Red;
            radioOff.Location = new Point(69, 9);
            radioOff.Name = "radioOff";
            radioOff.Size = new Size(56, 25);
            radioOff.TabIndex = 1;
            radioOff.Text = "OFF";
            radioOff.UseVisualStyleBackColor = true;
            radioOff.CheckedChanged += radioOff_CheckedChanged;
            // 
            // tlpButtonsPanel
            // 
            tlpButtonsPanel.ColumnCount = 4;
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpButtonsPanel.Controls.Add(btnCE, 0, 0);
            tlpButtonsPanel.Controls.Add(btnBackspace, 1, 0);
            tlpButtonsPanel.Controls.Add(btnPercent, 2, 0);
            tlpButtonsPanel.Controls.Add(btnDivide, 3, 0);
            tlpButtonsPanel.Controls.Add(btn7, 0, 1);
            tlpButtonsPanel.Controls.Add(btn8, 1, 1);
            tlpButtonsPanel.Controls.Add(btn9, 2, 1);
            tlpButtonsPanel.Controls.Add(btnMultiply, 3, 1);
            tlpButtonsPanel.Controls.Add(btn4, 0, 2);
            tlpButtonsPanel.Controls.Add(btn5, 1, 2);
            tlpButtonsPanel.Controls.Add(btn6, 2, 2);
            tlpButtonsPanel.Controls.Add(btnSubtract, 3, 2);
            tlpButtonsPanel.Controls.Add(btn1, 0, 3);
            tlpButtonsPanel.Controls.Add(btn2, 1, 3);
            tlpButtonsPanel.Controls.Add(btn3, 2, 3);
            tlpButtonsPanel.Controls.Add(btnAdd, 3, 3);
            tlpButtonsPanel.Controls.Add(btn0, 0, 4);
            tlpButtonsPanel.Controls.Add(btnDecimal, 1, 4);
            tlpButtonsPanel.Controls.Add(btnEquals, 2, 4);
            tlpButtonsPanel.Dock = DockStyle.Fill;
            tlpButtonsPanel.Location = new Point(0, 122);
            tlpButtonsPanel.Name = "tlpButtonsPanel";
            tlpButtonsPanel.RowCount = 5;
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpButtonsPanel.Size = new Size(384, 339);
            tlpButtonsPanel.TabIndex = 2;
            // 
            // btnCE
            // 
            btnCE.Dock = DockStyle.Fill;
            btnCE.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCE.ForeColor = Color.OrangeRed;
            btnCE.Location = new Point(2, 2);
            btnCE.Margin = new Padding(2);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(92, 63);
            btnCE.TabIndex = 0;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackspace.Location = new Point(98, 2);
            btnBackspace.Margin = new Padding(2);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(92, 63);
            btnBackspace.TabIndex = 1;
            btnBackspace.Text = "←";
            btnBackspace.UseVisualStyleBackColor = true;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnPercent
            // 
            btnPercent.Dock = DockStyle.Fill;
            btnPercent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPercent.Location = new Point(194, 2);
            btnPercent.Margin = new Padding(2);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(92, 63);
            btnPercent.TabIndex = 2;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnDivide
            // 
            btnDivide.Dock = DockStyle.Fill;
            btnDivide.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.Location = new Point(290, 2);
            btnDivide.Margin = new Padding(2);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(92, 63);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(2, 69);
            btn7.Margin = new Padding(2);
            btn7.Name = "btn7";
            btn7.Size = new Size(92, 63);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(98, 69);
            btn8.Margin = new Padding(2);
            btn8.Name = "btn8";
            btn8.Size = new Size(92, 63);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(194, 69);
            btn9.Margin = new Padding(2);
            btn9.Name = "btn9";
            btn9.Size = new Size(92, 63);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Dock = DockStyle.Fill;
            btnMultiply.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiply.Location = new Point(290, 69);
            btnMultiply.Margin = new Padding(2);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(92, 63);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(2, 136);
            btn4.Margin = new Padding(2);
            btn4.Name = "btn4";
            btn4.Size = new Size(92, 63);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(98, 136);
            btn5.Margin = new Padding(2);
            btn5.Name = "btn5";
            btn5.Size = new Size(92, 63);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(194, 136);
            btn6.Margin = new Padding(2);
            btn6.Name = "btn6";
            btn6.Size = new Size(92, 63);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Dock = DockStyle.Fill;
            btnSubtract.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubtract.Location = new Point(290, 136);
            btnSubtract.Margin = new Padding(2);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(92, 63);
            btnSubtract.TabIndex = 11;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(2, 203);
            btn1.Margin = new Padding(2);
            btn1.Name = "btn1";
            btn1.Size = new Size(92, 63);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(98, 203);
            btn2.Margin = new Padding(2);
            btn2.Name = "btn2";
            btn2.Size = new Size(92, 63);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(194, 203);
            btn3.Margin = new Padding(2);
            btn3.Name = "btn3";
            btn3.Size = new Size(92, 63);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(290, 203);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 63);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(2, 270);
            btn0.Margin = new Padding(2);
            btn0.Name = "btn0";
            btn0.Size = new Size(92, 67);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Dock = DockStyle.Fill;
            btnDecimal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecimal.Location = new Point(98, 270);
            btnDecimal.Margin = new Padding(2);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(92, 67);
            btnDecimal.TabIndex = 17;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnEquals
            // 
            tlpButtonsPanel.SetColumnSpan(btnEquals, 2);
            btnEquals.Dock = DockStyle.Fill;
            btnEquals.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEquals.Location = new Point(194, 270);
            btnEquals.Margin = new Padding(2);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(188, 67);
            btnEquals.TabIndex = 18;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(tlpButtonsPanel);
            Controls.Add(pnlState);
            Controls.Add(pnlDisplay);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(320, 420);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор";
            Load += Form1_Load;
            pnlDisplay.ResumeLayout(false);
            pnlState.ResumeLayout(false);
            pnlState.PerformLayout();
            tlpButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDisplay;
        private Label lblDisplay;
        private FlowLayoutPanel pnlState;
        private RadioButton radioOn;
        private RadioButton radioOff;
        private TableLayoutPanel tlpButtonsPanel;
        private Button btnCE;
        private Button btnBackspace;
        private Button btnPercent;
        private Button btnDivide;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubtract;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
        private Button btn0;
        private Button btnDecimal;
        private Button btnEquals;
    }
}
