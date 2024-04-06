namespace HatFileTimeConverter
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
            browseButton = new Button();
            fileNameTextBox = new TextBox();
            timeTextBox = new TextBox();
            fileNameLabel = new Label();
            timeLabel = new Label();
            timePreviewLabel = new Label();
            convertButton = new Button();
            SuspendLayout();
            // 
            // browseButton
            // 
            browseButton.Location = new Point(164, 38);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(75, 23);
            browseButton.TabIndex = 0;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Location = new Point(12, 38);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.ReadOnly = true;
            fileNameTextBox.Size = new Size(134, 23);
            fileNameTextBox.TabIndex = 1;
            fileNameTextBox.TextChanged += fileNameTextBox_TextChanged;
            // 
            // timeTextBox
            // 
            timeTextBox.Enabled = false;
            timeTextBox.Location = new Point(12, 102);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.Size = new Size(134, 23);
            timeTextBox.TabIndex = 2;
            timeTextBox.TextChanged += timeTextBox_TextChanged;
            timeTextBox.KeyPress += timeTextBox_KeyPress;
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(12, 20);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(52, 15);
            fileNameLabel.TabIndex = 3;
            fileNameLabel.Text = "Save File";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(12, 84);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(104, 15);
            timeLabel.TabIndex = 4;
            timeLabel.Text = "Time (in decimals)";
            // 
            // timePreviewLabel
            // 
            timePreviewLabel.AutoSize = true;
            timePreviewLabel.Location = new Point(164, 105);
            timePreviewLabel.Name = "timePreviewLabel";
            timePreviewLabel.Size = new Size(0, 15);
            timePreviewLabel.TabIndex = 5;
            // 
            // convertButton
            // 
            convertButton.Enabled = false;
            convertButton.Location = new Point(89, 158);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(75, 23);
            convertButton.TabIndex = 6;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 193);
            Controls.Add(convertButton);
            Controls.Add(timePreviewLabel);
            Controls.Add(timeLabel);
            Controls.Add(fileNameLabel);
            Controls.Add(timeTextBox);
            Controls.Add(fileNameTextBox);
            Controls.Add(browseButton);
            Name = "Form1";
            Text = "Time Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button browseButton;
        private TextBox fileNameTextBox;
        private TextBox timeTextBox;
        private Label fileNameLabel;
        private Label timeLabel;
        private Label timePreviewLabel;
        private Button convertButton;
    }
}
