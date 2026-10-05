namespace SerialExample
{
    partial class SerialForm
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
            components = new System.ComponentModel.Container();
            ExitButton = new Button();
            ConnectButton = new Button();
            ReadButton = new Button();
            WriteButton = new Button();
            SerialTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            StatusStrip = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            StatusTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            PortsComboBox = new ComboBox();
            ComListBox = new ListBox();
            OutputTextBox = new TextBox();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(685, 371);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(103, 54);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(585, 372);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(94, 53);
            ConnectButton.TabIndex = 1;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(485, 372);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(94, 53);
            ReadButton.TabIndex = 2;
            ReadButton.Text = "Read";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // WriteButton
            // 
            WriteButton.Location = new Point(385, 372);
            WriteButton.Name = "WriteButton";
            WriteButton.Size = new Size(94, 53);
            WriteButton.TabIndex = 3;
            WriteButton.Text = "Write";
            WriteButton.UseVisualStyleBackColor = true;
            WriteButton.Click += WriteButton_Click;
            // 
            // SerialTextBox
            // 
            SerialTextBox.Location = new Point(12, 46);
            SerialTextBox.Name = "SerialTextBox";
            SerialTextBox.Size = new Size(151, 27);
            SerialTextBox.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(20, 20);
            StatusStrip.Items.AddRange(new ToolStripItem[] { StatusLabel });
            StatusStrip.Location = new Point(0, 424);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(800, 26);
            StatusStrip.TabIndex = 6;
            StatusStrip.Text = "statusStrip1";
            StatusStrip.ItemClicked += StatusStrip_ItemClicked;
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(85, 20);
            StatusLabel.Text = "StatusLabel";
            // 
            // StatusTimer
            // 
            StatusTimer.Enabled = true;
            StatusTimer.Interval = 250;
            StatusTimer.Tick += StatusTimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 315);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            // 
            // PortsComboBox
            // 
            PortsComboBox.FormattingEnabled = true;
            PortsComboBox.Location = new Point(12, 12);
            PortsComboBox.Name = "PortsComboBox";
            PortsComboBox.Size = new Size(151, 28);
            PortsComboBox.TabIndex = 8;
            // 
            // ComListBox
            // 
            ComListBox.FormattingEnabled = true;
            ComListBox.Location = new Point(169, 12);
            ComListBox.Name = "ComListBox";
            ComListBox.Size = new Size(619, 344);
            ComListBox.TabIndex = 9;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new Point(12, 329);
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.Size = new Size(151, 27);
            OutputTextBox.TabIndex = 10;
            // 
            // SerialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputTextBox);
            Controls.Add(ComListBox);
            Controls.Add(PortsComboBox);
            Controls.Add(label1);
            Controls.Add(StatusStrip);
            Controls.Add(SerialTextBox);
            Controls.Add(WriteButton);
            Controls.Add(ReadButton);
            Controls.Add(ConnectButton);
            Controls.Add(ExitButton);
            Name = "SerialForm";
            Text = "Form1";
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button ConnectButton;
        private Button ReadButton;
        private Button WriteButton;
        private TextBox SerialTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private StatusStrip StatusStrip;
        private System.Windows.Forms.Timer StatusTimer;
        private Label label1;
        private ComboBox PortsComboBox;
        private ToolStripStatusLabel StatusLabel;
        private ListBox ComListBox;
        private TextBox OutputTextBox;
    }
}
