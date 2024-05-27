using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inf_04_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string occupation = comboBoxOccupation.Text;

            MessageBox.Show("Dane pracownika: " + name + " " + surname + " " + occupation);

        }

        private void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
        string howManyCharacters = textBoxAmmountOfChar.Text;
        int.TryParse(howManyCharacters, out int number);

            string password;

            const string DIGITS = "0123456789";
            const string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
            const string SPECIAL = @"!@#$%^&*()+=~[:'<>?,.|";
            const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            
            var rand = new Random();


            if (checkBoxNumericNumbers.Checked)
            {
                rand.Next();
            }



        }
    }
}