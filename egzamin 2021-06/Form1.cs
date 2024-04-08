using System.Windows.Forms;

namespace egzamin_2021_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = passwordTextbox.Text;
            string repeatpassword = passwordRepeatTextbox.Text;
            string myEmail = " ";

            myEmail += TextBoxEmail.Text + "\n";

            if (!myEmail.Contains("@"))
            {
                infoLabel.Text = "Nieprawid³owy adres e-mail.";
            }
            else if (password != repeatpassword)
            {
                infoLabel.Text = "Niezgodne ze sob¹ has³a.";
            }
            else
            {
                infoLabel.Text = "Witaj: " + myEmail;
            }
        }
    }
}