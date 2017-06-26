namespace Example_Lego_Mindstorms_Bluetooth
{
    partial class LegoMindstormsForm
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
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portListBox = new System.Windows.Forms.ListBox();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputlistBox = new System.Windows.Forms.ListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnDropOff = new System.Windows.Forms.Button();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxManualFunction = new System.Windows.Forms.GroupBox();
            this.groupBoxAutomationFunction = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.connectionGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxManualFunction.SuspendLayout();
            this.groupBoxAutomationFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.disconnectButton);
            this.connectionGroupBox.Controls.Add(this.connectButton);
            this.connectionGroupBox.Controls.Add(this.refreshButton);
            this.connectionGroupBox.Controls.Add(this.label1);
            this.connectionGroupBox.Controls.Add(this.portListBox);
            this.connectionGroupBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionGroupBox.Location = new System.Drawing.Point(14, 14);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Size = new System.Drawing.Size(474, 151);
            this.connectionGroupBox.TabIndex = 4;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Location = new System.Drawing.Point(321, 107);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(140, 27);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(321, 74);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(140, 27);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(321, 40);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(140, 27);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Referesh ports";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port for blutooth connection";
            // 
            // portListBox
            // 
            this.portListBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portListBox.FormattingEnabled = true;
            this.portListBox.ItemHeight = 15;
            this.portListBox.Location = new System.Drawing.Point(10, 40);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(303, 94);
            this.portListBox.TabIndex = 5;
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputButton);
            this.outputGroupBox.Controls.Add(this.outputlistBox);
            this.outputGroupBox.Enabled = false;
            this.outputGroupBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputGroupBox.Location = new System.Drawing.Point(495, 15);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(474, 348);
            this.outputGroupBox.TabIndex = 6;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // outputButton
            // 
            this.outputButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButton.Location = new System.Drawing.Point(8, 315);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(458, 27);
            this.outputButton.TabIndex = 0;
            this.outputButton.Text = "Read message";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputlistBox
            // 
            this.outputlistBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlistBox.FormattingEnabled = true;
            this.outputlistBox.ItemHeight = 15;
            this.outputlistBox.Location = new System.Drawing.Point(8, 22);
            this.outputlistBox.Name = "outputlistBox";
            this.outputlistBox.Size = new System.Drawing.Size(458, 289);
            this.outputlistBox.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(310, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(140, 27);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStart.Location = new System.Drawing.Point(17, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 25);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseDown);
            this.btnStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStart_MouseUp);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(164, 55);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(140, 27);
            this.btnReverse.TabIndex = 9;
            this.btnReverse.Text = "↓";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(311, 55);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(139, 27);
            this.btnRight.TabIndex = 10;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(17, 55);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(140, 27);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(164, 22);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(140, 27);
            this.btnForward.TabIndex = 12;
            this.btnForward.Text = "↑";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDropOff
            // 
            this.btnDropOff.Location = new System.Drawing.Point(310, 22);
            this.btnDropOff.Name = "btnDropOff";
            this.btnDropOff.Size = new System.Drawing.Size(140, 27);
            this.btnDropOff.TabIndex = 14;
            this.btnDropOff.Text = "drop off";
            this.btnDropOff.UseVisualStyleBackColor = true;
            // 
            // btnPickUp
            // 
            this.btnPickUp.Location = new System.Drawing.Point(17, 22);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(140, 27);
            this.btnPickUp.TabIndex = 15;
            this.btnPickUp.Text = "pick up";
            this.btnPickUp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxManualFunction);
            this.groupBox1.Controls.Add(this.groupBoxAutomationFunction);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 190);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remote Control";
            // 
            // groupBoxManualFunction
            // 
            this.groupBoxManualFunction.Controls.Add(this.btnPickUp);
            this.groupBoxManualFunction.Controls.Add(this.btnDropOff);
            this.groupBoxManualFunction.Controls.Add(this.btnRight);
            this.groupBoxManualFunction.Controls.Add(this.btnLeft);
            this.groupBoxManualFunction.Controls.Add(this.btnForward);
            this.groupBoxManualFunction.Controls.Add(this.btnReverse);
            this.groupBoxManualFunction.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxManualFunction.Location = new System.Drawing.Point(10, 92);
            this.groupBoxManualFunction.Name = "groupBoxManualFunction";
            this.groupBoxManualFunction.Size = new System.Drawing.Size(463, 98);
            this.groupBoxManualFunction.TabIndex = 18;
            this.groupBoxManualFunction.TabStop = false;
            this.groupBoxManualFunction.Text = "Manual Function";
            // 
            // groupBoxAutomationFunction
            // 
            this.groupBoxAutomationFunction.Controls.Add(this.btnStop);
            this.groupBoxAutomationFunction.Controls.Add(this.btnStart);
            this.groupBoxAutomationFunction.Controls.Add(this.btnPause);
            this.groupBoxAutomationFunction.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAutomationFunction.Location = new System.Drawing.Point(10, 22);
            this.groupBoxAutomationFunction.Name = "groupBoxAutomationFunction";
            this.groupBoxAutomationFunction.Size = new System.Drawing.Size(463, 63);
            this.groupBoxAutomationFunction.TabIndex = 17;
            this.groupBoxAutomationFunction.TabStop = false;
            this.groupBoxAutomationFunction.Text = "Automation Function";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(164, 22);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(140, 27);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause ";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.button10_Click);
            // 
            // LegoMindstormsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(974, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connectionGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LegoMindstormsForm";
            this.Text = "Example Lego Mindstorms Bluetooth";
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxManualFunction.ResumeLayout(false);
            this.groupBoxAutomationFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox portListBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.ListBox outputlistBox;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnDropOff;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox groupBoxManualFunction;
        private System.Windows.Forms.GroupBox groupBoxAutomationFunction;
    }
}

