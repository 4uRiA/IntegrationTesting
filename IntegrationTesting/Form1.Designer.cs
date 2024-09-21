namespace IntegrationTesting
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
            label1 = new Label();
            label2 = new Label();
            textBoxInput = new TextBox();
            buttonInput = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(526, 39);
            label1.Name = "label1";
            label1.Size = new Size(277, 36);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(243, 99);
            label2.Name = "label2";
            label2.Size = new Size(845, 108);
            label2.TabIndex = 1;
            label2.Text = "Данное приложение создано для \r\nнахождения и подсчета\r\nстепеней цифры \"5\" в вашей последовательности из 5 чисел!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(453, 235);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "Введите число последовательности в диапозоне от 1 до 999 и нажмите на кнопку \"Ввод\"";
            textBoxInput.Size = new Size(423, 23);
            textBoxInput.TabIndex = 2;
            // 
            // buttonInput
            // 
            buttonInput.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonInput.Location = new Point(588, 292);
            buttonInput.Name = "buttonInput";
            buttonInput.Size = new Size(141, 31);
            buttonInput.TabIndex = 5;
            buttonInput.Text = "Ввод";
            buttonInput.UseVisualStyleBackColor = true;
            buttonInput.Click += buttonRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1330, 646);
            Controls.Add(buttonInput);
            Controls.Add(textBoxInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Главное меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox textBoxInput;
        public Button buttonInput;
    }
}
