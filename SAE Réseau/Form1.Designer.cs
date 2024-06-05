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
            txtDéc1 = new TextBox();
            grpSaisie = new GroupBox();
            lblMaskError = new Label();
            lblerr2 = new Label();
            lblerr = new Label();
            label4 = new Label();
            txtMas4 = new TextBox();
            txtMas3 = new TextBox();
            txtMas2 = new TextBox();
            txtMas1 = new TextBox();
            txtCIDR = new TextBox();
            txtHéx4 = new TextBox();
            txtHéx3 = new TextBox();
            txtHéx2 = new TextBox();
            txtHéx1 = new TextBox();
            txtBin4 = new TextBox();
            txtBin3 = new TextBox();
            txtBin2 = new TextBox();
            txtBin1 = new TextBox();
            txtDéc4 = new TextBox();
            txtDéc3 = new TextBox();
            txtDéc2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblDécimal = new Label();
            CalculAutomatique = new GroupBox();
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
            lblmasque = new Label();
            grpSaisie.SuspendLayout();
            CalculAutomatique.SuspendLayout();
            SuspendLayout();
            // 
            // txtDéc1
            // 
            txtDéc1.BackColor = SystemColors.ControlLightLight;
            txtDéc1.Location = new Point(112, 70);
            txtDéc1.Name = "txtDéc1";
            txtDéc1.Size = new Size(150, 31);
            txtDéc1.TabIndex = 0;
            txtDéc1.Tag = "txtBin1";
            txtDéc1.TextChanged += txtDéc_TextChanged;
            // 
            // grpSaisie
            // 
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
            grpSaisie.Controls.Add(txtHéx4);
            grpSaisie.Controls.Add(txtHéx3);
            grpSaisie.Controls.Add(txtHéx2);
            grpSaisie.Controls.Add(txtHéx1);
            grpSaisie.Controls.Add(txtBin4);
            grpSaisie.Controls.Add(txtBin3);
            grpSaisie.Controls.Add(txtBin2);
            grpSaisie.Controls.Add(txtBin1);
            grpSaisie.Controls.Add(txtDéc4);
            grpSaisie.Controls.Add(txtDéc3);
            grpSaisie.Controls.Add(txtDéc2);
            grpSaisie.Controls.Add(label3);
            grpSaisie.Controls.Add(label2);
            grpSaisie.Controls.Add(lblDécimal);
            grpSaisie.Controls.Add(txtDéc1);
            grpSaisie.Location = new Point(121, 12);
            grpSaisie.Name = "grpSaisie";
            grpSaisie.Size = new Size(906, 515);
            grpSaisie.TabIndex = 1;
            grpSaisie.TabStop = false;
            // 
            // lblMaskError
            // 
            lblMaskError.AutoSize = true;
            lblMaskError.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaskError.ForeColor = Color.Red;
            lblMaskError.Location = new Point(370, 443);
            lblMaskError.Name = "lblMaskError";
            lblMaskError.Size = new Size(106, 32);
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
            lblerr2.Location = new Point(109, 443);
            lblerr2.Name = "lblerr2";
            lblerr2.Size = new Size(99, 32);
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
            lblerr.Location = new Point(112, 115);
            lblerr.Name = "lblerr";
            lblerr.Size = new Size(85, 32);
            lblerr.TabIndex = 23;
            lblerr.Text = "Erreur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 351);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 22;
            label4.Text = "CIDR";
            // 
            // txtMas4
            // 
            txtMas4.Location = new Point(660, 394);
            txtMas4.Name = "txtMas4";
            txtMas4.Size = new Size(119, 31);
            txtMas4.TabIndex = 21;
            // 
            // txtMas3
            // 
            txtMas3.Location = new Point(515, 394);
            txtMas3.Name = "txtMas3";
            txtMas3.Size = new Size(119, 31);
            txtMas3.TabIndex = 20;
            // 
            // txtMas2
            // 
            txtMas2.Location = new Point(370, 394);
            txtMas2.Name = "txtMas2";
            txtMas2.Size = new Size(119, 31);
            txtMas2.TabIndex = 19;
            // 
            // txtMas1
            // 
            txtMas1.Location = new Point(216, 394);
            txtMas1.Name = "txtMas1";
            txtMas1.Size = new Size(119, 31);
            txtMas1.TabIndex = 18;
            // 
            // txtCIDR
            // 
            txtCIDR.Location = new Point(67, 394);
            txtCIDR.Name = "txtCIDR";
            txtCIDR.Size = new Size(78, 31);
            txtCIDR.TabIndex = 17;
            txtCIDR.TextChanged += txtCIDR_TextChanged;
            // 
            // txtHéx4
            // 
            txtHéx4.Location = new Point(645, 299);
            txtHéx4.Name = "txtHéx4";
            txtHéx4.ReadOnly = true;
            txtHéx4.Size = new Size(150, 31);
            txtHéx4.TabIndex = 16;
            // 
            // txtHéx3
            // 
            txtHéx3.Location = new Point(467, 299);
            txtHéx3.Name = "txtHéx3";
            txtHéx3.ReadOnly = true;
            txtHéx3.Size = new Size(150, 31);
            txtHéx3.TabIndex = 15;
            // 
            // txtHéx2
            // 
            txtHéx2.Location = new Point(293, 299);
            txtHéx2.Name = "txtHéx2";
            txtHéx2.ReadOnly = true;
            txtHéx2.Size = new Size(150, 31);
            txtHéx2.TabIndex = 14;
            // 
            // txtHéx1
            // 
            txtHéx1.Location = new Point(112, 299);
            txtHéx1.Name = "txtHéx1";
            txtHéx1.ReadOnly = true;
            txtHéx1.Size = new Size(150, 31);
            txtHéx1.TabIndex = 13;
            // 
            // txtBin4
            // 
            txtBin4.Location = new Point(645, 186);
            txtBin4.Name = "txtBin4";
            txtBin4.ReadOnly = true;
            txtBin4.Size = new Size(150, 31);
            txtBin4.TabIndex = 12;
            txtBin4.Tag = "txtHéx4";
            // 
            // txtBin3
            // 
            txtBin3.Location = new Point(467, 186);
            txtBin3.Name = "txtBin3";
            txtBin3.ReadOnly = true;
            txtBin3.Size = new Size(150, 31);
            txtBin3.TabIndex = 11;
            txtBin3.Tag = "txtHéx3";
            // 
            // txtBin2
            // 
            txtBin2.Location = new Point(293, 186);
            txtBin2.Name = "txtBin2";
            txtBin2.ReadOnly = true;
            txtBin2.Size = new Size(150, 31);
            txtBin2.TabIndex = 10;
            txtBin2.Tag = "txtHéx2";
            // 
            // txtBin1
            // 
            txtBin1.Location = new Point(112, 186);
            txtBin1.Name = "txtBin1";
            txtBin1.ReadOnly = true;
            txtBin1.Size = new Size(150, 31);
            txtBin1.TabIndex = 9;
            txtBin1.Tag = "txtHéx1";
            // 
            // txtDéc4
            // 
            txtDéc4.Location = new Point(645, 70);
            txtDéc4.Name = "txtDéc4";
            txtDéc4.Size = new Size(150, 31);
            txtDéc4.TabIndex = 8;
            txtDéc4.Tag = "txtBin4";
            txtDéc4.TextChanged += txtDéc_TextChanged;
            // 
            // txtDéc3
            // 
            txtDéc3.Location = new Point(467, 70);
            txtDéc3.Name = "txtDéc3";
            txtDéc3.Size = new Size(150, 31);
            txtDéc3.TabIndex = 7;
            txtDéc3.Tag = "txtBin3";
            txtDéc3.TextChanged += txtDéc_TextChanged;
            // 
            // txtDéc2
            // 
            txtDéc2.Location = new Point(293, 70);
            txtDéc2.Name = "txtDéc2";
            txtDéc2.Size = new Size(150, 31);
            txtDéc2.TabIndex = 6;
            txtDéc2.Tag = "txtBin2";
            txtDéc2.TextChanged += txtDéc_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(400, 239);
            label3.Name = "label3";
            label3.Size = new Size(158, 28);
            label3.TabIndex = 5;
            label3.Text = "Héxadécimal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(414, 134);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 4;
            label2.Text = "Binaire";
            // 
            // lblDécimal
            // 
            lblDécimal.AutoSize = true;
            lblDécimal.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDécimal.Location = new Point(409, 27);
            lblDécimal.Name = "lblDécimal";
            lblDécimal.Size = new Size(107, 28);
            lblDécimal.TabIndex = 3;
            lblDécimal.Text = "Décimal";
            // 
            // CalculAutomatique
            // 
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
            CalculAutomatique.Location = new Point(121, 533);
            CalculAutomatique.Name = "CalculAutomatique";
            CalculAutomatique.Size = new Size(906, 505);
            CalculAutomatique.TabIndex = 2;
            CalculAutomatique.TabStop = false;
            CalculAutomatique.Text = " ";
            // 
            // txtnbMachines
            // 
            txtnbMachines.Location = new Point(750, 337);
            txtnbMachines.Name = "txtnbMachines";
            txtnbMachines.Size = new Size(150, 31);
            txtnbMachines.TabIndex = 25;
            // 
            // txtnbIP
            // 
            txtnbIP.Location = new Point(199, 337);
            txtnbIP.Name = "txtnbIP";
            txtnbIP.Size = new Size(150, 31);
            txtnbIP.TabIndex = 24;
            // 
            // lblnbMachines
            // 
            lblnbMachines.AutoSize = true;
            lblnbMachines.Location = new Point(517, 340);
            lblnbMachines.Name = "lblnbMachines";
            lblnbMachines.Size = new Size(190, 25);
            lblnbMachines.TabIndex = 23;
            lblnbMachines.Text = "Nombres de machines";
            // 
            // lblnbIP
            // 
            lblnbIP.AutoSize = true;
            lblnbIP.Location = new Point(47, 340);
            lblnbIP.Name = "lblnbIP";
            lblnbIP.Size = new Size(121, 25);
            lblnbIP.TabIndex = 22;
            lblnbIP.Text = "Nombres d'IP";
            // 
            // txtDerIP14
            // 
            txtDerIP14.Location = new Point(741, 273);
            txtDerIP14.Name = "txtDerIP14";
            txtDerIP14.Size = new Size(150, 31);
            txtDerIP14.TabIndex = 21;
            txtDerIP14.TextChanged += DerniereIp_TextChanged;
            // 
            // txtDerIP3
            // 
            txtDerIP3.Location = new Point(557, 273);
            txtDerIP3.Name = "txtDerIP3";
            txtDerIP3.Size = new Size(150, 31);
            txtDerIP3.TabIndex = 20;
            txtDerIP3.TextChanged += DerniereIp_TextChanged;
            // 
            // txtDerIP2
            // 
            txtDerIP2.Location = new Point(376, 273);
            txtDerIP2.Name = "txtDerIP2";
            txtDerIP2.Size = new Size(150, 31);
            txtDerIP2.TabIndex = 19;
            txtDerIP2.TextChanged += DerniereIp_TextChanged;
            // 
            // txtDerIP1
            // 
            txtDerIP1.Location = new Point(199, 273);
            txtDerIP1.Name = "txtDerIP1";
            txtDerIP1.Size = new Size(150, 31);
            txtDerIP1.TabIndex = 18;
            txtDerIP1.TextChanged += DerniereIp_TextChanged;
            // 
            // txtPremIP4
            // 
            txtPremIP4.Location = new Point(741, 214);
            txtPremIP4.Name = "txtPremIP4";
            txtPremIP4.Size = new Size(150, 31);
            txtPremIP4.TabIndex = 17;
            txtPremIP4.TextChanged += PremiereIp_TextChanged;
            // 
            // txtPremIP3
            // 
            txtPremIP3.Location = new Point(557, 214);
            txtPremIP3.Name = "txtPremIP3";
            txtPremIP3.Size = new Size(150, 31);
            txtPremIP3.TabIndex = 16;
            txtPremIP3.TextChanged += PremiereIp_TextChanged;
            // 
            // txtPremIP2
            // 
            txtPremIP2.Location = new Point(376, 214);
            txtPremIP2.Name = "txtPremIP2";
            txtPremIP2.Size = new Size(150, 31);
            txtPremIP2.TabIndex = 15;
            txtPremIP2.TextChanged += PremiereIp_TextChanged;
            // 
            // txtPremIP1
            // 
            txtPremIP1.Location = new Point(199, 214);
            txtPremIP1.Name = "txtPremIP1";
            txtPremIP1.Size = new Size(150, 31);
            txtPremIP1.TabIndex = 14;
            txtPremIP1.TextChanged += PremiereIp_TextChanged;
            // 
            // txtBro4
            // 
            txtBro4.Location = new Point(741, 163);
            txtBro4.Name = "txtBro4";
            txtBro4.Size = new Size(150, 31);
            txtBro4.TabIndex = 13;
            txtBro4.TextChanged += txtBroad_TextChanged;
            // 
            // txtBro3
            // 
            txtBro3.Location = new Point(557, 163);
            txtBro3.Name = "txtBro3";
            txtBro3.Size = new Size(150, 31);
            txtBro3.TabIndex = 12;
            txtBro3.TextChanged += txtBroad_TextChanged;
            // 
            // txtBro2
            // 
            txtBro2.Location = new Point(376, 163);
            txtBro2.Name = "txtBro2";
            txtBro2.Size = new Size(150, 31);
            txtBro2.TabIndex = 11;
            txtBro2.TextChanged += txtBroad_TextChanged;
            // 
            // txtBro1
            // 
            txtBro1.Location = new Point(199, 163);
            txtBro1.Name = "txtBro1";
            txtBro1.Size = new Size(150, 31);
            txtBro1.TabIndex = 10;
            txtBro1.TextChanged += txtBroad_TextChanged;
            // 
            // txtNet4
            // 
            txtNet4.Location = new Point(741, 113);
            txtNet4.Name = "txtNet4";
            txtNet4.Size = new Size(150, 31);
            txtNet4.TabIndex = 9;
            txtNet4.TextChanged += txtAdresseNet_TextChanged;
            // 
            // txtNet3
            // 
            txtNet3.Location = new Point(557, 113);
            txtNet3.Name = "txtNet3";
            txtNet3.Size = new Size(150, 31);
            txtNet3.TabIndex = 8;
            txtNet3.TextChanged += txtAdresseNet_TextChanged;
            // 
            // txtNet2
            // 
            txtNet2.Location = new Point(376, 113);
            txtNet2.Name = "txtNet2";
            txtNet2.Size = new Size(150, 31);
            txtNet2.TabIndex = 7;
            txtNet2.TextChanged += txtAdresseNet_TextChanged;
            // 
            // txtNet1
            // 
            txtNet1.Location = new Point(199, 113);
            txtNet1.Name = "txtNet1";
            txtNet1.Size = new Size(150, 31);
            txtNet1.TabIndex = 6;
            txtNet1.TextChanged += txtAdresseNet_TextChanged;
            // 
            // txtClasse
            // 
            txtClasse.Location = new Point(199, 37);
            txtClasse.Name = "txtClasse";
            txtClasse.Size = new Size(120, 31);
            txtClasse.TabIndex = 5;
            txtClasse.TextChanged += txtClasse_TextChanged;
            // 
            // lblDernIP
            // 
            lblDernIP.AutoSize = true;
            lblDernIP.Location = new Point(47, 273);
            lblDernIP.Name = "lblDernIP";
            lblDernIP.Size = new Size(98, 25);
            lblDernIP.TabIndex = 4;
            lblDernIP.Text = "Dernière IP";
            // 
            // lblPremIP
            // 
            lblPremIP.AutoSize = true;
            lblPremIP.Location = new Point(44, 220);
            lblPremIP.Name = "lblPremIP";
            lblPremIP.Size = new Size(101, 25);
            lblPremIP.TabIndex = 3;
            lblPremIP.Text = "Première IP";
            // 
            // lblBroadcast
            // 
            lblBroadcast.AutoSize = true;
            lblBroadcast.Location = new Point(30, 163);
            lblBroadcast.Name = "lblBroadcast";
            lblBroadcast.Size = new Size(138, 25);
            lblBroadcast.TabIndex = 2;
            lblBroadcast.Text = "@ de broadcast";
            // 
            // lblNet
            // 
            lblNet.AutoSize = true;
            lblNet.Location = new Point(36, 113);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(84, 25);
            lblNet.TabIndex = 1;
            lblNet.Text = "@ de net";
            // 
            // lblClasse
            // 
            lblClasse.AutoSize = true;
            lblClasse.Location = new Point(35, 40);
            lblClasse.Name = "lblClasse";
            lblClasse.Size = new Size(105, 25);
            lblClasse.TabIndex = 0;
            lblClasse.Text = "@ de classe";
            // 
            // lblmasque
            // 
            lblmasque.AutoSize = true;
            lblmasque.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmasque.Location = new Point(400, 351);
            lblmasque.Name = "lblmasque";
            lblmasque.Size = new Size(98, 28);
            lblmasque.TabIndex = 26;
            lblmasque.Text = "Masque";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(1127, 1050);
            Controls.Add(CalculAutomatique);
            Controls.Add(grpSaisie);
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
        private Label label3;
        private Label label2;
        private Label lblDécimal;
        private TextBox txtBin1;
        private TextBox txtBin2;
        private TextBox txtBin4;
        private TextBox txtBin3;
        private TextBox txtHéx1;
        private TextBox txtHéx4;
        private TextBox txtHéx3;
        private TextBox txtHéx2;
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
    }
}
