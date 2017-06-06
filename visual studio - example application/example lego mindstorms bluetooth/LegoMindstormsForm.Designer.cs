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
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputlistBox = new System.Windows.Forms.ListBox();
            this.connectionGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.disconnectButton);
            this.connectionGroupBox.Controls.Add(this.connectButton);
            this.connectionGroupBox.Controls.Add(this.refreshButton);
            this.connectionGroupBox.Controls.Add(this.label1);
            this.connectionGroupBox.Controls.Add(this.portListBox);
            this.connectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Size = new System.Drawing.Size(406, 131);
            this.connectionGroupBox.TabIndex = 4;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Location = new System.Drawing.Point(275, 93);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(120, 23);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(275, 64);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(120, 23);
            this.connectButton.TabIndex = 8;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(275, 35);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(120, 23);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Referesh ports";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port for blutooth connection";
            // 
            // portListBox
            // 
            this.portListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portListBox.FormattingEnabled = true;
            this.portListBox.Location = new System.Drawing.Point(9, 35);
            this.portListBox.Name = "portListBox";
            this.portListBox.Size = new System.Drawing.Size(260, 82);
            this.portListBox.TabIndex = 5;
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.labelInstructions);
            this.inputGroupBox.Controls.Add(this.inputTextBox);
            this.inputGroupBox.Controls.Add(this.inputButton);
            this.inputGroupBox.Enabled = false;
            this.inputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGroupBox.Location = new System.Drawing.Point(12, 151);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(200, 143);
            this.inputGroupBox.TabIndex = 5;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // labelInstructions
            // 
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(9, 19);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(184, 63);
            this.labelInstructions.TabIndex = 4;
            this.labelInstructions.Text = "Via this form you can send a message to the Brick. The message will be saved and " +
    "can be retrieved via the Output form.";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(9, 81);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(184, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputButton.Location = new System.Drawing.Point(9, 111);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(184, 23);
            this.inputButton.TabIndex = 0;
            this.inputButton.Text = "Send message";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.outputButton);
            this.outputGroupBox.Controls.Add(this.outputlistBox);
            this.outputGroupBox.Enabled = false;
            this.outputGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputGroupBox.Location = new System.Drawing.Point(218, 151);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(200, 143);
            this.outputGroupBox.TabIndex = 6;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // outputButton
            // 
            this.outputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButton.Location = new System.Drawing.Point(6, 111);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(187, 23);
            this.outputButton.TabIndex = 0;
            this.outputButton.Text = "Read message";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputlistBox
            // 
            this.outputlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlistBox.FormattingEnabled = true;
            this.outputlistBox.Location = new System.Drawing.Point(7, 19);
            this.outputlistBox.Name = "outputlistBox";
            this.outputlistBox.Size = new System.Drawing.Size(187, 82);
            this.outputlistBox.TabIndex = 4;
            // 
            // LegoMindstormsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 304);
            this.Controls.Add(this.connectionGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.outputGroupBox);
            this.Name = "LegoMindstormsForm";
            this.Text = "Example Lego Mindstorms Bluetooth";
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox portListBox;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.ListBox outputlistBox;
    }
}

