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
            groupBox1 = new GroupBox();
            radioButtonPaczka = new RadioButton();
            radioButtonList = new RadioButton();
            radioButtonPocztowka = new RadioButton();
            groupBox2 = new GroupBox();
            textBoxCity = new TextBox();
            textBoxPostalCode = new TextBox();
            labelCity = new Label();
            labelPostalCode = new Label();
            textBoxHouse = new TextBox();
            labelHouse = new Label();
            buttonCheckPrice = new Button();
            pictureBox1 = new PictureBox();
            buttonSubmit = new Button();
            labelPrice = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonPaczka);
            groupBox1.Controls.Add(radioButtonList);
            groupBox1.Controls.Add(radioButtonPocztowka);
            groupBox1.Location = new Point(104, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rodzaj przesyłki";
            // 
            // radioButtonPaczka
            // 
            radioButtonPaczka.AutoSize = true;
            radioButtonPaczka.Location = new Point(6, 72);
            radioButtonPaczka.Name = "radioButtonPaczka";
            radioButtonPaczka.Size = new Size(61, 19);
            radioButtonPaczka.TabIndex = 2;
            radioButtonPaczka.TabStop = true;
            radioButtonPaczka.Text = "Paczka";
            radioButtonPaczka.UseVisualStyleBackColor = true;
            // 
            // radioButtonList
            // 
            radioButtonList.AutoSize = true;
            radioButtonList.Location = new Point(6, 47);
            radioButtonList.Name = "radioButtonList";
            radioButtonList.Size = new Size(43, 19);
            radioButtonList.TabIndex = 1;
            radioButtonList.TabStop = true;
            radioButtonList.Text = "List";
            radioButtonList.UseVisualStyleBackColor = true;
            // 
            // radioButtonPocztowka
            // 
            radioButtonPocztowka.AutoSize = true;
            radioButtonPocztowka.Location = new Point(6, 22);
            radioButtonPocztowka.Name = "radioButtonPocztowka";
            radioButtonPocztowka.Size = new Size(82, 19);
            radioButtonPocztowka.TabIndex = 0;
            radioButtonPocztowka.TabStop = true;
            radioButtonPocztowka.Text = "Pocztówka";
            radioButtonPocztowka.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxCity);
            groupBox2.Controls.Add(textBoxPostalCode);
            groupBox2.Controls.Add(labelCity);
            groupBox2.Controls.Add(labelPostalCode);
            groupBox2.Controls.Add(textBoxHouse);
            groupBox2.Controls.Add(labelHouse);
            groupBox2.Location = new Point(443, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 228);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dane adresowe";
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(25, 190);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(263, 23);
            textBoxCity.TabIndex = 5;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(25, 117);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(96, 23);
            textBoxPostalCode.TabIndex = 4;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(25, 159);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(43, 15);
            labelCity.TabIndex = 3;
            labelCity.Text = "Miasto";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(25, 85);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(82, 15);
            labelPostalCode.TabIndex = 2;
            labelPostalCode.Text = "Kod pocztowy";
            // 
            // textBoxHouse
            // 
            textBoxHouse.Location = new Point(25, 47);
            textBoxHouse.Name = "textBoxHouse";
            textBoxHouse.Size = new Size(263, 23);
            textBoxHouse.TabIndex = 1;
            // 
            // labelHouse
            // 
            labelHouse.AutoSize = true;
            labelHouse.Location = new Point(25, 17);
            labelHouse.Name = "labelHouse";
            labelHouse.Size = new Size(96, 15);
            labelHouse.TabIndex = 0;
            labelHouse.Text = "Ulica z numerem";
            // 
            // buttonCheckPrice
            // 
            buttonCheckPrice.Location = new Point(104, 202);
            buttonCheckPrice.Name = "buttonCheckPrice";
            buttonCheckPrice.Size = new Size(242, 23);
            buttonCheckPrice.TabIndex = 2;
            buttonCheckPrice.Text = "Sprawdz cenę";
            buttonCheckPrice.UseVisualStyleBackColor = true;
            buttonCheckPrice.Click += buttonCheckPrice_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(104, 259);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(110, 402);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(658, 23);
            buttonSubmit.TabIndex = 4;
            buttonSubmit.Text = "Zatwierdź";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(219, 267);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(0, 15);
            labelPrice.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPrice);
            Controls.Add(buttonSubmit);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCheckPrice);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nadaj przesyłkę PESEL: 000000000000";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButtonPaczka;
        private RadioButton radioButtonList;
        private RadioButton radioButtonPocztowka;
        private GroupBox groupBox2;
        private TextBox textBoxCity;
        private TextBox textBoxPostalCode;
        private Label labelCity;
        private Label labelPostalCode;
        private TextBox textBoxHouse;
        private Label labelHouse;
        private Button buttonCheckPrice;
        private PictureBox pictureBox1;
        private Button buttonSubmit;
        private Label labelPrice;
    }
}