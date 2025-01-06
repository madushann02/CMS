namespace Madu
{
    partial class AdminDashboard
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
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 33);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(1046, 4);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 543);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.administrator;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(52, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 94);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = SystemColors.Highlight;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(0, 313);
            button4.Name = "button4";
            button4.Size = new Size(233, 43);
            button4.TabIndex = 2;
            button4.Text = "View Orders";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = SystemColors.Highlight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 255);
            button3.Name = "button3";
            button3.Size = new Size(233, 43);
            button3.TabIndex = 1;
            button3.Text = "Driver Mangement";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 194);
            button2.Name = "button2";
            button2.Size = new Size(233, 43);
            button2.TabIndex = 0;
            button2.Text = "Car Management";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(233, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 543);
            panel3.TabIndex = 2;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = SystemColors.Highlight;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(0, 500);
            button5.Name = "button5";
            button5.Size = new Size(233, 43);
            button5.TabIndex = 4;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 576);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button5;
    }
}