namespace SAE_Réseau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtDéc1 = new TextBox();
            grpSaisie = new GroupBox();
            lblmasque = new Label();
            lblMaskError = new Label();
            lblerr2 = new Label();
            lblerr = new Label();
            label4 = new Label();
            txtMas4 = new TextBox();
            txtMas3 = new TextBox();
            txtMas2 = new TextBox();
            txtMas1 = new TextBox();
            txtCIDR = new TextBox();
            txtDéc4 = new TextBox();
            txtDéc3 = new TextBox();
            txtDéc2 = new TextBox();
            lblDécimal = new Label();
            CalculAutomatique = new GroupBox();
            txtHéx4 = new TextBox();
            txtHéx3 = new TextBox();
            txtHéx2 = new TextBox();
            txtHéx1 = new TextBox();
            txtBin4 = new TextBox();
            txtBin3 = new TextBox();
            txtBin2 = new TextBox();
            txtBin1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtnbMachines = new TextBox();
            txtnbIP = new TextBox();
            lblnbMachines = new Label();
            lblnbIP = new Label();
            txtDerIP14 = new TextBox();
            txtDerIP3 = new TextBox();
            txtDerIP2 = new TextBox();
            txtDerIP1 = new TextBox();
            txtPremIP4 = new TextBox();
            txtPremIP3 = new TextBox();
            txtPremIP2 = new TextBox();
            txtPremIP1 = new TextBox();
            txtBro4 = new TextBox();
            txtBro3 = new TextBox();
            txtBro2 = new TextBox();
            txtBro1 = new TextBox();
            txtNet4 = new TextBox();
            txtNet3 = new TextBox();
            txtNet2 = new TextBox();
            txtNet1 = new TextBox();
            txtClasse = new TextBox();
            lblDernIP = new Label();
            lblPremIP = new Label();
            lblBroadcast = new Label();
            lblNet = new Label();
            lblClasse = new Label();
            grpSaisie.SuspendLayout();
            CalculAutomatique.SuspendLayout();
            SuspendLayout();
            // 
            // txtDéc1
            // 
            txtDéc1.BackColor = SystemColors.ControlLightLight;
            txtDéc1.Location = new Point(90, 56);
            txtDéc1.Margin = new Padding(2);
            txtDéc1.Name = "txtDéc1";
            txtDéc1.Size = new Size(121, 27);
            txtDéc1.TabIndex = 0;
            txtDéc1.Tag = "txtBin1";
            txtDéc1.TextChanged += txtDéc_TextChanged;
            // 
            // grpSaisie
            // 
            grpSaisie.BackColor = Color.White;
            grpSaisie.Controls.Add(lblmasque);
            grpSaisie.Controls.Add(lblMaskError);
            grpSaisie.Controls.Add(lblerr2);
            grpSaisie.Controls.Add(lblerr);
            grpSaisie.Controls.Add(label4);
            grpSaisie.Controls.Add(txtMas4);
            grpSaisie.Controls.Add(txtMas3);
            grpSaisie.Controls.Add(txtMas2);
            grpSaisie.Controls.Add(txtMas1);
            grpSaisie.Controls.Add(txtCIDR);
            grpSaisie.Controls.Add(txtDéc4);
            grpSaisie.Controls.Add(txtDéc3);
            grpSaisie.Controls.Add(txtDéc2);
            grpSaisie.Controls.Add(lblDécimal);
            grpSaisie.Controls.Add(txtDéc1);
            grpSaisie.Location = new Point(97, 10);
            grpSaisie.Margin = new Padding(2);
            grpSaisie.Name = "grpSaisie";
            grpSaisie.Padding = new Padding(2);
            grpSaisie.Size = new Size(725, 258);
            grpSaisie.TabIndex = 1;
            grpSaisie.TabStop = false;
            // 
            // lblmasque
            // 
            lblmasque.AutoSize = true;
            lblmasque.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmasque.ForeColor = Color.FromArgb(234, 80, 149);
            lblmasque.Location = new Point(325, 132);
            lblmasque.Margin = new Padding(2, 0, 2, 0);
            lblmasque.Name = "lblmasque";
            lblmasque.Size = new Size(83, 24);
            lblmasque.TabIndex = 26;
            lblmasque.Text = "Masque";
            // 
            // lblMaskError
            // 
            lblMaskError.AutoSize = true;
            lblMaskError.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaskError.ForeColor = Color.Red;
            lblMaskError.Location = new Point(301, 205);
            lblMaskError.Margin = new Padding(2, 0, 2, 0);
            lblMaskError.Name = "lblMaskError";
            lblMaskError.Size = new Size(88, 28);
            lblMaskError.TabIndex = 25;
            lblMaskError.Text = "Erreur 3";
            lblMaskError.Visible = false;
            // 
            // lblerr2
            // 
            lblerr2.AutoEllipsis = true;
            lblerr2.AutoSize = true;
            lblerr2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblerr2.ForeColor = Color.Red;
            lblerr2.Location = new Point(92, 205);
            lblerr2.Margin = new Padding(2, 0, 2, 0);
            lblerr2.Name = "lblerr2";
            lblerr2.Size = new Size(82, 28);
            lblerr2.TabIndex = 24;
            lblerr2.Text = "Erreur2";
            lblerr2.Visible = false;
            lblerr2.TextChanged += txtMas_TextChanged;
            // 
            // lblerr
            // 
            lblerr.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblerr.AutoSize = true;
            lblerr.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblerr.ForeColor = Color.Red;
            lblerr.Location = new Point(92, 95);
            lblerr.Margin = new Padding(2, 0, 2, 0);
            lblerr.Name = "lblerr";
            lblerr.Size = new Size(70, 28);
            lblerr.TabIndex = 23;
            lblerr.Text = "Erreur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(234, 80, 149);
            label4.Location = new Point(90, 132);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 24);
            label4.TabIndex = 22;
            label4.Text = "CIDR";
            // 
            // txtMas4
            // 
            txtMas4.Location = new Point(533, 166);
            txtMas4.Margin = new Padding(2);
            txtMas4.Name = "txtMas4";
            txtMas4.Size = new Size(96, 27);
            txtMas4.TabIndex = 21;
            // 
            // txtMas3
            // 
            txtMas3.Location = new Point(417, 166);
            txtMas3.Margin = new Padding(2);
            txtMas3.Name = "txtMas3";
            txtMas3.Size = new Size(96, 27);
            txtMas3.TabIndex = 20;
            // 
            // txtMas2
            // 
            txtMas2.Location = new Point(301, 166);
            txtMas2.Margin = new Padding(2);
            txtMas2.Name = "txtMas2";
            txtMas2.Size = new Size(96, 27);
            txtMas2.TabIndex = 19;
            // 
            // txtMas1
            // 
            txtMas1.Location = new Point(178, 166);
            txtMas1.Margin = new Padding(2);
            txtMas1.Name = "txtMas1";
            txtMas1.Size = new Size(96, 27);
            txtMas1.TabIndex = 18;
            // 
            // txtCIDR
            // 
            txtCIDR.Location = new Point(92, 166);
            txtCIDR.Margin = new Padding(2);
            txtCIDR.Name = "txtCIDR";
            txtCIDR.Size = new Size(63, 27);
            txtCIDR.TabIndex = 17;
            txtCIDR.TextChanged += txtCIDR_TextChanged;
            // 
            // txtDéc4
            // 
            txtDéc4.Location = new Point(516, 56);
            txtDéc4.Margin = new Padding(2);
            txtDéc4.Name = "txtDéc4";
            txtDéc4.Size = new Size(121, 27);
            txtDéc4.TabIndex = 8;
            txtDéc4.Tag = "txtBin4";
            txtDéc4.TextChanged += txtDéc_TextChanged;
            // 
            // txtDéc3
            // 
            txtDéc3.Location = new Point(374, 56);
            txtDéc3.Margin = new Padding(2);
            txtDéc3.Name = "txtDéc3";
            txtDéc3.Size = new Size(121, 27);
            txtDéc3.TabIndex = 7;
            txtDéc3.Tag = "txtBin3";
            txtDéc3.TextChanged += txtDéc_TextChanged;
            // 
            // txtDéc2
            // 
            txtDéc2.Location = new Point(234, 56);
            txtDéc2.Margin = new Padding(2);
            txtDéc2.Name = "txtDéc2";
            txtDéc2.Size = new Size(121, 27);
            txtDéc2.TabIndex = 6;
            txtDéc2.Tag = "txtBin2";
            txtDéc2.TextChanged += txtDéc_TextChanged;
            // 
            // lblDécimal
            // 
            lblDécimal.AutoSize = true;
            lblDécimal.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDécimal.ForeColor = Color.FromArgb(234, 80, 149);
            lblDécimal.Location = new Point(327, 22);
            lblDécimal.Margin = new Padding(2, 0, 2, 0);
            lblDécimal.Name = "lblDécimal";
            lblDécimal.Size = new Size(89, 24);
            lblDécimal.TabIndex = 3;
            lblDécimal.Text = "Décimal";
            // 
            // CalculAutomatique
            // 
            CalculAutomatique.BackColor = Color.White;
            CalculAutomatique.Controls.Add(txtHéx4);
            CalculAutomatique.Controls.Add(txtHéx3);
            CalculAutomatique.Controls.Add(txtHéx2);
            CalculAutomatique.Controls.Add(txtHéx1);
            CalculAutomatique.Controls.Add(txtBin4);
            CalculAutomatique.Controls.Add(txtBin3);
            CalculAutomatique.Controls.Add(txtBin2);
            CalculAutomatique.Controls.Add(txtBin1);
            CalculAutomatique.Controls.Add(label3);
            CalculAutomatique.Controls.Add(label2);
            CalculAutomatique.Controls.Add(txtnbMachines);
            CalculAutomatique.Controls.Add(txtnbIP);
            CalculAutomatique.Controls.Add(lblnbMachines);
            CalculAutomatique.Controls.Add(lblnbIP);
            CalculAutomatique.Controls.Add(txtDerIP14);
            CalculAutomatique.Controls.Add(txtDerIP3);
            CalculAutomatique.Controls.Add(txtDerIP2);
            CalculAutomatique.Controls.Add(txtDerIP1);
            CalculAutomatique.Controls.Add(txtPremIP4);
            CalculAutomatique.Controls.Add(txtPremIP3);
            CalculAutomatique.Controls.Add(txtPremIP2);
            CalculAutomatique.Controls.Add(txtPremIP1);
            CalculAutomatique.Controls.Add(txtBro4);
            CalculAutomatique.Controls.Add(txtBro3);
            CalculAutomatique.Controls.Add(txtBro2);
            CalculAutomatique.Controls.Add(txtBro1);
            CalculAutomatique.Controls.Add(txtNet4);
            CalculAutomatique.Controls.Add(txtNet3);
            CalculAutomatique.Controls.Add(txtNet2);
            CalculAutomatique.Controls.Add(txtNet1);
            CalculAutomatique.Controls.Add(txtClasse);
            CalculAutomatique.Controls.Add(lblDernIP);
            CalculAutomatique.Controls.Add(lblPremIP);
            CalculAutomatique.Controls.Add(lblBroadcast);
            CalculAutomatique.Controls.Add(lblNet);
            CalculAutomatique.Controls.Add(lblClasse);
            CalculAutomatique.Location = new Point(97, 307);
            CalculAutomatique.Margin = new Padding(2);
            CalculAutomatique.Name = "CalculAutomatique";
            CalculAutomatique.Padding = new Padding(2);
            CalculAutomatique.Size = new Size(725, 523);
            CalculAutomatique.TabIndex = 2;
            CalculAutomatique.TabStop = false;
            CalculAutomatique.Text = " ";
            // 
            // txtHéx4
            // 
            txtHéx4.Location = new Point(504, 154);
            txtHéx4.Margin = new Padding(2);
            txtHéx4.Name = "txtHéx4";
            txtHéx4.ReadOnly = true;
            txtHéx4.Size = new Size(121, 27);
            txtHéx4.TabIndex = 35;
            // 
            // txtHéx3
            // 
            txtHéx3.Location = new Point(362, 154);
            txtHéx3.Margin = new Padding(2);
            txtHéx3.Name = "txtHéx3";
            txtHéx3.ReadOnly = true;
            txtHéx3.Size = new Size(121, 27);
            txtHéx3.TabIndex = 34;
            // 
            // txtHéx2
            // 
            txtHéx2.Location = new Point(222, 154);
            txtHéx2.Margin = new Padding(2);
            txtHéx2.Name = "txtHéx2";
            txtHéx2.ReadOnly = true;
            txtHéx2.Size = new Size(121, 27);
            txtHéx2.TabIndex = 33;
            // 
            // txtHéx1
            // 
            txtHéx1.Location = new Point(78, 154);
            txtHéx1.Margin = new Padding(2);
            txtHéx1.Name = "txtHéx1";
            txtHéx1.ReadOnly = true;
            txtHéx1.Size = new Size(121, 27);
            txtHéx1.TabIndex = 32;
            // 
            // txtBin4
            // 
            txtBin4.Location = new Point(504, 64);
            txtBin4.Margin = new Padding(2);
            txtBin4.Name = "txtBin4";
            txtBin4.ReadOnly = true;
            txtBin4.Size = new Size(121, 27);
            txtBin4.TabIndex = 31;
            txtBin4.Tag = "txtHéx4";
            // 
            // txtBin3
            // 
            txtBin3.Location = new Point(362, 64);
            txtBin3.Margin = new Padding(2);
            txtBin3.Name = "txtBin3";
            txtBin3.ReadOnly = true;
            txtBin3.Size = new Size(121, 27);
            txtBin3.TabIndex = 30;
            txtBin3.Tag = "txtHéx3";
            // 
            // txtBin2
            // 
            txtBin2.Location = new Point(222, 64);
            txtBin2.Margin = new Padding(2);
            txtBin2.Name = "txtBin2";
            txtBin2.ReadOnly = true;
            txtBin2.Size = new Size(121, 27);
            txtBin2.TabIndex = 29;
            txtBin2.Tag = "txtHéx2";
            // 
            // txtBin1
            // 
            txtBin1.Location = new Point(78, 64);
            txtBin1.Margin = new Padding(2);
            txtBin1.Name = "txtBin1";
            txtBin1.ReadOnly = true;
            txtBin1.Size = new Size(121, 27);
            txtBin1.TabIndex = 28;
            txtBin1.Tag = "txtHéx1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(103, 32, 170);
            label3.Location = new Point(301, 108);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 24);
            label3.TabIndex = 27;
            label3.Text = "Héxadécimal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(103, 32, 170);
            label2.Location = new Point(319, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 26;
            label2.Text = "Binaire";
            // 
            // txtnbMachines
            // 
            txtnbMachines.Location = new Point(594, 465);
            txtnbMachines.Margin = new Padding(2);
            txtnbMachines.Name = "txtnbMachines";
            txtnbMachines.ReadOnly = true;
            txtnbMachines.Size = new Size(121, 27);
            txtnbMachines.TabIndex = 25;
            // 
            // txtnbIP
            // 
            txtnbIP.Location = new Point(153, 465);
            txtnbIP.Margin = new Padding(2);
            txtnbIP.Name = "txtnbIP";
            txtnbIP.ReadOnly = true;
            txtnbIP.Size = new Size(121, 27);
            txtnbIP.TabIndex = 24;
            // 
            // lblnbMachines
            // 
            lblnbMachines.AutoSize = true;
            lblnbMachines.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold);
            lblnbMachines.ForeColor = Color.FromArgb(103, 32, 170);
            lblnbMachines.Location = new Point(417, 470);
            lblnbMachines.Margin = new Padding(2, 0, 2, 0);
            lblnbMachines.Name = "lblnbMachines";
            lblnbMachines.Size = new Size(165, 18);
            lblnbMachines.TabIndex = 23;
            lblnbMachines.Text = "Nombre de machines";
            // 
            // lblnbIP
            // 
            lblnbIP.AutoSize = true;
            lblnbIP.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold);
            lblnbIP.ForeColor = Color.FromArgb(103, 32, 170);
            lblnbIP.Location = new Point(32, 470);
            lblnbIP.Margin = new Padding(2, 0, 2, 0);
            lblnbIP.Name = "lblnbIP";
            lblnbIP.Size = new Size(105, 18);
            lblnbIP.TabIndex = 22;
            lblnbIP.Text = "Nombre d'IP";
            // 
            // txtDerIP14
            // 
            txtDerIP14.Location = new Point(587, 413);
            txtDerIP14.Margin = new Padding(2);
            txtDerIP14.Name = "txtDerIP14";
            txtDerIP14.ReadOnly = true;
            txtDerIP14.Size = new Size(121, 27);
            txtDerIP14.TabIndex = 21;
            txtDerIP14.TextChanged += DerniereIp_TextChanged;
            // 
            // txtDerIP3
            // 
            txtDerIP3.Location = new Point(440, 413);
            txtDerIP3.Margin = new Padding(2);
            txtDerIP3.Name = "txtDerIP3";
            txtDerIP3.ReadOnly = true;
            txtDerIP3.Size = new Size(121, 27);
            txtDerIP3.TabIndex = 20;
            txtDerIP3.TextChanged += DerniereIp_TextChanged;
            // 
            // txtDerIP2
            // 
            txtDerIP2.Location = new Point(295, 413);
            txtDerIP2.Margin = new Padding(2);
            txtDerIP2.Name = "txtDerIP2";
            txtDerIP2.ReadOnly = true;
            txtDerIP2.Size = new Size(121, 27);
            txtDerIP2.TabIndex = 19;
            txtDerIP2.TextChanged += DerniereIp_TextChanged;
            // 
            // txtDerIP1
            // 
            txtDerIP1.Location = new Point(153, 413);
            txtDerIP1.Margin = new Padding(2);
            txtDerIP1.Name = "txtDerIP1";
            txtDerIP1.ReadOnly = true;
            txtDerIP1.Size = new Size(121, 27);
            txtDerIP1.TabIndex = 18;
            txtDerIP1.TextChanged += DerniereIp_TextChanged;
            // 
            // txtPremIP4
            // 
            txtPremIP4.Location = new Point(587, 366);
            txtPremIP4.Margin = new Padding(2);
            txtPremIP4.Name = "txtPremIP4";
            txtPremIP4.ReadOnly = true;
            txtPremIP4.Size = new Size(121, 27);
            txtPremIP4.TabIndex = 17;
            txtPremIP4.TextChanged += PremiereIp_TextChanged;
            // 
            // txtPremIP3
            // 
            txtPremIP3.Location = new Point(440, 366);
            txtPremIP3.Margin = new Padding(2);
            txtPremIP3.Name = "txtPremIP3";
            txtPremIP3.ReadOnly = true;
            txtPremIP3.Size = new Size(121, 27);
            txtPremIP3.TabIndex = 16;
            txtPremIP3.TextChanged += PremiereIp_TextChanged;
            // 
            // txtPremIP2
            // 
            txtPremIP2.Location = new Point(295, 366);
            txtPremIP2.Margin = new Padding(2);
            txtPremIP2.Name = "txtPremIP2";
            txtPremIP2.ReadOnly = true;
            txtPremIP2.Size = new Size(121, 27);
            txtPremIP2.TabIndex = 15;
            txtPremIP2.TextChanged += PremiereIp_TextChanged;
            // 
            // txtPremIP1
            // 
            txtPremIP1.Location = new Point(153, 366);
            txtPremIP1.Margin = new Padding(2);
            txtPremIP1.Name = "txtPremIP1";
            txtPremIP1.ReadOnly = true;
            txtPremIP1.Size = new Size(121, 27);
            txtPremIP1.TabIndex = 14;
            txtPremIP1.TextChanged += PremiereIp_TextChanged;
            // 
            // txtBro4
            // 
            txtBro4.Location = new Point(587, 325);
            txtBro4.Margin = new Padding(2);
            txtBro4.Name = "txtBro4";
            txtBro4.ReadOnly = true;
            txtBro4.Size = new Size(121, 27);
            txtBro4.TabIndex = 13;
            txtBro4.TextChanged += txtBroad_TextChanged;
            // 
            // txtBro3
            // 
            txtBro3.Location = new Point(440, 325);
            txtBro3.Margin = new Padding(2);
            txtBro3.Name = "txtBro3";
            txtBro3.ReadOnly = true;
            txtBro3.Size = new Size(121, 27);
            txtBro3.TabIndex = 12;
            txtBro3.TextChanged += txtBroad_TextChanged;
            // 
            // txtBro2
            // 
            txtBro2.Location = new Point(295, 325);
            txtBro2.Margin = new Padding(2);
            txtBro2.Name = "txtBro2";
            txtBro2.ReadOnly = true;
            txtBro2.Size = new Size(121, 27);
            txtBro2.TabIndex = 11;
            txtBro2.TextChanged += txtBroad_TextChanged;
            // 
            // txtBro1
            // 
            txtBro1.Location = new Point(153, 325);
            txtBro1.Margin = new Padding(2);
            txtBro1.Name = "txtBro1";
            txtBro1.ReadOnly = true;
            txtBro1.Size = new Size(121, 27);
            txtBro1.TabIndex = 10;
            txtBro1.TextChanged += txtBroad_TextChanged;
            // 
            // txtNet4
            // 
            txtNet4.Location = new Point(587, 285);
            txtNet4.Margin = new Padding(2);
            txtNet4.Name = "txtNet4";
            txtNet4.ReadOnly = true;
            txtNet4.Size = new Size(121, 27);
            txtNet4.TabIndex = 9;
            txtNet4.TextChanged += txtAdresseNet_TextChanged;
            // 
            // txtNet3
            // 
            txtNet3.Location = new Point(440, 285);
            txtNet3.Margin = new Padding(2);
            txtNet3.Name = "txtNet3";
            txtNet3.ReadOnly = true;
            txtNet3.Size = new Size(121, 27);
            txtNet3.TabIndex = 8;
            txtNet3.TextChanged += txtAdresseNet_TextChanged;
            // 
            // txtNet2
            // 
            txtNet2.ForeColor = SystemColors.ControlText;
            txtNet2.Location = new Point(295, 285);
            txtNet2.Margin = new Padding(2);
            txtNet2.Name = "txtNet2";
            txtNet2.ReadOnly = true;
            txtNet2.Size = new Size(121, 27);
            txtNet2.TabIndex = 7;
            txtNet2.TextChanged += txtAdresseNet_TextChanged;
            // 
            // txtNet1
            // 
            txtNet1.Location = new Point(153, 285);
            txtNet1.Margin = new Padding(2);
            txtNet1.Name = "txtNet1";
            txtNet1.ReadOnly = true;
            txtNet1.Size = new Size(121, 27);
            txtNet1.TabIndex = 6;
            txtNet1.TextChanged += txtAdresseNet_TextChanged;
            // 
            // txtClasse
            // 
            txtClasse.Location = new Point(153, 225);
            txtClasse.Margin = new Padding(2);
            txtClasse.Name = "txtClasse";
            txtClasse.ReadOnly = true;
            txtClasse.Size = new Size(97, 27);
            txtClasse.TabIndex = 5;
            txtClasse.TextChanged += txtClasse_TextChanged;
            // 
            // lblDernIP
            // 
            lblDernIP.AutoSize = true;
            lblDernIP.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold);
            lblDernIP.ForeColor = Color.FromArgb(103, 32, 170);
            lblDernIP.Location = new Point(46, 418);
            lblDernIP.Margin = new Padding(2, 0, 2, 0);
            lblDernIP.Name = "lblDernIP";
            lblDernIP.Size = new Size(98, 18);
            lblDernIP.TabIndex = 4;
            lblDernIP.Text = "Dernière IP";
            // 
            // lblPremIP
            // 
            lblPremIP.AutoSize = true;
            lblPremIP.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold);
            lblPremIP.ForeColor = Color.FromArgb(103, 32, 170);
            lblPremIP.Location = new Point(45, 371);
            lblPremIP.Margin = new Padding(2, 0, 2, 0);
            lblPremIP.Name = "lblPremIP";
            lblPremIP.Size = new Size(99, 18);
            lblPremIP.TabIndex = 3;
            lblPremIP.Text = "Première IP";
            // 
            // lblBroadcast
            // 
            lblBroadcast.AutoSize = true;
            lblBroadcast.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold);
            lblBroadcast.ForeColor = Color.FromArgb(103, 32, 170);
            lblBroadcast.Location = new Point(25, 330);
            lblBroadcast.Margin = new Padding(2, 0, 2, 0);
            lblBroadcast.Name = "lblBroadcast";
            lblBroadcast.Size = new Size(119, 18);
            lblBroadcast.TabIndex = 2;
            lblBroadcast.Text = "@ de broadcast";
            // 
            // lblNet
            // 
            lblNet.AutoSize = true;
            lblNet.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold);
            lblNet.ForeColor = Color.FromArgb(103, 32, 170);
            lblNet.Location = new Point(72, 290);
            lblNet.Margin = new Padding(2, 0, 2, 0);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(72, 18);
            lblNet.TabIndex = 1;
            lblNet.Text = "@ de net";
            // 
            // lblClasse
            // 
            lblClasse.AutoSize = true;
            lblClasse.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold);
            lblClasse.ForeColor = Color.FromArgb(103, 32, 170);
            lblClasse.Location = new Point(53, 230);
            lblClasse.Margin = new Padding(2, 0, 2, 0);
            lblClasse.Name = "lblClasse";
            lblClasse.Size = new Size(91, 18);
            lblClasse.TabIndex = 0;
            lblClasse.Text = "@ de classe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(902, 840);
            Controls.Add(CalculAutomatique);
            Controls.Add(grpSaisie);
            ForeColor = Color.FromArgb(103, 32, 170);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculateur de masque IPV4 ";
            grpSaisie.ResumeLayout(false);
            grpSaisie.PerformLayout();
            CalculAutomatique.ResumeLayout(false);
            CalculAutomatique.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDéc1;
        private GroupBox grpSaisie;
        private GroupBox CalculAutomatique;
        private TextBox txtDéc4;
        private TextBox txtDéc3;
        private TextBox txtDéc2;
        private Label lblDécimal;
        private TextBox txtCIDR;
        private TextBox txtMas4;
        private TextBox txtMas3;
        private TextBox txtMas2;
        private TextBox txtMas1;
        private Label label4;
        private Label lblerr;
        private Label lblBroadcast;
        private Label lblNet;
        private Label lblClasse;
        private TextBox txtNet3;
        private TextBox txtNet2;
        private TextBox txtNet1;
        private TextBox txtClasse;
        private Label lblDernIP;
        private Label lblPremIP;
        private TextBox txtDerIP14;
        private TextBox txtDerIP3;
        private TextBox txtDerIP2;
        private TextBox txtDerIP1;
        private TextBox txtPremIP4;
        private TextBox txtPremIP3;
        private TextBox txtPremIP2;
        private TextBox txtPremIP1;
        private TextBox txtBro4;
        private TextBox txtBro3;
        private TextBox txtBro2;
        private TextBox txtBro1;
        private TextBox txtNet4;
        private Label lblerr2;
        private TextBox txtnbMachines;
        private TextBox txtnbIP;
        private Label lblnbMachines;
        private Label lblnbIP;
        private Label lblMaskError;
        private Label lblmasque;
        private TextBox txtHéx4;
        private TextBox txtHéx3;
        private TextBox txtHéx2;
        private TextBox txtHéx1;
        private TextBox txtBin4;
        private TextBox txtBin3;
        private TextBox txtBin2;
        private TextBox txtBin1;
        private Label label3;
        private Label label2;
    }
}
