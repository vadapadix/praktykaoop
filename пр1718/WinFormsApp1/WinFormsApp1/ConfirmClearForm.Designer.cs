namespace WinFormsApp1
{
    partial class ConfirmClearForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelQuestion = new Label();
            buttonYes = new Button();
            buttonNo = new Button();
            SuspendLayout();
            // 
            // labelQuestion
            // 
            labelQuestion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuestion.Location = new Point(18, 18);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(344, 56);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "Ви дійсно хочете очистити вміст калькулятора?";
            labelQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonYes
            // 
            buttonYes.DialogResult = DialogResult.Yes;
            buttonYes.Location = new Point(100, 88);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(82, 32);
            buttonYes.TabIndex = 1;
            buttonYes.Text = "Так";
            buttonYes.UseVisualStyleBackColor = true;
            buttonYes.Click += buttonYes_Click;
            // 
            // buttonNo
            // 
            buttonNo.DialogResult = DialogResult.No;
            buttonNo.Location = new Point(198, 88);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(82, 32);
            buttonNo.TabIndex = 2;
            buttonNo.Text = "Ні";
            buttonNo.UseVisualStyleBackColor = true;
            buttonNo.Click += buttonNo_Click;
            // 
            // ConfirmClearForm
            // 
            AcceptButton = buttonYes;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonNo;
            ClientSize = new Size(380, 142);
            Controls.Add(buttonNo);
            Controls.Add(buttonYes);
            Controls.Add(labelQuestion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmClearForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Підтвердження";
            ResumeLayout(false);
        }

        #endregion

        private Label labelQuestion;
        private Button buttonYes;
        private Button buttonNo;
    }
}
