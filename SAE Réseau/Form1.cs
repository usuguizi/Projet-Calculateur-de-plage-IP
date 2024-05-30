using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace SAE_Réseau
{
    public partial class Form1 : Form
    {
        private bool isUpdating = false; // Indicateur pour éviter les boucles d'événements

        public Form1()
        {
            InitializeComponent();
            // Associer les événements TextChanged
            txtCIDR.TextChanged += txtCIDR_TextChanged;
            txtMas1.TextChanged += txtMas_TextChanged;
            txtMas2.TextChanged += txtMas_TextChanged;
            txtMas3.TextChanged += txtMas_TextChanged;
            txtMas4.TextChanged += txtMas_TextChanged;
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

        private void txtDéc_TextChanged(object sender, EventArgs e)
        {
            TextBox bouton = (TextBox)sender;

            // Récupérer la TextBox binaire associée
            TextBox bin = (TextBox)grpSaisie.Controls[bouton.Tag.ToString()];

            // Récupérer la TextBox hexadécimale associée à partir du tag de la TextBox binaire
            TextBox hex = (TextBox)grpSaisie.Controls[bin.Tag.ToString()];

            int nb;
            Int32.TryParse(bouton.Text, out nb);

            if (!(string.IsNullOrEmpty(bouton.Text)))
            {
                bin.Text = DecimalVersBinaire(nb);
                hex.Text = DecimalVersHex(nb);
            }
            else
            {
                bin.Text = "";
                hex.Text = "";
            }

            if (nb > 255)
            {
                bouton.Text = "255";
                bin.Text = DecimalVersBinaire(255);
                hex.Text = DecimalVersHex(255);
            }
        }

        private void txtCIDR_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating) return; // Éviter les boucles d'événements
            isUpdating = true;

            TextBox txtCIDR = (TextBox)sender;

            string cidrText = txtCIDR.Text;

            if (cidrText.StartsWith("/"))
            {
                cidrText = cidrText.Substring(1);
            }

            int cidr;
            if (int.TryParse(cidrText, out cidr) && cidr >= 0 && cidr <= 32)
            {
                string masque = CIDRVersMasque(cidr);
                string[] octets = masque.Split('.');
                txtMas1.Text = octets[0];
                txtMas2.Text = octets[1];
                txtMas3.Text = octets[2];
                txtMas4.Text = octets[3];
            }
            else
            {
                // Reset the mask fields if the CIDR input is invalid
                txtMas1.Text = "";
                txtMas2.Text = "";
                txtMas3.Text = "";
                txtMas4.Text = "";
            }

            if (!txtCIDR.Text.StartsWith("/"))
            {
                txtCIDR.Text = "/" + txtCIDR.Text;
                txtCIDR.SelectionStart = txtCIDR.Text.Length; // Positionner le curseur à la fin
            }

            isUpdating = false;
        }


        private void txtMas_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating) return; // Éviter les boucles d'événements
            isUpdating = true;

            if (int.TryParse(txtMas1.Text, out int octet1) && int.TryParse(txtMas2.Text, out int octet2) &&
                int.TryParse(txtMas3.Text, out int octet3) && int.TryParse(txtMas4.Text, out int octet4))
            {
                string masque = $"{octet1}.{octet2}.{octet3}.{octet4}";
                txtCIDR.Text = $"/{MasqueVersCIDR(masque)}";
            }
            else
            {
                // Reset the CIDR field if the mask input is invalid
                txtCIDR.Text = "";
            }

            isUpdating = false;
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

        private void txtMas(object sender, EventArgs e)
        {

        }
    }
}
