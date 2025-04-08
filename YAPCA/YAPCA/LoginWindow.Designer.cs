namespace YAPCA
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            textBox1 = new TextBox();
            LoginButton = new Button();
            LabelPasswordLogin = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 0;
            textBox1.UseSystemPasswordChar = true;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(142, 69);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 25);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += button1_Click;
            // 
            // LabelPasswordLogin
            // 
            LabelPasswordLogin.AutoSize = true;
            LabelPasswordLogin.Location = new Point(29, 19);
            LabelPasswordLogin.Name = "LabelPasswordLogin";
            LabelPasswordLogin.Size = new Size(38, 16);
            LabelPasswordLogin.TabIndex = 2;
            LabelPasswordLogin.Text = "Enter ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(297, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 114);
            Controls.Add(pictureBox1);
            Controls.Add(LabelPasswordLogin);
            Controls.Add(LoginButton);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginWindow";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button LoginButton;
        private Label LabelPasswordLogin;
        private PictureBox pictureBox1;
    }
}