namespace tteset1
{
    partial class HomePage
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
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            richTextBox2 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            richTextBox1.Location = new Point(448, 263);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(340, 138);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pic1;
            pictureBox1.Location = new Point(28, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(659, 407);
            button1.Name = "button1";
            button1.Size = new Size(120, 39);
            button1.TabIndex = 4;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(309, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 38);
            label1.TabIndex = 5;
            label1.Text = "Welcome Again!";
            // 
            // richTextBox2
            // 
            richTextBox2.Enabled = false;
            richTextBox2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBox2.Location = new Point(28, 228);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(275, 109);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Name = "HomePage";
            Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private RichTextBox richTextBox2;
    }
}