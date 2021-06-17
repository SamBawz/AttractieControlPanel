namespace AttractieCommunicatie
{
    partial class frmControlPanel
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.lblPower = new System.Windows.Forms.Label();
            this.pbPower = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpbxSoundboard = new System.Windows.Forms.GroupBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.pbBattery = new System.Windows.Forms.ProgressBar();
            this.lblBattery = new System.Windows.Forms.Label();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stPower = new System.Windows.Forms.Label();
            this.tltPower = new System.Windows.Forms.Label();
            this.stLDR = new System.Windows.Forms.Label();
            this.tltLDR = new System.Windows.Forms.Label();
            this.stDraaien = new System.Windows.Forms.Label();
            this.tltDraaien = new System.Windows.Forms.Label();
            this.stSoundboard = new System.Windows.Forms.Label();
            this.tltSoundboard = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.trkbrSpeed = new System.Windows.Forms.TrackBar();
            this.tltSnelheid = new System.Windows.Forms.Label();
            this.stSnelheid = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpbxSoundboard.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(249, 161);
            this.cbPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(201, 28);
            this.cbPorts.TabIndex = 8;
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortArduino_DataReceived);
            // 
            // lblPower
            // 
            this.lblPower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPower.AutoSize = true;
            this.lblPower.Enabled = false;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.lblPower.Location = new System.Drawing.Point(789, 171);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(116, 29);
            this.lblPower.TabIndex = 9;
            this.lblPower.Tag = "lblLabels";
            this.lblPower.Text = "Power: 0";
            // 
            // pbPower
            // 
            this.pbPower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPower.Enabled = false;
            this.pbPower.Location = new System.Drawing.Point(602, 203);
            this.pbPower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPower.Name = "pbPower";
            this.pbPower.Size = new System.Drawing.Size(303, 29);
            this.pbPower.TabIndex = 10;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(105)))), ((int)(((byte)(176)))));
            this.btnStop.Location = new System.Drawing.Point(43, 50);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(98, 80);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(105)))), ((int)(((byte)(176)))));
            this.btnStart.Location = new System.Drawing.Point(159, 50);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 80);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpbxSoundboard
            // 
            this.grpbxSoundboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpbxSoundboard.Controls.Add(this.btnStop);
            this.grpbxSoundboard.Controls.Add(this.btnStart);
            this.grpbxSoundboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxSoundboard.Location = new System.Drawing.Point(249, 360);
            this.grpbxSoundboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxSoundboard.Name = "grpbxSoundboard";
            this.grpbxSoundboard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxSoundboard.Size = new System.Drawing.Size(305, 171);
            this.grpbxSoundboard.TabIndex = 14;
            this.grpbxSoundboard.TabStop = false;
            this.grpbxSoundboard.Text = "Geluiden";
            // 
            // btnTerug
            // 
            this.btnTerug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTerug.Location = new System.Drawing.Point(1283, 527);
            this.btnTerug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(104, 49);
            this.btnTerug.TabIndex = 16;
            this.btnTerug.Text = "Loguit";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // pbBattery
            // 
            this.pbBattery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBattery.Enabled = false;
            this.pbBattery.Location = new System.Drawing.Point(602, 496);
            this.pbBattery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBattery.Name = "pbBattery";
            this.pbBattery.Size = new System.Drawing.Size(537, 35);
            this.pbBattery.TabIndex = 17;
            // 
            // lblBattery
            // 
            this.lblBattery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBattery.AutoSize = true;
            this.lblBattery.Enabled = false;
            this.lblBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblBattery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.lblBattery.Location = new System.Drawing.Point(1015, 455);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(124, 29);
            this.lblBattery.TabIndex = 18;
            this.lblBattery.Tag = "lblLabels";
            this.lblBattery.Text = "Batterij: 0";
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 500;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUser.Location = new System.Drawing.Point(65, 134);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(91, 20);
            this.lblUser.TabIndex = 19;
            this.lblUser.Tag = "lblLabels";
            this.lblUser.Text = "Gebruiker";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 593);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = global::AttractieCommunicatie.Properties.Resources.home;
            this.button1.Location = new System.Drawing.Point(-7, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 55);
            this.button1.TabIndex = 23;
            this.button1.Tag = "lblLabels";
            this.button1.Text = "Control Panel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(-4, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "_____________________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttractieCommunicatie.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(36, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(241, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 45);
            this.label2.TabIndex = 21;
            this.label2.Tag = "lblLabels";
            this.label2.Text = "Control Panel";
            // 
            // stPower
            // 
            this.stPower.AutoSize = true;
            this.stPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(168)))));
            this.stPower.Location = new System.Drawing.Point(245, 130);
            this.stPower.Name = "stPower";
            this.stPower.Size = new System.Drawing.Size(177, 20);
            this.stPower.TabIndex = 1;
            this.stPower.Tag = "lblLabels";
            this.stPower.Text = "Doe hier de attractie aan.";
            // 
            // tltPower
            // 
            this.tltPower.AutoSize = true;
            this.tltPower.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.tltPower.Location = new System.Drawing.Point(243, 98);
            this.tltPower.Name = "tltPower";
            this.tltPower.Size = new System.Drawing.Size(79, 32);
            this.tltPower.TabIndex = 0;
            this.tltPower.Tag = "lblLabels";
            this.tltPower.Text = "Power";
            // 
            // stLDR
            // 
            this.stLDR.AutoSize = true;
            this.stLDR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(168)))));
            this.stLDR.Location = new System.Drawing.Point(598, 130);
            this.stLDR.Name = "stLDR";
            this.stLDR.Size = new System.Drawing.Size(194, 20);
            this.stLDR.TabIndex = 1;
            this.stLDR.Tag = "lblLabels";
            this.stLDR.Text = "Het LDR wordt hier gemeet.";
            // 
            // tltLDR
            // 
            this.tltLDR.AutoSize = true;
            this.tltLDR.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.tltLDR.Location = new System.Drawing.Point(596, 98);
            this.tltLDR.Name = "tltLDR";
            this.tltLDR.Size = new System.Drawing.Size(57, 32);
            this.tltLDR.TabIndex = 0;
            this.tltLDR.Tag = "lblLabels";
            this.tltLDR.Text = "LDR";
            // 
            // stDraaien
            // 
            this.stDraaien.AutoSize = true;
            this.stDraaien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(168)))));
            this.stDraaien.Location = new System.Drawing.Point(934, 130);
            this.stDraaien.Name = "stDraaien";
            this.stDraaien.Size = new System.Drawing.Size(129, 20);
            this.stDraaien.TabIndex = 1;
            this.stDraaien.Tag = "lblLabels";
            this.stDraaien.Text = "Draai het attractie";
            // 
            // tltDraaien
            // 
            this.tltDraaien.AutoSize = true;
            this.tltDraaien.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.tltDraaien.Location = new System.Drawing.Point(932, 93);
            this.tltDraaien.Name = "tltDraaien";
            this.tltDraaien.Size = new System.Drawing.Size(97, 32);
            this.tltDraaien.TabIndex = 0;
            this.tltDraaien.Tag = "lblLabels";
            this.tltDraaien.Text = "Draaien";
            // 
            // stSoundboard
            // 
            this.stSoundboard.AutoSize = true;
            this.stSoundboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(168)))));
            this.stSoundboard.Location = new System.Drawing.Point(245, 320);
            this.stSoundboard.Name = "stSoundboard";
            this.stSoundboard.Size = new System.Drawing.Size(173, 20);
            this.stSoundboard.TabIndex = 1;
            this.stSoundboard.Tag = "lblLabels";
            this.stSoundboard.Text = "Speel hier je geluiden af.";
            // 
            // tltSoundboard
            // 
            this.tltSoundboard.AutoSize = true;
            this.tltSoundboard.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.tltSoundboard.Location = new System.Drawing.Point(243, 288);
            this.tltSoundboard.Name = "tltSoundboard";
            this.tltSoundboard.Size = new System.Drawing.Size(146, 32);
            this.tltSoundboard.TabIndex = 0;
            this.tltSoundboard.Tag = "lblLabels";
            this.tltSoundboard.Text = "Soundboard";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(168)))));
            this.label13.Location = new System.Drawing.Point(598, 462);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(282, 20);
            this.label13.TabIndex = 1;
            this.label13.Tag = "lblLabels";
            this.label13.Text = "Bekijk hier je percentage van de attractie.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.label14.Location = new System.Drawing.Point(596, 430);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 32);
            this.label14.TabIndex = 0;
            this.label14.Tag = "lblLabels";
            this.label14.Text = "Batterij";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.lblMessage.Location = new System.Drawing.Point(245, 558);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(67, 20);
            this.lblMessage.TabIndex = 26;
            this.lblMessage.Tag = "lblLabels";
            this.lblMessage.Text = "Message";
            this.lblMessage.Visible = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Enabled = false;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.lblSpeed.Location = new System.Drawing.Point(994, 329);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(145, 29);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Tag = "lblLabels";
            this.lblSpeed.Text = "Snelheid: 2";
            // 
            // trkbrSpeed
            // 
            this.trkbrSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trkbrSpeed.Enabled = false;
            this.trkbrSpeed.Location = new System.Drawing.Point(590, 360);
            this.trkbrSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trkbrSpeed.Maximum = 4;
            this.trkbrSpeed.Name = "trkbrSpeed";
            this.trkbrSpeed.Size = new System.Drawing.Size(549, 56);
            this.trkbrSpeed.TabIndex = 5;
            this.trkbrSpeed.Scroll += new System.EventHandler(this.trkbrSpeed_Scroll);
            // 
            // tltSnelheid
            // 
            this.tltSnelheid.AutoSize = true;
            this.tltSnelheid.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.tltSnelheid.Location = new System.Drawing.Point(596, 288);
            this.tltSnelheid.Name = "tltSnelheid";
            this.tltSnelheid.Size = new System.Drawing.Size(108, 32);
            this.tltSnelheid.TabIndex = 0;
            this.tltSnelheid.Tag = "lblLabels";
            this.tltSnelheid.Text = "Snelheid";
            // 
            // stSnelheid
            // 
            this.stSnelheid.AutoSize = true;
            this.stSnelheid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(154)))), ((int)(((byte)(168)))));
            this.stSnelheid.Location = new System.Drawing.Point(598, 320);
            this.stSnelheid.Name = "stSnelheid";
            this.stSnelheid.Size = new System.Drawing.Size(174, 20);
            this.stSnelheid.TabIndex = 1;
            this.stSnelheid.Tag = "lblLabels";
            this.stSnelheid.Text = "Pas hier het snelheid aan.";
            // 
            // btnReverse
            // 
            this.btnReverse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReverse.BackgroundImage = global::AttractieCommunicatie.Properties.Resources.arrow;
            this.btnReverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReverse.Enabled = false;
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReverse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(105)))), ((int)(((byte)(176)))));
            this.btnReverse.Location = new System.Drawing.Point(977, 161);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(86, 71);
            this.btnReverse.TabIndex = 6;
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnPower
            // 
            this.btnPower.BackgroundImage = global::AttractieCommunicatie.Properties.Resources.switch_on_icon;
            this.btnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(105)))), ((int)(((byte)(176)))));
            this.btnPower.Location = new System.Drawing.Point(468, 161);
            this.btnPower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(86, 71);
            this.btnPower.TabIndex = 4;
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(1106, 26);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(33, 31);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "X";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1196, 593);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tltPower);
            this.Controls.Add(this.stPower);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.stDraaien);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.tltLDR);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.tltDraaien);
            this.Controls.Add(this.stLDR);
            this.Controls.Add(this.lblBattery);
            this.Controls.Add(this.pbBattery);
            this.Controls.Add(this.pbPower);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.stSoundboard);
            this.Controls.Add(this.trkbrSpeed);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tltSoundboard);
            this.Controls.Add(this.grpbxSoundboard);
            this.Controls.Add(this.stSnelheid);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tltSnelheid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTerug);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmControlPanel";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.frmControlPanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmControlPanel_MouseDown);
            this.grpbxSoundboard.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkbrSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.ProgressBar pbPower;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpbxSoundboard;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ProgressBar pbBattery;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stPower;
        private System.Windows.Forms.Label tltPower;
        private System.Windows.Forms.Label stLDR;
        private System.Windows.Forms.Label tltLDR;
        private System.Windows.Forms.Label stDraaien;
        private System.Windows.Forms.Label tltDraaien;
        private System.Windows.Forms.Label stSoundboard;
        private System.Windows.Forms.Label tltSoundboard;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar trkbrSpeed;
        private System.Windows.Forms.Label tltSnelheid;
        private System.Windows.Forms.Label stSnelheid;
        private System.Windows.Forms.Button btnReturn;
    }
}

