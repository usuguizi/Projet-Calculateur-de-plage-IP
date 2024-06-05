using System;
using System.Linq;
using System.Windows.Forms;

namespace SAE_Réseau
{
    public partial class Form1 : Form
    {
        private bool isUpdating = false; // Indicateur pour éviter les boucles d'événements

        public Form1()
        {
            InitializeComponent();
            // Associer les événements TextChanged et KeyPress
            txtCIDR.TextChanged += txtCIDR_TextChanged;
            txtMas1.KeyPress += txtEnt_entree;
            txtMas2.KeyPress += txtEnt_entree;
            txtMas3.KeyPress += txtEnt_entree;
            txtMas4.KeyPress += txtEnt_entree;
            txtDéc1.KeyPress += txtEnt_entree;
            txtDéc2.KeyPress += txtEnt_entree;
            txtDéc3.KeyPress += txtEnt_entree;
            txtDéc4.KeyPress += txtEnt_entree;
            lblerr.Visible = false; // Masquer le label d'erreur par défaut

            // Associer l'événement TextChanged à txtDéc1 pour afficher la classe IP
            txtDéc1.TextChanged += txtClasse_TextChanged;
            // Associer les événements TextChanged pour calculer l'adresse réseau
            txtDéc1.TextChanged += txtAdresseNet_TextChanged;
            txtDéc2.TextChanged += txtAdresseNet_TextChanged;
            txtDéc3.TextChanged += txtAdresseNet_TextChanged;
            txtDéc4.TextChanged += txtAdresseNet_TextChanged;
            txtMas1.TextChanged += txtAdresseNet_TextChanged;
            txtMas2.TextChanged += txtAdresseNet_TextChanged;
            txtMas3.TextChanged += txtAdresseNet_TextChanged;
            txtMas4.TextChanged += txtAdresseNet_TextChanged;

            // Associer l'événement TextChanged pour le masque
            txtMas1.TextChanged += txtMas_TextChanged;
            txtMas2.TextChanged += txtMas_TextChanged;
            txtMas3.TextChanged += txtMas_TextChanged;
            txtMas4.TextChanged += txtMas_TextChanged;

            txtDéc1.TextChanged += txtBroad_TextChanged;
            txtDéc2.TextChanged += txtBroad_TextChanged;
            txtDéc3.TextChanged += txtBroad_TextChanged;
            txtDéc4.TextChanged += txtBroad_TextChanged;
            txtMas1.TextChanged += txtBroad_TextChanged;
            txtMas2.TextChanged += txtBroad_TextChanged;
            txtMas3.TextChanged += txtBroad_TextChanged;
            txtMas4.TextChanged += txtBroad_TextChanged;

            txtDéc1.TextChanged += PremiereIp_TextChanged;
            txtDéc2.TextChanged += PremiereIp_TextChanged;
            txtDéc3.TextChanged += PremiereIp_TextChanged;
            txtDéc4.TextChanged += PremiereIp_TextChanged;
            txtMas1.TextChanged += PremiereIp_TextChanged;
            txtMas2.TextChanged += PremiereIp_TextChanged;
            txtMas3.TextChanged += PremiereIp_TextChanged;
            txtMas4.TextChanged += PremiereIp_TextChanged;

            txtDéc1.TextChanged += DerniereIp_TextChanged;
            txtDéc2.TextChanged += DerniereIp_TextChanged;
            txtDéc3.TextChanged += DerniereIp_TextChanged;
            txtDéc4.TextChanged += DerniereIp_TextChanged;
            txtMas1.TextChanged += DerniereIp_TextChanged;
            txtMas2.TextChanged += DerniereIp_TextChanged;
            txtMas3.TextChanged += DerniereIp_TextChanged;
            txtMas4.TextChanged += DerniereIp_TextChanged;

            this.txtCIDR.TextChanged += new System.EventHandler(this.txtCIDR_TextChanged);
            this.txtMas1.TextChanged += new System.EventHandler(this.txtMas_TextChanged);
            this.txtMas2.TextChanged += new System.EventHandler(this.txtMas_TextChanged);
            this.txtMas3.TextChanged += new System.EventHandler(this.txtMas_TextChanged);
            this.txtMas4.TextChanged += new System.EventHandler(this.txtMas_TextChanged);
            this.txtCIDR.TextChanged += new System.EventHandler(this.txtCIDR_TextChanged);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Eventuellement d'autres initialisations
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // Eventuellement d'autres actions
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Eventuellement d'autres actions
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

            CheckForErrors();
        }

        private void txtCIDR_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating) return; // Avoid event loops
            isUpdating = true;

            TextBox txtCIDR = (TextBox)sender;

            string cidrText = txtCIDR.Text;

            // Remove leading slash if present
            if (cidrText.StartsWith("/"))
            {
                cidrText = cidrText.Substring(1);
            }

            if (!string.IsNullOrEmpty(cidrText))
            {
                int cidr;
                if (int.TryParse(cidrText, out cidr) && cidr >= 0 && cidr <= 32)
                {
                    string masque = CIDRVersMasque(cidr);
                    string[] octets = masque.Split('.');
                    txtMas1.Text = octets[0];
                    txtMas2.Text = octets[1];
                    txtMas3.Text = octets[2];
                    txtMas4.Text = octets[3];
                    lblerr2.Visible = false; // Hide error label if CIDR is valid
                }
                else
                {
                    txtMas1.Text = "";
                    txtMas2.Text = "";
                    txtMas3.Text = "";
                    txtMas4.Text = "";
                    lblerr2.Visible = true; // Show error label if CIDR is invalid
                    lblerr2.Text = "CIDR incorrect";
                }
            }
            else
            {
                txtMas1.Text = "";
                txtMas2.Text = "";
                txtMas3.Text = "";
                txtMas4.Text = "";
                lblerr2.Visible = false; // Hide error label if CIDR is empty
            }

            // Ensure CIDR starts with a slash
            if (!txtCIDR.Text.StartsWith("/"))
            {
                txtCIDR.Text = "/" + txtCIDR.Text;
                txtCIDR.SelectionStart = txtCIDR.Text.Length; // Position cursor at the end
            }

            isUpdating = false;
        }

        private void txtMas_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating) return; // Avoid event loops
            isUpdating = true;

            // Try to parse the mask input fields
            if (int.TryParse(txtMas1.Text, out int octet1) && int.TryParse(txtMas2.Text, out int octet2) &&
                int.TryParse(txtMas3.Text, out int octet3) && int.TryParse(txtMas4.Text, out int octet4))
            {
                string masque = $"{octet1}.{octet2}.{octet3}.{octet4}";

                if (IsMasqueValide(masque))
                {
                    txtCIDR.Text = $"/{MasqueVersCIDR(masque)}";
                    lblerr2.Visible = false; // Hide error label if mask is valid
                }
                else
                {
                    txtCIDR.Text = ""; // Clear the CIDR field if mask is invalid
                    lblerr2.Visible = true; // Show error label if mask is invalid
                    lblerr2.Text = "Masque incorrect";
                }
            }
            else
            {
                txtCIDR.Text = ""; // Clear the CIDR field if mask is invalid
            }

            isUpdating = false;
        }


        private void CheckForErrors()
        {
            lblerr.Visible = false; // Masquer le label d'erreur par défaut

            // Vérifier les adresses IP non utilisables
            if (int.TryParse(txtDéc1.Text, out int dec1) && int.TryParse(txtDéc2.Text, out int dec2) &&
                int.TryParse(txtDéc3.Text, out int dec3) && int.TryParse(txtDéc4.Text, out int dec4))
            {
                if (dec1 == 0 || dec1 == 127 || (dec1 == 169 && dec2 == 254))
                {
                    lblerr.Text = "Adresse IP non utilisable.";
                    lblerr.Visible = true;
                }
                else if (dec1 == 10 || (dec1 == 172 && dec2 >= 16 && dec2 <= 31) || (dec1 == 192 && dec2 == 168))
                {
                    lblerr.Text = "Adresse IP non routable.";
                    lblerr.Visible = true;
                }
            }
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
            // Eventuellement d'autres actions
        }

        private void lblerr_Click_1(object sender, EventArgs e)
        {
            // Eventuellement d'autres actions
        }

        private void lblerreur(object sender, EventArgs e)
        {
            ForeColor = Color.White;
        }

        private void lblerr_Click(object sender, EventArgs e)
        {

        }

        private void txtEnt_entree(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            // Vérifie si la touche pressée est Entrée ou si la longueur du texte est de 3 chiffres
            if (e.KeyChar == (char)Keys.Enter || (textBox.Text.Length == 3 && char.IsDigit(e.KeyChar)))
            {
                e.Handled = true; // Empêche la saisie du caractère

                // Récupère le contrôle suivant dans l'ordre de tabulation
                Control nextControl = textBox.Parent.GetNextControl(textBox, true);

                if (nextControl != null)
                {
                    // Vérifie si le contrôle suivant est une TextBox
                    if (nextControl is TextBox)
                    {
                        TextBox nextTextBox = (TextBox)nextControl;

                        // Sélectionne tout le texte dans la prochaine TextBox pour afficher le curseur
                        nextTextBox.SelectAll();
                    }

                    nextControl.Focus(); // Déplace le focus vers le contrôle suivant
                }
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Empêche la saisie de caractères non numériques
            }
        }

        private void txtClasse_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtDéc1.Text, out int dec1))
            {
                if (dec1 >= 0 && dec1 <= 127)
                {
                    txtClasse.Text = "Classe A";
                }
                else if (dec1 >= 128 && dec1 <= 191)
                {
                    txtClasse.Text = "Classe B";
                }
                else if (dec1 >= 192 && dec1 <= 223)
                {
                    txtClasse.Text = "Classe C";
                }
                else if (dec1 >= 224 && dec1 <= 239)
                {
                    txtClasse.Text = "Classe D";
                }
                else if (dec1 >= 240 && dec1 <= 255)
                {
                    txtClasse.Text = "Classe E";
                }
                else
                {
                    txtClasse.Text = "Adresse IP non valide";
                }
            }
            else
            {
                txtClasse.Text = "Adresse IP non valide";
            }
        }

        private void txtAdresseNet_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtDéc1.Text, out int dec1) && int.TryParse(txtDéc2.Text, out int dec2) &&
                int.TryParse(txtDéc3.Text, out int dec3) && int.TryParse(txtDéc4.Text, out int dec4) &&
                int.TryParse(txtMas1.Text, out int mas1) && int.TryParse(txtMas2.Text, out int mas2) &&
                int.TryParse(txtMas3.Text, out int mas3) && int.TryParse(txtMas4.Text, out int mas4))
            {
                byte[] adresseIP = { (byte)dec1, (byte)dec2, (byte)dec3, (byte)dec4 };
                byte[] masque = { (byte)mas1, (byte)mas2, (byte)mas3, (byte)mas4 };

                byte[] adresseNet = AdresseNet(adresseIP, masque);

                txtNet1.Text = adresseNet[0].ToString();
                txtNet2.Text = adresseNet[1].ToString();
                txtNet3.Text = adresseNet[2].ToString();
                txtNet4.Text = adresseNet[3].ToString();
            }
            else
            {
                txtNet1.Text = "";
                txtNet2.Text = "";
                txtNet3.Text = "";
                txtNet4.Text = "";
            }
        }

        public static byte[] AdresseNet(byte[] AdresseIP, byte[] Masque)
        {
            byte[] AdresseNet = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                AdresseNet[i] = (byte)(AdresseIP[i] & Masque[i]);
            }
            return AdresseNet;
        }

        private bool IsMasqueValide(string masque)
        {
            string[] octets = masque.Split('.');
            if (octets.Length != 4)
            {
                return false;
            }

            int mask = 0;
            foreach (string octet in octets)
            {
                if (!int.TryParse(octet, out int num) || num < 0 || num > 255)
                {
                    return false;
                }
                mask = (mask << 8) | num;
            }

            bool passedZeros = false;
            for (int i = 31; i >= 0; i--)
            {
                bool isOne = (mask & (1 << i)) != 0;
                if (!isOne)
                {
                    passedZeros = true;
                }
                else if (passedZeros)
                {
                    return false;
                }
            }

            return true;
        }

        private void lblerr2_Click(object sender, EventArgs e)
        {

        }

        public static byte[] AdresseBroadcast(byte[] AdresseIP, byte[] Masque)
        {
            byte[] AdresseBroadcast = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                AdresseBroadcast[i] = (byte)(AdresseIP[i] | ~Masque[i]);
            }
            return AdresseBroadcast;
        }

        private void txtBroad_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtDéc1.Text, out int dec1) && int.TryParse(txtDéc2.Text, out int dec2) &&
                int.TryParse(txtDéc3.Text, out int dec3) && int.TryParse(txtDéc4.Text, out int dec4) &&
                int.TryParse(txtMas1.Text, out int mas1) && int.TryParse(txtMas2.Text, out int mas2) &&
                int.TryParse(txtMas3.Text, out int mas3) && int.TryParse(txtMas4.Text, out int mas4))
            {
                byte[] adresseIP = { (byte)dec1, (byte)dec2, (byte)dec3, (byte)dec4 };
                byte[] masque = { (byte)mas1, (byte)mas2, (byte)mas3, (byte)mas4 };

                byte[] adresseBroadcast = AdresseBroadcast(adresseIP, masque);

                txtBro1.Text = adresseBroadcast[0].ToString();
                txtBro2.Text = adresseBroadcast[1].ToString();
                txtBro3.Text = adresseBroadcast[2].ToString();
                txtBro4.Text = adresseBroadcast[3].ToString();
            }
            else
            {
                txtBro1.Text = "";
                txtBro2.Text = "";
                txtBro3.Text = "";
                txtBro4.Text = "";
            }
        }

        public void PremiereIp(byte[] AdresseNet)
        {
            byte[] PremiereAdresseIp = new byte[4];
            for (int i = 0; i < 3; i++)
            {
                PremiereAdresseIp[i] = AdresseNet[i];
            }
            PremiereAdresseIp[4] = (byte)(AdresseNet[4] + 1);
        }

        private void PremiereIp_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtDéc1.Text, out int dec1) && int.TryParse(txtDéc2.Text, out int dec2) &&
                int.TryParse(txtDéc3.Text, out int dec3) && int.TryParse(txtDéc4.Text, out int dec4) &&
                int.TryParse(txtMas1.Text, out int mas1) && int.TryParse(txtMas2.Text, out int mas2) &&
                int.TryParse(txtMas3.Text, out int mas3) && int.TryParse(txtMas4.Text, out int mas4))
            {
                byte[] adresseIP = { (byte)dec1, (byte)dec2, (byte)dec3, (byte)dec4 };
                byte[] masque = { (byte)mas1, (byte)mas2, (byte)mas3, (byte)mas4 };

                byte[] adresseNet = AdresseNet(adresseIP, masque);

                // Calculate first usable IP address
                byte[] PremiereAdresseIp = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    PremiereAdresseIp[i] = adresseNet[i];
                }
                PremiereAdresseIp[3] = (byte)(adresseNet[3] + 1); // Fix the array index

                txtPremIP1.Text = PremiereAdresseIp[0].ToString();
                txtPremIP2.Text = PremiereAdresseIp[1].ToString();
                txtPremIP3.Text = PremiereAdresseIp[2].ToString();
                txtPremIP4.Text = PremiereAdresseIp[3].ToString();
            }
            else
            {
                txtPremIP1.Text = "";
                txtPremIP2.Text = "";
                txtPremIP3.Text = "";
                txtPremIP4.Text = "";
            }
        }


        private void DerniereIp_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBro1.Text, out int broad1) && int.TryParse(txtBro2.Text, out int broad2) &&
                int.TryParse(txtBro3.Text, out int broad3) && int.TryParse(txtBro4.Text, out int broad4))
            {
                // Soustraction d'un pour obtenir la dernière adresse IP utilisable
                txtDerIP1.Text = broad1.ToString();
                txtDerIP2.Text = broad2.ToString();
                txtDerIP3.Text = broad3.ToString();
                txtDerIP14.Text = (broad4 - 1).ToString();
            }
            else
            {
                txtDerIP1.Text = "";
                txtDerIP2.Text = "";
                txtDerIP3.Text = "";
                txtDerIP14.Text = "";
            }
        }

        private void txtnbIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnbMachines_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
