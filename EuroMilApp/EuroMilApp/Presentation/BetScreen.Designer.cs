namespace EuroMilApp
{
    partial class BetScreen
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
            submitButton = new Button();
            accountCombobox = new ComboBox();
            label1 = new Label();
            accountGroupBox = new GroupBox();
            groupBox2 = new GroupBox();
            starsGroupBox = new GroupBox();
            star1Combobox = new ComboBox();
            star2Combobox = new ComboBox();
            numbersGroupBox = new GroupBox();
            num5Combobox = new ComboBox();
            num1Combobox = new ComboBox();
            num4Combobox = new ComboBox();
            num2Combobox = new ComboBox();
            num3Combobox = new ComboBox();
            accountGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            starsGroupBox.SuspendLayout();
            numbersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Location = new Point(12, 260);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(245, 23);
            submitButton.TabIndex = 2;
            submitButton.Text = "Apostar";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // accountCombobox
            // 
            accountCombobox.AllowDrop = true;
            accountCombobox.AutoCompleteCustomSource.AddRange(new string[] { "1234567890123456" });
            accountCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            accountCombobox.FormattingEnabled = true;
            accountCombobox.Items.AddRange(new object[] { "12345678" });
            accountCombobox.Location = new Point(6, 71);
            accountCombobox.Name = "accountCombobox";
            accountCombobox.Size = new Size(232, 23);
            accountCombobox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Conta";
            // 
            // accountGroupBox
            // 
            accountGroupBox.Controls.Add(accountCombobox);
            accountGroupBox.Controls.Add(label1);
            accountGroupBox.Location = new Point(13, 12);
            accountGroupBox.Name = "accountGroupBox";
            accountGroupBox.Size = new Size(244, 100);
            accountGroupBox.TabIndex = 0;
            accountGroupBox.TabStop = false;
            accountGroupBox.Text = "Seleção de Conta";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(starsGroupBox);
            groupBox2.Controls.Add(numbersGroupBox);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(245, 136);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chave da Aposta";
            // 
            // starsGroupBox
            // 
            starsGroupBox.Controls.Add(star1Combobox);
            starsGroupBox.Controls.Add(star2Combobox);
            starsGroupBox.Location = new Point(6, 77);
            starsGroupBox.Name = "starsGroupBox";
            starsGroupBox.Size = new Size(233, 49);
            starsGroupBox.TabIndex = 1;
            starsGroupBox.TabStop = false;
            starsGroupBox.Text = "Estrelas da Sorte";
            // 
            // star1Combobox
            // 
            star1Combobox.FormattingEnabled = true;
            star1Combobox.Location = new Point(6, 20);
            star1Combobox.Name = "star1Combobox";
            star1Combobox.Size = new Size(39, 23);
            star1Combobox.TabIndex = 0;
            // 
            // star2Combobox
            // 
            star2Combobox.FormattingEnabled = true;
            star2Combobox.Location = new Point(51, 20);
            star2Combobox.Name = "star2Combobox";
            star2Combobox.Size = new Size(39, 23);
            star2Combobox.TabIndex = 1;
            // 
            // numbersGroupBox
            // 
            numbersGroupBox.Controls.Add(num5Combobox);
            numbersGroupBox.Controls.Add(num1Combobox);
            numbersGroupBox.Controls.Add(num4Combobox);
            numbersGroupBox.Controls.Add(num2Combobox);
            numbersGroupBox.Controls.Add(num3Combobox);
            numbersGroupBox.Location = new Point(6, 22);
            numbersGroupBox.Name = "numbersGroupBox";
            numbersGroupBox.Size = new Size(233, 49);
            numbersGroupBox.TabIndex = 0;
            numbersGroupBox.TabStop = false;
            numbersGroupBox.Text = "Números";
            // 
            // num5Combobox
            // 
            num5Combobox.FormattingEnabled = true;
            num5Combobox.Location = new Point(186, 20);
            num5Combobox.Name = "num5Combobox";
            num5Combobox.Size = new Size(39, 23);
            num5Combobox.TabIndex = 4;
            // 
            // num1Combobox
            // 
            num1Combobox.FormattingEnabled = true;
            num1Combobox.Location = new Point(6, 20);
            num1Combobox.Name = "num1Combobox";
            num1Combobox.Size = new Size(39, 23);
            num1Combobox.TabIndex = 0;
            // 
            // num4Combobox
            // 
            num4Combobox.FormattingEnabled = true;
            num4Combobox.Location = new Point(141, 20);
            num4Combobox.Name = "num4Combobox";
            num4Combobox.Size = new Size(39, 23);
            num4Combobox.TabIndex = 3;
            // 
            // num2Combobox
            // 
            num2Combobox.FormattingEnabled = true;
            num2Combobox.Location = new Point(51, 20);
            num2Combobox.Name = "num2Combobox";
            num2Combobox.Size = new Size(39, 23);
            num2Combobox.TabIndex = 1;
            // 
            // num3Combobox
            // 
            num3Combobox.FormattingEnabled = true;
            num3Combobox.Location = new Point(96, 20);
            num3Combobox.Name = "num3Combobox";
            num3Combobox.Size = new Size(39, 23);
            num3Combobox.TabIndex = 2;
            // 
            // BetScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(265, 294);
            Controls.Add(groupBox2);
            Controls.Add(accountGroupBox);
            Controls.Add(submitButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BetScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Euro Milhões";
            accountGroupBox.ResumeLayout(false);
            accountGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            starsGroupBox.ResumeLayout(false);
            numbersGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button submitButton;
        private ComboBox accountCombobox;
        private Label label1;
        private GroupBox accountGroupBox;
        private GroupBox groupBox2;
        private GroupBox starsGroupBox;
        private ComboBox star1Combobox;
        private ComboBox star2Combobox;
        private GroupBox numbersGroupBox;
        private ComboBox num5Combobox;
        private ComboBox num1Combobox;
        private ComboBox num4Combobox;
        private ComboBox num2Combobox;
        private ComboBox num3Combobox;
    }
}
