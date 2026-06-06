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
            mysteriousPanel = new Panel();
            NameTxtBox = new TextBox();
            NameLbl = new Label();
            WelcomeBtn = new Button();
            mysteriousPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mysteriousPanel
            // 
            mysteriousPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mysteriousPanel.BackColor = SystemColors.ControlDark;
            mysteriousPanel.BorderStyle = BorderStyle.FixedSingle;
            mysteriousPanel.Controls.Add(NameTxtBox);
            mysteriousPanel.Controls.Add(NameLbl);
            mysteriousPanel.ForeColor = Color.White;
            mysteriousPanel.Location = new Point(12, 12);
            mysteriousPanel.Name = "mysteriousPanel";
            mysteriousPanel.Size = new Size(412, 73);
            mysteriousPanel.TabIndex = 0;
            // 
            // NameTxtBox
            // 
            NameTxtBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTxtBox.Location = new Point(3, 37);
            NameTxtBox.Name = "NameTxtBox";
            NameTxtBox.Size = new Size(404, 23);
            NameTxtBox.TabIndex = 1;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.ForeColor = Color.White;
            NameLbl.Location = new Point(3, 10);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(98, 15);
            NameLbl.TabIndex = 0;
            NameLbl.Text = "Введіть своє ім'я";
            NameLbl.Click += label1_Click;
            // 
            // WelcomeBtn
            // 
            WelcomeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            WelcomeBtn.Location = new Point(349, 93);
            WelcomeBtn.Name = "WelcomeBtn";
            WelcomeBtn.Size = new Size(75, 23);
            WelcomeBtn.TabIndex = 1;
            WelcomeBtn.Text = "привітати";
            WelcomeBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 128);
            Controls.Add(WelcomeBtn);
            Controls.Add(mysteriousPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            mysteriousPanel.ResumeLayout(false);
            mysteriousPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mysteriousPanel;
        private Label NameLbl;
        private TextBox NameTxtBox;
        private Button WelcomeBtn;
    }
}
