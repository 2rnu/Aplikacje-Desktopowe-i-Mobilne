using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace egz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void acceptionButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            string repeatpassword = passwordRepeatTextBox.Text;
            string myEmail = emailTextBox.Text;

            if (!myEmail.Contains("@"))
            {
                infoLabel.Text = "Nieprawid�owy adres e-mail.";
            }
           /* else if (password.Length < 8)
            {
                infoLabel.Text = "Nie poda�e� �adnego has�a lub has�o jest za kr�tkie (minimum 8 znak�w).";
            } */
            else if (password != repeatpassword)
            {
                infoLabel.Text = "Niezgodne ze sob� has�a.";
            }
            else
            {
                infoLabel.Text = "Witaj: " + myEmail;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            infoLabel.Text = "Autor: 0000000000000";
        }
    }

}