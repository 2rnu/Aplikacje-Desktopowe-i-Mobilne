namespace Inf_04_01
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
            labelSurname = new Label();
            labelName = new Label();
            label3 = new Label();
            comboBoxOccupation = new ComboBox();
            groupBoxPasswordGenerator = new GroupBox();
            buttonGeneratePassword = new Button();
            checkBoxSpecialChar = new CheckBox();
            checkBoxNumericNumbers = new CheckBox();
            checkBoxWhatChar = new CheckBox();
            textBoxAmmountOfChar = new TextBox();
            label1 = new Label();
            groupBoxUserInfo = new GroupBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            buttonSubmit = new Button();
            groupBoxPasswordGenerator.SuspendLayout();
            groupBoxUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(15, 94);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(57, 15);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Nazwisko";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(15, 38);
            labelName.Name = "labelName";
            labelName.Size = new Size(30, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Imię";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 156);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Stanowisko";
            // 
            // comboBoxOccupation
            // 
            comboBoxOccupation.BackColor = SystemColors.Window;
            comboBoxOccupation.FormattingEnabled = true;
            comboBoxOccupation.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            comboBoxOccupation.Location = new Point(88, 153);
            comboBoxOccupation.Name = "comboBoxOccupation";
            comboBoxOccupation.Size = new Size(153, 23);
            comboBoxOccupation.TabIndex = 3;
            // 
            // groupBoxPasswordGenerator
            // 
            groupBoxPasswordGenerator.Controls.Add(buttonGeneratePassword);
            groupBoxPasswordGenerator.Controls.Add(checkBoxSpecialChar);
            groupBoxPasswordGenerator.Controls.Add(checkBoxNumericNumbers);
            groupBoxPasswordGenerator.Controls.Add(checkBoxWhatChar);
            groupBoxPasswordGenerator.Controls.Add(textBoxAmmountOfChar);
            groupBoxPasswordGenerator.Controls.Add(label1);
            groupBoxPasswordGenerator.Location = new Point(637, 40);
            groupBoxPasswordGenerator.Name = "groupBoxPasswordGenerator";
            groupBoxPasswordGenerator.Size = new Size(363, 357);
            groupBoxPasswordGenerator.TabIndex = 5;
            groupBoxPasswordGenerator.TabStop = false;
            groupBoxPasswordGenerator.Text = "Generowanie hasła";
            // 
            // buttonGeneratePassword
            // 
            buttonGeneratePassword.BackColor = Color.SteelBlue;
            buttonGeneratePassword.Location = new Point(117, 313);
            buttonGeneratePassword.Name = "buttonGeneratePassword";
            buttonGeneratePassword.Size = new Size(100, 23);
            buttonGeneratePassword.TabIndex = 5;
            buttonGeneratePassword.Text = "Generuj hasło";
            buttonGeneratePassword.UseVisualStyleBackColor = false;
            buttonGeneratePassword.Click += buttonGeneratePassword_Click;
            // 
            // checkBoxSpecialChar
            // 
            checkBoxSpecialChar.AutoSize = true;
            checkBoxSpecialChar.Location = new Point(29, 169);
            checkBoxSpecialChar.Name = "checkBoxSpecialChar";
            checkBoxSpecialChar.Size = new Size(107, 19);
            checkBoxSpecialChar.TabIndex = 4;
            checkBoxSpecialChar.Text = "Znaki specjalne";
            checkBoxSpecialChar.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumericNumbers
            // 
            checkBoxNumericNumbers.AutoSize = true;
            checkBoxNumericNumbers.Location = new Point(29, 130);
            checkBoxNumericNumbers.Name = "checkBoxNumericNumbers";
            checkBoxNumericNumbers.Size = new Size(54, 19);
            checkBoxNumericNumbers.TabIndex = 3;
            checkBoxNumericNumbers.Text = "Cyfry";
            checkBoxNumericNumbers.UseVisualStyleBackColor = true;
            // 
            // checkBoxWhatChar
            // 
            checkBoxWhatChar.AutoSize = true;
            checkBoxWhatChar.Location = new Point(29, 90);
            checkBoxWhatChar.Name = "checkBoxWhatChar";
            checkBoxWhatChar.Size = new Size(126, 19);
            checkBoxWhatChar.TabIndex = 2;
            checkBoxWhatChar.Text = "Małe i wielkie litery";
            checkBoxWhatChar.UseVisualStyleBackColor = true;
            // 
            // textBoxAmmountOfChar
            // 
            textBoxAmmountOfChar.Location = new Point(102, 35);
            textBoxAmmountOfChar.Name = "textBoxAmmountOfChar";
            textBoxAmmountOfChar.Size = new Size(100, 23);
            textBoxAmmountOfChar.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Ile znaków?";
            // 
            // groupBoxUserInfo
            // 
            groupBoxUserInfo.Controls.Add(textBoxSurname);
            groupBoxUserInfo.Controls.Add(textBoxName);
            groupBoxUserInfo.Controls.Add(comboBoxOccupation);
            groupBoxUserInfo.Controls.Add(labelName);
            groupBoxUserInfo.Controls.Add(labelSurname);
            groupBoxUserInfo.Controls.Add(label3);
            groupBoxUserInfo.Location = new Point(73, 40);
            groupBoxUserInfo.Name = "groupBoxUserInfo";
            groupBoxUserInfo.Size = new Size(353, 357);
            groupBoxUserInfo.TabIndex = 6;
            groupBoxUserInfo.TabStop = false;
            groupBoxUserInfo.Text = "Dane pracownika";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(88, 91);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(100, 23);
            textBoxSurname.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(88, 35);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.SteelBlue;
            buttonSubmit.Location = new Point(388, 458);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(283, 23);
            buttonSubmit.TabIndex = 7;
            buttonSubmit.Text = "Zatwierdź";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1108, 523);
            Controls.Add(buttonSubmit);
            Controls.Add(groupBoxUserInfo);
            Controls.Add(groupBoxPasswordGenerator);
            Name = "Form1";
            Text = "Form1";
            groupBoxPasswordGenerator.ResumeLayout(false);
            groupBoxPasswordGenerator.PerformLayout();
            groupBoxUserInfo.ResumeLayout(false);
            groupBoxUserInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelSurname;
        private Label labelName;
        private Label label3;
        private ComboBox comboBoxOccupation;
        private GroupBox groupBoxPasswordGenerator;
        private Label label1;
        private GroupBox groupBoxUserInfo;
        private Button buttonGeneratePassword;
        private CheckBox checkBoxSpecialChar;
        private CheckBox checkBoxNumericNumbers;
        private CheckBox checkBoxWhatChar;
        private TextBox textBoxAmmountOfChar;
        private Button buttonSubmit;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
    }
}