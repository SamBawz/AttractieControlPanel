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
            this.lblSpeed = new System.Windows.Forms.Label();
            this.trkbrSpeed = new System.Windows.Forms.TrackBar();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.lblReverse = new System.Windows.Forms.Label();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.tmrSend = new System.Windows.Forms.Timer(this.components);
            this.lblPower = new System.Windows.Forms.Label();
            this.pbPower = new System.Windows.Forms.ProgressBar();
            this.btnSnel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpbxSoundboard = new System.Windows.Forms.GroupBox();
            this.tmrRecieve = new System.Windows.Forms.Timer(this.components);
            this.btnTerug = new System.Windows.Forms.Button();
            this.pbBatterij = new System.Windows.Forms.ProgressBar();
            this.lblBatterij = new System.Windows.Forms.Label();
            this.tmrBattery = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateGUI = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trkbrSpeed)).BeginInit();
            this.grpbxSoundboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Enabled = false;
            this.lblSpeed.Location = new System.Drawing.Point(194, 146);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(60, 13);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Snelheid: 2";
            // 
            // trkbrSpeed
            // 
            this.trkbrSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trkbrSpeed.Enabled = false;
            this.trkbrSpeed.Location = new System.Drawing.Point(190, 162);
            this.trkbrSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trkbrSpeed.Maximum = 4;
            this.trkbrSpeed.Name = "trkbrSpeed";
            this.trkbrSpeed.Size = new System.Drawing.Size(181, 45);
            this.trkbrSpeed.TabIndex = 5;
            this.trkbrSpeed.Scroll += new System.EventHandler(this.trkbrSpeed_Scroll);
            // 
            // btnReverse
            // 
            this.btnReverse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReverse.BackColor = System.Drawing.Color.Gray;
            this.btnReverse.BackgroundImage = global::AttractieCommunicatie.Properties.Resources.arrow;
            this.btnReverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReverse.Enabled = false;
            this.btnReverse.Location = new System.Drawing.Point(416, 118);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(39, 42);
            this.btnReverse.TabIndex = 6;
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.Red;
            this.btnPower.BackgroundImage = global::AttractieCommunicatie.Properties.Resources.switch_on_icon;
            this.btnPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPower.Location = new System.Drawing.Point(9, 10);
            this.btnPower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(50, 50);
            this.btnPower.TabIndex = 4;
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // lblReverse
            // 
            this.lblReverse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReverse.AutoSize = true;
            this.lblReverse.Enabled = false;
            this.lblReverse.Location = new System.Drawing.Point(413, 102);
            this.lblReverse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReverse.Name = "lblReverse";
            this.lblReverse.Size = new System.Drawing.Size(49, 13);
            this.lblReverse.TabIndex = 7;
            this.lblReverse.Text = "Draai om";
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(10, 74);
            this.cbPorts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(92, 21);
            this.cbPorts.TabIndex = 8;
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // serialPortArduino
            // 
            this.serialPortArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortArduino_DataReceived);
            // 
            // tmrSend
            // 
            this.tmrSend.Interval = 500;
            this.tmrSend.Tick += new System.EventHandler(this.tmrSend_Tick);
            // 
            // lblPower
            // 
            this.lblPower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPower.AutoSize = true;
            this.lblPower.Enabled = false;
            this.lblPower.Location = new System.Drawing.Point(194, 96);
            this.lblPower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(40, 13);
            this.lblPower.TabIndex = 9;
            this.lblPower.Text = "Power:";
            // 
            // pbPower
            // 
            this.pbPower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPower.Enabled = false;
            this.pbPower.Location = new System.Drawing.Point(196, 75);
            this.pbPower.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPower.Name = "pbPower";
            this.pbPower.Size = new System.Drawing.Size(112, 19);
            this.pbPower.TabIndex = 10;
            // 
            // btnSnel
            // 
            this.btnSnel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSnel.Location = new System.Drawing.Point(11, 17);
            this.btnSnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSnel.Name = "btnSnel";
            this.btnSnel.Size = new System.Drawing.Size(43, 47);
            this.btnSnel.TabIndex = 11;
            this.btnSnel.Text = "Snel";
            this.btnSnel.UseVisualStyleBackColor = true;
            this.btnSnel.Click += new System.EventHandler(this.btnSnel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(68, 17);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(43, 47);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpbxSoundboard
            // 
            this.grpbxSoundboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpbxSoundboard.Controls.Add(this.btnSnel);
            this.grpbxSoundboard.Controls.Add(this.btnStart);
            this.grpbxSoundboard.Enabled = false;
            this.grpbxSoundboard.Location = new System.Drawing.Point(196, 245);
            this.grpbxSoundboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxSoundboard.Name = "grpbxSoundboard";
            this.grpbxSoundboard.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxSoundboard.Size = new System.Drawing.Size(126, 80);
            this.grpbxSoundboard.TabIndex = 14;
            this.grpbxSoundboard.TabStop = false;
            this.grpbxSoundboard.Text = "Soundboard:";
            // 
            // tmrRecieve
            // 
            this.tmrRecieve.Tick += new System.EventHandler(this.tmrRecieve_Tick);
            // 
            // btnTerug
            // 
            this.btnTerug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTerug.Location = new System.Drawing.Point(612, 348);
            this.btnTerug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(78, 32);
            this.btnTerug.TabIndex = 16;
            this.btnTerug.Text = "Loguit";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // pbBatterij
            // 
            this.pbBatterij.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBatterij.Location = new System.Drawing.Point(380, 302);
            this.pbBatterij.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbBatterij.Name = "pbBatterij";
            this.pbBatterij.Size = new System.Drawing.Size(241, 23);
            this.pbBatterij.TabIndex = 17;
            // 
            // lblBatterij
            // 
            this.lblBatterij.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBatterij.AutoSize = true;
            this.lblBatterij.Location = new System.Drawing.Point(582, 286);
            this.lblBatterij.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatterij.Name = "lblBatterij";
            this.lblBatterij.Size = new System.Drawing.Size(39, 13);
            this.lblBatterij.TabIndex = 18;
            this.lblBatterij.Text = "Batterij";
            // 
            // tmrBattery
            // 
            this.tmrBattery.Enabled = true;
            this.tmrBattery.Interval = 1000;
            this.tmrBattery.Tick += new System.EventHandler(this.tmrBattery_Tick);
            // 
            // tmrUpdateGUI
            // 
            this.tmrUpdateGUI.Tick += new System.EventHandler(this.tmrUpdateGUI_Tick);
            // 
            // frmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 391);
            this.Controls.Add(this.lblBatterij);
            this.Controls.Add(this.pbBatterij);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.grpbxSoundboard);
            this.Controls.Add(this.pbPower);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.lblReverse);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.trkbrSpeed);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.lblSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmControlPanel";
            this.Text = "Control Panel";
            this.Load += new System.EventHandler(this.frmControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkbrSpeed)).EndInit();
            this.grpbxSoundboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.TrackBar trkbrSpeed;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label lblReverse;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.IO.Ports.SerialPort serialPortArduino;
        private System.Windows.Forms.Timer tmrSend;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.ProgressBar pbPower;
        private System.Windows.Forms.Button btnSnel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpbxSoundboard;
        private System.Windows.Forms.Timer tmrRecieve;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.ProgressBar pbBatterij;
        private System.Windows.Forms.Label lblBatterij;
        private System.Windows.Forms.Timer tmrBattery;
        private System.Windows.Forms.Timer tmrUpdateGUI;
    }
}

