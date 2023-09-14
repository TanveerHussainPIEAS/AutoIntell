namespace AutoIntell
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
            button1 = new Button();
            importButton = new Button();
            pictureBox1 = new PictureBox();
            labelWidth = new Label();
            labelHeight = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(146, 31);
            button1.TabIndex = 0;
            button1.Text = "Take a picture";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // importButton
            // 
            importButton.Location = new Point(12, 50);
            importButton.Name = "importButton";
            importButton.Size = new Size(146, 31);
            importButton.TabIndex = 4;
            importButton.Text = "Import Image";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(239, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(821, 476);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(12, 100);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(0, 20);
            labelWidth.TabIndex = 2;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(12, 118);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(0, 20);
            labelHeight.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 613);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(labelWidth);
            Controls.Add(labelHeight);
            Controls.Add(importButton);
            Name = "Form1";
            Text = "AutoIntell";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button importButton;
        private PictureBox pictureBox1;
        private Label labelWidth;
        private Label labelHeight;
    }
}