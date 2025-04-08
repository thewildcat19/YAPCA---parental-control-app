namespace YAPCA
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            trayIcon = new NotifyIcon(components);
            trayMenu = new ContextMenuStrip(components);
            KillAllGamesButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tabControl1 = new TabControl();
            InfoTab = new TabPage();
            label5 = new Label();
            SettingsTab = new TabPage();
            LanguageCombo = new ComboBox();
            LanguageLabel = new Label();
            pictureBox1 = new PictureBox();
            GameAppLimitLabel = new Label();
            EduAppLimitLabel = new Label();
            AppKillingCheckBox = new CheckBox();
            ChangePasswordButton = new Button();
            LabelPassword = new Label();
            textBox1 = new TextBox();
            listBox2 = new ListBox();
            numericUpDown1 = new NumericUpDown();
            DeleteGameAppButton = new Button();
            numericUpDown2 = new NumericUpDown();
            listBox1 = new ListBox();
            AddGameAppButton = new Button();
            AddEduAppButton = new Button();
            DeleteEduAppButton = new Button();
            SetLimitButton = new Button();
            tabControl1.SuspendLayout();
            InfoTab.SuspendLayout();
            SettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // trayIcon
            // 
            trayIcon.ContextMenuStrip = trayMenu;
            trayIcon.Icon = (Icon)resources.GetObject("trayIcon.Icon");
            trayIcon.Text = "Time Control";
            trayIcon.Visible = true;
            // 
            // trayMenu
            // 
            trayMenu.Name = "contextMenuStrip1";
            trayMenu.Size = new Size(61, 4);
            // 
            // KillAllGamesButton
            // 
            KillAllGamesButton.Location = new Point(11, 365);
            KillAllGamesButton.Name = "KillAllGamesButton";
            KillAllGamesButton.Size = new Size(110, 46);
            KillAllGamesButton.TabIndex = 1;
            KillAllGamesButton.Text = "Kill all game apps";
            KillAllGamesButton.UseVisualStyleBackColor = true;
            KillAllGamesButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 26);
            label1.Name = "label1";
            label1.Size = new Size(38, 16);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 70);
            label2.Name = "label2";
            label2.Size = new Size(40, 16);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 113);
            label3.Name = "label3";
            label3.Size = new Size(40, 16);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 161);
            label4.Name = "label4";
            label4.Size = new Size(40, 16);
            label4.TabIndex = 14;
            label4.Text = "label4";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(InfoTab);
            tabControl1.Controls.Add(SettingsTab);
            tabControl1.Location = new Point(12, 13);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(827, 448);
            tabControl1.TabIndex = 15;
            // 
            // InfoTab
            // 
            InfoTab.Controls.Add(label5);
            InfoTab.Controls.Add(KillAllGamesButton);
            InfoTab.Controls.Add(label4);
            InfoTab.Controls.Add(label1);
            InfoTab.Controls.Add(label2);
            InfoTab.Controls.Add(label3);
            InfoTab.Location = new Point(4, 25);
            InfoTab.Name = "InfoTab";
            InfoTab.Padding = new Padding(3);
            InfoTab.Size = new Size(819, 419);
            InfoTab.TabIndex = 0;
            InfoTab.Text = "Info";
            InfoTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 203);
            label5.Name = "label5";
            label5.Size = new Size(40, 16);
            label5.TabIndex = 15;
            label5.Text = "label5";
            // 
            // SettingsTab
            // 
            SettingsTab.Controls.Add(LanguageCombo);
            SettingsTab.Controls.Add(LanguageLabel);
            SettingsTab.Controls.Add(pictureBox1);
            SettingsTab.Controls.Add(GameAppLimitLabel);
            SettingsTab.Controls.Add(EduAppLimitLabel);
            SettingsTab.Controls.Add(AppKillingCheckBox);
            SettingsTab.Controls.Add(ChangePasswordButton);
            SettingsTab.Controls.Add(LabelPassword);
            SettingsTab.Controls.Add(textBox1);
            SettingsTab.Controls.Add(listBox2);
            SettingsTab.Controls.Add(numericUpDown1);
            SettingsTab.Controls.Add(DeleteGameAppButton);
            SettingsTab.Controls.Add(numericUpDown2);
            SettingsTab.Controls.Add(listBox1);
            SettingsTab.Controls.Add(AddGameAppButton);
            SettingsTab.Controls.Add(AddEduAppButton);
            SettingsTab.Controls.Add(DeleteEduAppButton);
            SettingsTab.Controls.Add(SetLimitButton);
            SettingsTab.Location = new Point(4, 25);
            SettingsTab.Name = "SettingsTab";
            SettingsTab.Padding = new Padding(3);
            SettingsTab.Size = new Size(819, 419);
            SettingsTab.TabIndex = 1;
            SettingsTab.Text = "Settings";
            SettingsTab.UseVisualStyleBackColor = true;
            // 
            // LanguageCombo
            // 
            LanguageCombo.FormattingEnabled = true;
            LanguageCombo.Items.AddRange(new object[] { "en", "ru" });
            LanguageCombo.Location = new Point(6, 177);
            LanguageCombo.Name = "LanguageCombo";
            LanguageCombo.Size = new Size(121, 24);
            LanguageCombo.TabIndex = 21;
            LanguageCombo.SelectedIndexChanged += LanguageCombo_SelectedIndexChanged;
            // 
            // LanguageLabel
            // 
            LanguageLabel.AutoSize = true;
            LanguageLabel.Location = new Point(6, 158);
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.Size = new Size(63, 16);
            LanguageLabel.TabIndex = 20;
            LanguageLabel.Text = "Language:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // GameAppLimitLabel
            // 
            GameAppLimitLabel.AutoSize = true;
            GameAppLimitLabel.Location = new Point(593, 253);
            GameAppLimitLabel.MaximumSize = new Size(189, 0);
            GameAppLimitLabel.Name = "GameAppLimitLabel";
            GameAppLimitLabel.Size = new Size(94, 16);
            GameAppLimitLabel.TabIndex = 19;
            GameAppLimitLabel.Text = "Game apps limit";
            // 
            // EduAppLimitLabel
            // 
            EduAppLimitLabel.AutoSize = true;
            EduAppLimitLabel.Location = new Point(356, 253);
            EduAppLimitLabel.MaximumSize = new Size(189, 0);
            EduAppLimitLabel.Name = "EduAppLimitLabel";
            EduAppLimitLabel.Size = new Size(115, 16);
            EduAppLimitLabel.TabIndex = 18;
            EduAppLimitLabel.Text = "Education apps limit";
            // 
            // AppKillingCheckBox
            // 
            AppKillingCheckBox.BackColor = Color.Transparent;
            AppKillingCheckBox.Location = new Point(6, 371);
            AppKillingCheckBox.Name = "AppKillingCheckBox";
            AppKillingCheckBox.Size = new Size(162, 39);
            AppKillingCheckBox.TabIndex = 17;
            AppKillingCheckBox.Text = "App killing";
            AppKillingCheckBox.UseVisualStyleBackColor = false;
            AppKillingCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ChangePasswordButton
            // 
            ChangePasswordButton.Location = new Point(6, 85);
            ChangePasswordButton.Name = "ChangePasswordButton";
            ChangePasswordButton.Size = new Size(71, 43);
            ChangePasswordButton.TabIndex = 16;
            ChangePasswordButton.Text = "Change password";
            ChangePasswordButton.UseVisualStyleBackColor = true;
            ChangePasswordButton.Click += button7_Click;
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(6, 26);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(60, 16);
            LabelPassword.TabIndex = 15;
            LabelPassword.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            textBox1.UseSystemPasswordChar = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 16;
            listBox2.Location = new Point(356, 3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(220, 132);
            listBox2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(593, 296);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(189, 23);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // DeleteGameAppButton
            // 
            DeleteGameAppButton.Location = new Point(593, 141);
            DeleteGameAppButton.Name = "DeleteGameAppButton";
            DeleteGameAppButton.Size = new Size(109, 60);
            DeleteGameAppButton.TabIndex = 6;
            DeleteGameAppButton.Text = "Delete game app";
            DeleteGameAppButton.UseVisualStyleBackColor = true;
            DeleteGameAppButton.Click += button3_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(356, 296);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(189, 23);
            numericUpDown2.TabIndex = 12;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Location = new Point(593, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 132);
            listBox1.TabIndex = 2;
            // 
            // AddGameAppButton
            // 
            AddGameAppButton.Location = new Point(708, 141);
            AddGameAppButton.Name = "AddGameAppButton";
            AddGameAppButton.Size = new Size(102, 60);
            AddGameAppButton.TabIndex = 3;
            AddGameAppButton.Text = "Add game app";
            AddGameAppButton.UseVisualStyleBackColor = true;
            AddGameAppButton.Click += button2_Click;
            // 
            // AddEduAppButton
            // 
            AddEduAppButton.Location = new Point(469, 141);
            AddEduAppButton.Name = "AddEduAppButton";
            AddEduAppButton.Size = new Size(107, 60);
            AddEduAppButton.TabIndex = 8;
            AddEduAppButton.Text = "Add edu app";
            AddEduAppButton.UseVisualStyleBackColor = true;
            AddEduAppButton.Click += button5_Click;
            // 
            // DeleteEduAppButton
            // 
            DeleteEduAppButton.Location = new Point(356, 141);
            DeleteEduAppButton.Name = "DeleteEduAppButton";
            DeleteEduAppButton.Size = new Size(107, 60);
            DeleteEduAppButton.TabIndex = 9;
            DeleteEduAppButton.Text = "Delete edu app";
            DeleteEduAppButton.UseVisualStyleBackColor = true;
            DeleteEduAppButton.Click += button4_Click;
            // 
            // SetLimitButton
            // 
            SetLimitButton.Location = new Point(529, 354);
            SetLimitButton.Name = "SetLimitButton";
            SetLimitButton.Size = new Size(79, 56);
            SetLimitButton.TabIndex = 13;
            SetLimitButton.Text = "Set limits";
            SetLimitButton.UseVisualStyleBackColor = true;
            SetLimitButton.Click += button6_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 487);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "YAPCA";
            FormClosing += MainWindow_FormClosing;
            tabControl1.ResumeLayout(false);
            InfoTab.ResumeLayout(false);
            InfoTab.PerformLayout();
            SettingsTab.ResumeLayout(false);
            SettingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;
        private Button KillAllGamesButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TabControl tabControl1;
        private TabPage InfoTab;
        private TabPage SettingsTab;
        private Button SetLimitButton;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button AddGameAppButton;
        private Button DeleteGameAppButton;
        private Button AddEduAppButton;
        private Button DeleteEduAppButton;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label5;
        private Label LabelPassword;
        private TextBox textBox1;
        private Button ChangePasswordButton;
        private CheckBox AppKillingCheckBox;
        private Label GameAppLimitLabel;
        private Label EduAppLimitLabel;
        private PictureBox pictureBox1;
        private Label LanguageLabel;
        private ComboBox LanguageCombo;
    }
}
