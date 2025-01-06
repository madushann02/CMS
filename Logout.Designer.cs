namespace Madu
{
    partial class Logout
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 119);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 0;
            label1.Text = "Do you want to Logout";
            // 
            // button1
            // 
            button1.Location = new Point(207, 188);
            button1.Name = "button1";
            button1.Size = new Size(171, 53);
            button1.TabIndex = 1;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(406, 191);
            button2.Name = "button2";
            button2.Size = new Size(171, 53);
            button2.TabIndex = 2;
            button2.Text = "Return to Admin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Logout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Logout";
            Text = "Logout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}