namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string PocztowkaPrice = "1 z³otych";
        string ListPrice = "1.50 z³otych";
        string PaczkaPrice = "10 z³otych";

        private void buttonCheckPrice_Click(object sender, EventArgs e)
        {
            if (radioButtonList.Checked)
            {
                labelPrice.Text += ListPrice;
                pictureBox1.Image = Properties.Resources.list;
            }
            else if (radioButtonPaczka.Checked)
            {
                labelPrice.Text += PaczkaPrice;
                pictureBox1.Image = Properties.Resources.paczka;
            }
            else if (radioButtonPocztowka.Checked)
            {
                labelPrice.Text += PocztowkaPrice;
                pictureBox1.Image = Properties.Resources.pocztowka;
            }
            else { labelPrice.Text = "Sprawdz, czy zaznaczy³eœ jak¹œ opcje."; }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            string HouseLocation = textBoxHouse.Text;
            string PostalCode = textBoxPostalCode.Text;
            string City = textBoxCity.Text;

        }
    }
}