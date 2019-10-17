namespace EasyIPToolWF
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.aButtonSet = new System.Windows.Forms.Button();
            this.aRadioBtnDHCP = new System.Windows.Forms.RadioButton();
            this.aRadioBtnStatic = new System.Windows.Forms.RadioButton();
            this.aGroupboxIPConfig = new System.Windows.Forms.GroupBox();
            this.aComboboxAdapter = new System.Windows.Forms.ComboBox();
            this.aLabelAdapter = new System.Windows.Forms.Label();
            this.aTBIP1 = new System.Windows.Forms.TextBox();
            this.aTBIP2 = new System.Windows.Forms.TextBox();
            this.aTBIP3 = new System.Windows.Forms.TextBox();
            this.aTBIP4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aTBSubnet4 = new System.Windows.Forms.TextBox();
            this.aTBSubnet3 = new System.Windows.Forms.TextBox();
            this.aTBSubnet2 = new System.Windows.Forms.TextBox();
            this.aTBSubnet1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.aTBGateway4 = new System.Windows.Forms.TextBox();
            this.aTBGateway3 = new System.Windows.Forms.TextBox();
            this.aTBGateway2 = new System.Windows.Forms.TextBox();
            this.aTBGateway1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.aLabelSubnet = new System.Windows.Forms.Label();
            this.aLabelGateway = new System.Windows.Forms.Label();
            this.aButtonClear = new System.Windows.Forms.Button();
            this.aLabelDNS = new System.Windows.Forms.Label();
            this.aTBDNS4 = new System.Windows.Forms.TextBox();
            this.aTBDNS3 = new System.Windows.Forms.TextBox();
            this.aTBDNS2 = new System.Windows.Forms.TextBox();
            this.aTBDNS1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.aPictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.aGroupboxIPConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPictureBoxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // aButtonSet
            // 
            this.aButtonSet.Location = new System.Drawing.Point(131, 191);
            this.aButtonSet.Name = "aButtonSet";
            this.aButtonSet.Size = new System.Drawing.Size(70, 23);
            this.aButtonSet.TabIndex = 20;
            this.aButtonSet.Text = "Set";
            this.aButtonSet.UseVisualStyleBackColor = true;
            this.aButtonSet.Click += new System.EventHandler(this.AButtonSet_Click);
            // 
            // aRadioBtnDHCP
            // 
            this.aRadioBtnDHCP.AutoSize = true;
            this.aRadioBtnDHCP.Location = new System.Drawing.Point(6, 15);
            this.aRadioBtnDHCP.Name = "aRadioBtnDHCP";
            this.aRadioBtnDHCP.Size = new System.Drawing.Size(55, 17);
            this.aRadioBtnDHCP.TabIndex = 2;
            this.aRadioBtnDHCP.TabStop = true;
            this.aRadioBtnDHCP.Text = "DHCP";
            this.aRadioBtnDHCP.UseVisualStyleBackColor = true;
            this.aRadioBtnDHCP.CheckedChanged += new System.EventHandler(this.ARadioBtnDHCP_CheckedChanged);
            // 
            // aRadioBtnStatic
            // 
            this.aRadioBtnStatic.AutoSize = true;
            this.aRadioBtnStatic.Location = new System.Drawing.Point(67, 15);
            this.aRadioBtnStatic.Name = "aRadioBtnStatic";
            this.aRadioBtnStatic.Size = new System.Drawing.Size(52, 17);
            this.aRadioBtnStatic.TabIndex = 3;
            this.aRadioBtnStatic.TabStop = true;
            this.aRadioBtnStatic.Text = "Static";
            this.aRadioBtnStatic.UseVisualStyleBackColor = true;
            this.aRadioBtnStatic.CheckedChanged += new System.EventHandler(this.ARadioBtnStatic_CheckedChanged);
            // 
            // aGroupboxIPConfig
            // 
            this.aGroupboxIPConfig.Controls.Add(this.aRadioBtnStatic);
            this.aGroupboxIPConfig.Controls.Add(this.aRadioBtnDHCP);
            this.aGroupboxIPConfig.Location = new System.Drawing.Point(64, 46);
            this.aGroupboxIPConfig.Name = "aGroupboxIPConfig";
            this.aGroupboxIPConfig.Size = new System.Drawing.Size(132, 36);
            this.aGroupboxIPConfig.TabIndex = 3;
            this.aGroupboxIPConfig.TabStop = false;
            this.aGroupboxIPConfig.Text = "Internet Protcol:";
            // 
            // aComboboxAdapter
            // 
            this.aComboboxAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aComboboxAdapter.FormattingEnabled = true;
            this.aComboboxAdapter.Location = new System.Drawing.Point(17, 19);
            this.aComboboxAdapter.Name = "aComboboxAdapter";
            this.aComboboxAdapter.Size = new System.Drawing.Size(179, 21);
            this.aComboboxAdapter.TabIndex = 1;
            this.aComboboxAdapter.DropDown += new System.EventHandler(this.AComboboxAdapter_DropDown);
            this.aComboboxAdapter.SelectedIndexChanged += new System.EventHandler(this.AComboboxAdapter_SelectedIndexChanged);
            // 
            // aLabelAdapter
            // 
            this.aLabelAdapter.AutoSize = true;
            this.aLabelAdapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelAdapter.Location = new System.Drawing.Point(57, 2);
            this.aLabelAdapter.Name = "aLabelAdapter";
            this.aLabelAdapter.Size = new System.Drawing.Size(100, 15);
            this.aLabelAdapter.TabIndex = 5;
            this.aLabelAdapter.Text = "Network Adapter:";
            // 
            // aTBIP1
            // 
            this.aTBIP1.Location = new System.Drawing.Point(55, 88);
            this.aTBIP1.MaxLength = 3;
            this.aTBIP1.Name = "aTBIP1";
            this.aTBIP1.Size = new System.Drawing.Size(32, 20);
            this.aTBIP1.TabIndex = 6;
            this.aTBIP1.TextChanged += new System.EventHandler(this.ATBOct1_TextChanged);
            this.aTBIP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBIP1_KeyPress);
            // 
            // aTBIP2
            // 
            this.aTBIP2.Location = new System.Drawing.Point(93, 88);
            this.aTBIP2.MaxLength = 3;
            this.aTBIP2.Name = "aTBIP2";
            this.aTBIP2.Size = new System.Drawing.Size(32, 20);
            this.aTBIP2.TabIndex = 7;
            this.aTBIP2.TextChanged += new System.EventHandler(this.ATBOct2_TextChanged);
            this.aTBIP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBIP2_KeyPress);
            // 
            // aTBIP3
            // 
            this.aTBIP3.Location = new System.Drawing.Point(131, 88);
            this.aTBIP3.MaxLength = 3;
            this.aTBIP3.Name = "aTBIP3";
            this.aTBIP3.Size = new System.Drawing.Size(32, 20);
            this.aTBIP3.TabIndex = 8;
            this.aTBIP3.TextChanged += new System.EventHandler(this.ATBOct3_TextChanged);
            this.aTBIP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBIP3_KeyPress);
            // 
            // aTBIP4
            // 
            this.aTBIP4.Location = new System.Drawing.Point(169, 88);
            this.aTBIP4.MaxLength = 3;
            this.aTBIP4.Name = "aTBIP4";
            this.aTBIP4.Size = new System.Drawing.Size(32, 20);
            this.aTBIP4.TabIndex = 9;
            this.aTBIP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBIP4_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = ".";
            // 
            // aTBSubnet4
            // 
            this.aTBSubnet4.Location = new System.Drawing.Point(169, 114);
            this.aTBSubnet4.MaxLength = 3;
            this.aTBSubnet4.Name = "aTBSubnet4";
            this.aTBSubnet4.Size = new System.Drawing.Size(32, 20);
            this.aTBSubnet4.TabIndex = 13;
            this.aTBSubnet4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBSubnet4_KeyPress);
            // 
            // aTBSubnet3
            // 
            this.aTBSubnet3.Location = new System.Drawing.Point(131, 114);
            this.aTBSubnet3.MaxLength = 3;
            this.aTBSubnet3.Name = "aTBSubnet3";
            this.aTBSubnet3.Size = new System.Drawing.Size(32, 20);
            this.aTBSubnet3.TabIndex = 12;
            this.aTBSubnet3.TextChanged += new System.EventHandler(this.ATBSubnet3_TextChanged);
            this.aTBSubnet3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBSubnet3_KeyPress);
            // 
            // aTBSubnet2
            // 
            this.aTBSubnet2.Location = new System.Drawing.Point(93, 114);
            this.aTBSubnet2.MaxLength = 3;
            this.aTBSubnet2.Name = "aTBSubnet2";
            this.aTBSubnet2.Size = new System.Drawing.Size(32, 20);
            this.aTBSubnet2.TabIndex = 11;
            this.aTBSubnet2.TextChanged += new System.EventHandler(this.ATBSubnet2_TextChanged);
            this.aTBSubnet2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBSubnet2_KeyPress);
            // 
            // aTBSubnet1
            // 
            this.aTBSubnet1.Location = new System.Drawing.Point(55, 114);
            this.aTBSubnet1.MaxLength = 3;
            this.aTBSubnet1.Name = "aTBSubnet1";
            this.aTBSubnet1.Size = new System.Drawing.Size(32, 20);
            this.aTBSubnet1.TabIndex = 10;
            this.aTBSubnet1.TextChanged += new System.EventHandler(this.ATBSubnet1_TextChanged);
            this.aTBSubnet1.Enter += new System.EventHandler(this.ATBSubnet1_Enter);
            this.aTBSubnet1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBSubnet1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = ".";
            // 
            // aTBGateway4
            // 
            this.aTBGateway4.Location = new System.Drawing.Point(169, 140);
            this.aTBGateway4.MaxLength = 3;
            this.aTBGateway4.Name = "aTBGateway4";
            this.aTBGateway4.Size = new System.Drawing.Size(32, 20);
            this.aTBGateway4.TabIndex = 17;
            this.aTBGateway4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBGateway4_KeyPress);
            // 
            // aTBGateway3
            // 
            this.aTBGateway3.Location = new System.Drawing.Point(131, 140);
            this.aTBGateway3.MaxLength = 3;
            this.aTBGateway3.Name = "aTBGateway3";
            this.aTBGateway3.Size = new System.Drawing.Size(32, 20);
            this.aTBGateway3.TabIndex = 16;
            this.aTBGateway3.TextChanged += new System.EventHandler(this.ATBGateway3_TextChanged);
            this.aTBGateway3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBGateway3_KeyPress);
            // 
            // aTBGateway2
            // 
            this.aTBGateway2.Location = new System.Drawing.Point(93, 140);
            this.aTBGateway2.MaxLength = 3;
            this.aTBGateway2.Name = "aTBGateway2";
            this.aTBGateway2.Size = new System.Drawing.Size(32, 20);
            this.aTBGateway2.TabIndex = 15;
            this.aTBGateway2.TextChanged += new System.EventHandler(this.ATBGateway2_TextChanged);
            this.aTBGateway2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBGateway2_KeyPress);
            // 
            // aTBGateway1
            // 
            this.aTBGateway1.Location = new System.Drawing.Point(55, 140);
            this.aTBGateway1.MaxLength = 3;
            this.aTBGateway1.Name = "aTBGateway1";
            this.aTBGateway1.Size = new System.Drawing.Size(32, 20);
            this.aTBGateway1.TabIndex = 14;
            this.aTBGateway1.TextChanged += new System.EventHandler(this.ATBGateway1_TextChanged);
            this.aTBGateway1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBGateway1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(161, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(123, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "IP Addr:";
            // 
            // aLabelSubnet
            // 
            this.aLabelSubnet.AutoSize = true;
            this.aLabelSubnet.Location = new System.Drawing.Point(10, 117);
            this.aLabelSubnet.Name = "aLabelSubnet";
            this.aLabelSubnet.Size = new System.Drawing.Size(44, 13);
            this.aLabelSubnet.TabIndex = 30;
            this.aLabelSubnet.Text = "Subnet:";
            // 
            // aLabelGateway
            // 
            this.aLabelGateway.AutoSize = true;
            this.aLabelGateway.Location = new System.Drawing.Point(2, 143);
            this.aLabelGateway.Name = "aLabelGateway";
            this.aLabelGateway.Size = new System.Drawing.Size(52, 13);
            this.aLabelGateway.TabIndex = 31;
            this.aLabelGateway.Text = "Gateway:";
            // 
            // aButtonClear
            // 
            this.aButtonClear.Location = new System.Drawing.Point(54, 191);
            this.aButtonClear.Name = "aButtonClear";
            this.aButtonClear.Size = new System.Drawing.Size(70, 23);
            this.aButtonClear.TabIndex = 32;
            this.aButtonClear.Text = "Clear";
            this.aButtonClear.UseVisualStyleBackColor = true;
            this.aButtonClear.Click += new System.EventHandler(this.AButtonClear_Click);
            // 
            // aLabelDNS
            // 
            this.aLabelDNS.AutoSize = true;
            this.aLabelDNS.Location = new System.Drawing.Point(16, 169);
            this.aLabelDNS.Name = "aLabelDNS";
            this.aLabelDNS.Size = new System.Drawing.Size(33, 13);
            this.aLabelDNS.TabIndex = 40;
            this.aLabelDNS.Text = "DNS:";
            // 
            // aTBDNS4
            // 
            this.aTBDNS4.Location = new System.Drawing.Point(169, 166);
            this.aTBDNS4.MaxLength = 3;
            this.aTBDNS4.Name = "aTBDNS4";
            this.aTBDNS4.Size = new System.Drawing.Size(32, 20);
            this.aTBDNS4.TabIndex = 20;
            this.aTBDNS4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBDNS4_KeyPress);
            // 
            // aTBDNS3
            // 
            this.aTBDNS3.Location = new System.Drawing.Point(131, 166);
            this.aTBDNS3.MaxLength = 3;
            this.aTBDNS3.Name = "aTBDNS3";
            this.aTBDNS3.Size = new System.Drawing.Size(32, 20);
            this.aTBDNS3.TabIndex = 35;
            this.aTBDNS3.TextChanged += new System.EventHandler(this.ATBDNS3_TextChanged);
            this.aTBDNS3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBDNS3_KeyPress);
            // 
            // aTBDNS2
            // 
            this.aTBDNS2.Location = new System.Drawing.Point(93, 166);
            this.aTBDNS2.MaxLength = 3;
            this.aTBDNS2.Name = "aTBDNS2";
            this.aTBDNS2.Size = new System.Drawing.Size(32, 20);
            this.aTBDNS2.TabIndex = 19;
            this.aTBDNS2.TextChanged += new System.EventHandler(this.ATBDNS2_TextChanged);
            this.aTBDNS2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBDNS2_KeyPress);
            // 
            // aTBDNS1
            // 
            this.aTBDNS1.Location = new System.Drawing.Point(55, 166);
            this.aTBDNS1.MaxLength = 3;
            this.aTBDNS1.Name = "aTBDNS1";
            this.aTBDNS1.Size = new System.Drawing.Size(32, 20);
            this.aTBDNS1.TabIndex = 18;
            this.aTBDNS1.TextChanged += new System.EventHandler(this.ATBDNS1_TextChanged);
            this.aTBDNS1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ATBDNS1_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(161, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = ".";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(123, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = ".";
            // 
            // aPictureBoxSettings
            // 
            this.aPictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aPictureBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("aPictureBoxSettings.Image")));
            this.aPictureBoxSettings.Location = new System.Drawing.Point(17, 56);
            this.aPictureBoxSettings.Name = "aPictureBoxSettings";
            this.aPictureBoxSettings.Size = new System.Drawing.Size(25, 26);
            this.aPictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aPictureBoxSettings.TabIndex = 41;
            this.aPictureBoxSettings.TabStop = false;
            this.aPictureBoxSettings.Click += new System.EventHandler(this.aPictureBoxSettings_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(210, 220);
            this.Controls.Add(this.aPictureBoxSettings);
            this.Controls.Add(this.aLabelDNS);
            this.Controls.Add(this.aTBDNS4);
            this.Controls.Add(this.aTBDNS3);
            this.Controls.Add(this.aTBDNS2);
            this.Controls.Add(this.aTBDNS1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.aButtonClear);
            this.Controls.Add(this.aLabelGateway);
            this.Controls.Add(this.aLabelSubnet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.aTBGateway4);
            this.Controls.Add(this.aTBGateway3);
            this.Controls.Add(this.aTBGateway2);
            this.Controls.Add(this.aTBGateway1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aTBSubnet4);
            this.Controls.Add(this.aTBSubnet3);
            this.Controls.Add(this.aTBSubnet2);
            this.Controls.Add(this.aTBSubnet1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.aTBIP4);
            this.Controls.Add(this.aTBIP3);
            this.Controls.Add(this.aTBIP2);
            this.Controls.Add(this.aTBIP1);
            this.Controls.Add(this.aLabelAdapter);
            this.Controls.Add(this.aComboboxAdapter);
            this.Controls.Add(this.aButtonSet);
            this.Controls.Add(this.aGroupboxIPConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyIPTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.aGroupboxIPConfig.ResumeLayout(false);
            this.aGroupboxIPConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aPictureBoxSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aButtonSet;
        private System.Windows.Forms.RadioButton aRadioBtnDHCP;
        private System.Windows.Forms.RadioButton aRadioBtnStatic;
        private System.Windows.Forms.GroupBox aGroupboxIPConfig;
        private System.Windows.Forms.ComboBox aComboboxAdapter;
        private System.Windows.Forms.Label aLabelAdapter;
        private System.Windows.Forms.TextBox aTBIP1;
        private System.Windows.Forms.TextBox aTBIP2;
        private System.Windows.Forms.TextBox aTBIP3;
        private System.Windows.Forms.TextBox aTBIP4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aTBSubnet4;
        private System.Windows.Forms.TextBox aTBSubnet3;
        private System.Windows.Forms.TextBox aTBSubnet2;
        private System.Windows.Forms.TextBox aTBSubnet1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aTBGateway4;
        private System.Windows.Forms.TextBox aTBGateway3;
        private System.Windows.Forms.TextBox aTBGateway2;
        private System.Windows.Forms.TextBox aTBGateway1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label aLabelSubnet;
        private System.Windows.Forms.Label aLabelGateway;
        private System.Windows.Forms.Button aButtonClear;
        private System.Windows.Forms.Label aLabelDNS;
        private System.Windows.Forms.TextBox aTBDNS4;
        private System.Windows.Forms.TextBox aTBDNS3;
        private System.Windows.Forms.TextBox aTBDNS2;
        private System.Windows.Forms.TextBox aTBDNS1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox aPictureBoxSettings;
    }
}

