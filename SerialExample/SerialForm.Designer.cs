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
            statusStrip1 = new StatusStrip();
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
            SerialTextBox.Location = new Point(385, 118);
            SerialTextBox.Name = "SerialTextBox";
            SerialTextBox.Size = new Size(294, 27);
            SerialTextBox.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 24);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // SerialForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(SerialTextBox);
            Controls.Add(WriteButton);
            Controls.Add(ReadButton);
            Controls.Add(ConnectButton);
            Controls.Add(ExitButton);
            Name = "SerialForm";
            Text = "Form1";
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
        private StatusStrip statusStrip1;
    }
}
