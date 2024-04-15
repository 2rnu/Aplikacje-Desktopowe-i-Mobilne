namespace egz
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
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordRepeatTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            infoLabel = new Label();
            acceptionButton = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSeaGreen;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(-96, -5);
            label1.Name = "label1";
            label1.Padding = new Padding(100, 10, 200, 10);
            label1.Size = new Size(426, 41);
            label1.TabIndex = 0;
            label1.Text = "Rejestruj konto";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 47);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Podaj e-mail";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(24, 75);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(232, 23);
            emailTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(24, 137);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(232, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // passwordRepeatTextBox
            // 
            passwordRepeatTextBox.Location = new Point(24, 207);
            passwordRepeatTextBox.Name = "passwordRepeatTextBox";
            passwordRepeatTextBox.Size = new Size(232, 23);
            passwordRepeatTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 110);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "Podaj hasło";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 179);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 6;
            label4.Text = "Powtórz hasło";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.ForeColor = SystemColors.ControlDark;
            infoLabel.Location = new Point(12, 378);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(0, 15);
            infoLabel.TabIndex = 7;
            // 
            // acceptionButton
            // 
            acceptionButton.Location = new Point(32, 297);
            acceptionButton.Name = "acceptionButton";
            acceptionButton.Size = new Size(75, 23);
            acceptionButton.TabIndex = 8;
            acceptionButton.Text = "Zatwierdź";
            acceptionButton.UseVisualStyleBackColor = true;
            acceptionButton.Click += acceptionButton_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 450);
            Controls.Add(acceptionButton);
            Controls.Add(infoLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passwordRepeatTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private TextBox passwordRepeatTextBox;
        private Label label3;
        private Label label4;
        private Label infoLabel;
        private Button acceptionButton;
        private FileSystemWatcher fileSystemWatcher1;
    }
}