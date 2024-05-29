using System.Net.NetworkInformation;

namespace SAE_Réseau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDéc_TextChanged(object sender, EventArgs e)
        {
            TextBox bouton = (TextBox)sender;
            TextBox bin = (TextBox)grpSaisie.Controls[bouton.Tag.ToString()];
            int nb;
            Int32.TryParse(bouton.Text,out nb);
            if (!(string.IsNullOrEmpty(bouton.Text)))
            {
                bin.Text = DecimalVersBinaire(nb);
            }
            else
            {
                bin.Text = "";
            }
            if(nb > 255)
            {
                bouton.Text = "255";
                bin.Text = DecimalVersBinaire(255);
            }
        }

        private void txtCIDR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMas1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMas2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMas3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MettreAJourConversionsDepuisDécimal()
        {
            // Convertir depuis le décimal vers le binaire et l'hexadécimal
            string bin = DecimalVersBinaire(int.Parse(txtDéc1.Text));
            string hex = DecimalVersHex(int.Parse(txtDéc1.Text));

            // Mettre à jour les TextBox liées
            txtBin1.Text = bin;
            txtHéx1.Text = hex;

            // Mettre à jour le masque en notation CIDR
            txtCIDR.Text = $"/{MasqueVersCIDR(txtMas1.Text)}";
        }




        private void MettreAJourMasqueDepuisCIDR()
        {
            // Convertir la notation CIDR en masque de sous-réseau
            string masque = CIDRVersMasque(int.Parse(txtCIDR.Text.Split('/')[1]));

            // Mettre à jour le TextBox lié
            txtMas1.Text = masque;
        }

        private void MettreAJourCIDRDepuisMasque()
        {
            // Convertir le masque de sous-réseau en notation CIDR
            txtCIDR.Text = $"/{MasqueVersCIDR(txtMas1.Text)}";
        }

        private string DecimalVersBinaire(int dec)
        {
            return Convert.ToString(dec, 2).PadLeft(8, '0');
        }

        private string DecimalVersHex(int dec)
        {
            return dec.ToString("X2");
        }




        private string CIDRVersMasque(int cidr)
        {
            uint mask = 0xffffffff << (32 - cidr);
            return string.Join(".", BitConverter.GetBytes(mask).Reverse().Take(4).Select(b => b.ToString()));
        }

        private int MasqueVersCIDR(string masque)
        {
            return masque.Split('.').Select(s => int.Parse(s)).Sum(b => Convert.ToString(b, 2).Count(c => c == '1'));
        }
    }
}
