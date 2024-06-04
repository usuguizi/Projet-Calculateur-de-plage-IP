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
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            textBox17 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
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
            txtDéc1.Location = new Point(107, 106);
            txtDéc1.Name = "txtDéc1";
            txtDéc1.Size = new Size(150, 31);
            txtDéc1.TabIndex = 0;
            txtDéc1.Tag = "txtBin1";
            txtDéc1.TextChanged += txtDéc_TextChanged;
            // 
            // grpSaisie
            // 
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
            grpSaisie.Location = new Point(121, 26);
            grpSaisie.Name = "grpSaisie";
            grpSaisie.Size = new Size(906, 515);
            grpSaisie.TabIndex = 1;
            grpSaisie.TabStop = false;
            // 
            // lblerr2
            // 
            lblerr2.AutoEllipsis = true;
            lblerr2.AutoSize = true;
            lblerr2.Location = new Point(199, 464);
            lblerr2.Name = "lblerr2";
            lblerr2.Size = new Size(68, 25);
            lblerr2.TabIndex = 24;
            lblerr2.Text = "Erreur2";
            lblerr2.Visible = false;
            lblerr2.TextChanged += txtMas_TextChanged;
            lblerr2.Click += lblerr2_Click;
            // 
            // lblerr
            // 
            lblerr.AutoSize = true;
            lblerr.Location = new Point(125, 151);
            lblerr.Name = "lblerr";
            lblerr.Size = new Size(58, 25);
            lblerr.TabIndex = 23;
            lblerr.Text = "Erreur";
            lblerr.Click += lblerr_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 387);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 22;
            label4.Text = "CIDR";
            // 
            // txtMas4
            // 
            txtMas4.Location = new Point(655, 430);
            txtMas4.Name = "txtMas4";
            txtMas4.Size = new Size(119, 31);
            txtMas4.TabIndex = 21;
            // 
            // txtMas3
            // 
            txtMas3.Location = new Point(510, 430);
            txtMas3.Name = "txtMas3";
            txtMas3.Size = new Size(119, 31);
            txtMas3.TabIndex = 20;
            // 
            // txtMas2
            // 
            txtMas2.Location = new Point(365, 430);
            txtMas2.Name = "txtMas2";
            txtMas2.Size = new Size(119, 31);
            txtMas2.TabIndex = 19;
            // 
            // txtMas1
            // 
            txtMas1.Location = new Point(211, 430);
            txtMas1.Name = "txtMas1";
            txtMas1.Size = new Size(119, 31);
            txtMas1.TabIndex = 18;
            // 
            // txtCIDR
            // 
            txtCIDR.Location = new Point(62, 430);
            txtCIDR.Name = "txtCIDR";
            txtCIDR.Size = new Size(78, 31);
            txtCIDR.TabIndex = 17;
            txtCIDR.TextChanged += txtCIDR_TextChanged;
            // 
            // txtHéx4
            // 
            txtHéx4.Location = new Point(640, 335);
            txtHéx4.Name = "txtHéx4";
            txtHéx4.ReadOnly = true;
            txtHéx4.Size = new Size(150, 31);
            txtHéx4.TabIndex = 16;
            // 
            // txtHéx3
            // 
            txtHéx3.Location = new Point(462, 335);
            txtHéx3.Name = "txtHéx3";
            txtHéx3.ReadOnly = true;
            txtHéx3.Size = new Size(150, 31);
            txtHéx3.TabIndex = 15;
            // 
            // txtHéx2
            // 
            txtHéx2.Location = new Point(288, 335);
            txtHéx2.Name = "txtHéx2";
            txtHéx2.ReadOnly = true;
            txtHéx2.Size = new Size(150, 31);
            txtHéx2.TabIndex = 14;
            // 
            // txtHéx1
            // 
            txtHéx1.Location = new Point(107, 335);
            txtHéx1.Name = "txtHéx1";
            txtHéx1.ReadOnly = true;
            txtHéx1.Size = new Size(150, 31);
            txtHéx1.TabIndex = 13;
            // 
            // txtBin4
            // 
            txtBin4.Location = new Point(640, 222);
            txtBin4.Name = "txtBin4";
            txtBin4.ReadOnly = true;
            txtBin4.Size = new Size(150, 31);
            txtBin4.TabIndex = 12;
            txtBin4.Tag = "txtHéx4";
            // 
            // txtBin3
            // 
            txtBin3.Location = new Point(462, 222);
            txtBin3.Name = "txtBin3";
            txtBin3.ReadOnly = true;
            txtBin3.Size = new Size(150, 31);
            txtBin3.TabIndex = 11;
            txtBin3.Tag = "txtHéx3";
            // 
            // txtBin2
            // 
            txtBin2.Location = new Point(288, 222);
            txtBin2.Name = "txtBin2";
            txtBin2.ReadOnly = true;
            txtBin2.Size = new Size(150, 31);
            txtBin2.TabIndex = 10;
            txtBin2.Tag = "txtHéx2";
            // 
            // txtBin1
            // 
            txtBin1.Location = new Point(107, 222);
            txtBin1.Name = "txtBin1";
            txtBin1.ReadOnly = true;
            txtBin1.Size = new Size(150, 31);
            txtBin1.TabIndex = 9;
            txtBin1.Tag = "txtHéx1";
            // 
            // txtDéc4
            // 
            txtDéc4.Location = new Point(640, 106);
            txtDéc4.Name = "txtDéc4";
            txtDéc4.Size = new Size(150, 31);
            txtDéc4.TabIndex = 8;
            txtDéc4.Tag = "txtBin4";
            txtDéc4.TextChanged += txtDéc_TextChanged;
            // 
            // txtDéc3
            // 
            txtDéc3.Location = new Point(462, 106);
            txtDéc3.Name = "txtDéc3";
            txtDéc3.Size = new Size(150, 31);
            txtDéc3.TabIndex = 7;
            txtDéc3.Tag = "txtBin3";
            txtDéc3.TextChanged += txtDéc_TextChanged;
            // 
            // txtDéc2
            // 
            txtDéc2.Location = new Point(288, 106);
            txtDéc2.Name = "txtDéc2";
            txtDéc2.Size = new Size(150, 31);
            txtDéc2.TabIndex = 6;
            txtDéc2.Tag = "txtBin2";
            txtDéc2.TextChanged += txtDéc_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 275);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 5;
            label3.Text = "Héxadécimal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 170);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 4;
            label2.Text = "Binaire";
            // 
            // lblDécimal
            // 
            lblDécimal.AutoSize = true;
            lblDécimal.Location = new Point(409, 27);
            lblDécimal.Name = "lblDécimal";
            lblDécimal.Size = new Size(75, 25);
            lblDécimal.TabIndex = 3;
            lblDécimal.Text = "Décimal";
            // 
            // CalculAutomatique
            // 
            CalculAutomatique.Controls.Add(textBox14);
            CalculAutomatique.Controls.Add(textBox15);
            CalculAutomatique.Controls.Add(textBox16);
            CalculAutomatique.Controls.Add(textBox17);
            CalculAutomatique.Controls.Add(textBox10);
            CalculAutomatique.Controls.Add(textBox11);
            CalculAutomatique.Controls.Add(textBox12);
            CalculAutomatique.Controls.Add(textBox13);
            CalculAutomatique.Controls.Add(textBox6);
            CalculAutomatique.Controls.Add(textBox7);
            CalculAutomatique.Controls.Add(textBox8);
            CalculAutomatique.Controls.Add(textBox9);
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
            CalculAutomatique.Location = new Point(121, 557);
            CalculAutomatique.Name = "CalculAutomatique";
            CalculAutomatique.Size = new Size(906, 481);
            CalculAutomatique.TabIndex = 2;
            CalculAutomatique.TabStop = false;
            CalculAutomatique.Text = " ";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(741, 377);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(150, 31);
            textBox14.TabIndex = 21;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(557, 377);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(150, 31);
            textBox15.TabIndex = 20;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(376, 377);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(150, 31);
            textBox16.TabIndex = 19;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(199, 377);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(150, 31);
            textBox17.TabIndex = 18;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(741, 294);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(150, 31);
            textBox10.TabIndex = 17;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(557, 294);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(150, 31);
            textBox11.TabIndex = 16;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(376, 294);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(150, 31);
            textBox12.TabIndex = 15;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(199, 294);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(150, 31);
            textBox13.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(741, 200);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(557, 200);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(376, 200);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 31);
            textBox8.TabIndex = 11;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(199, 200);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(150, 31);
            textBox9.TabIndex = 10;
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
            lblDernIP.Location = new Point(42, 377);
            lblDernIP.Name = "lblDernIP";
            lblDernIP.Size = new Size(98, 25);
            lblDernIP.TabIndex = 4;
            lblDernIP.Text = "Dernière IP";
            // 
            // lblPremIP
            // 
            lblPremIP.AutoSize = true;
            lblPremIP.Location = new Point(39, 300);
            lblPremIP.Name = "lblPremIP";
            lblPremIP.Size = new Size(101, 25);
            lblPremIP.TabIndex = 3;
            lblPremIP.Text = "Première IP";
            // 
            // lblBroadcast
            // 
            lblBroadcast.AutoSize = true;
            lblBroadcast.Location = new Point(36, 200);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 1050);
            Controls.Add(CalculAutomatique);
            Controls.Add(grpSaisie);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox txtNet4;
        private Label lblerr2;
    }
}
