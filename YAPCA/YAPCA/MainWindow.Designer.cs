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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            tabPage2 = new TabPage();
            checkBox1 = new CheckBox();
            button7 = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            listBox2 = new ListBox();
            numericUpDown1 = new NumericUpDown();
            button3 = new Button();
            numericUpDown2 = new NumericUpDown();
            listBox1 = new ListBox();
            button2 = new Button();
            button5 = new Button();
            button4 = new Button();
            button6 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            // button1
            // 
            button1.Location = new Point(11, 342);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 1;
            button1.Text = "Kill all game apps";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 66);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 106);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 151);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 14;
            label4.Text = "label4";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(827, 420);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(819, 391);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 190);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 15;
            label5.Text = "label5";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(checkBox1);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(listBox2);
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(numericUpDown2);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(button6);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(819, 391);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(6, 360);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 25);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "App killing";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button7
            // 
            button7.Location = new Point(6, 80);
            button7.Name = "button7";
            button7.Size = new Size(71, 40);
            button7.TabIndex = 16;
            button7.Text = "Change password";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 24);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 15;
            label6.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(403, 6);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(189, 124);
            listBox2.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(621, 244);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(189, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(621, 136);
            button3.Name = "button3";
            button3.Size = new Size(75, 40);
            button3.TabIndex = 6;
            button3.Text = "Delete game app";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(403, 244);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(189, 23);
            numericUpDown2.TabIndex = 12;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(621, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(189, 124);
            listBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(735, 136);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 3;
            button2.Text = "Add game app";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(517, 136);
            button5.Name = "button5";
            button5.Size = new Size(75, 40);
            button5.TabIndex = 8;
            button5.Text = "Add edu app";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(403, 136);
            button4.Name = "button4";
            button4.Size = new Size(71, 40);
            button4.TabIndex = 9;
            button4.Text = "Delete edu app";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(574, 320);
            button6.Name = "button6";
            button6.Size = new Size(71, 40);
            button6.TabIndex = 13;
            button6.Text = "Set limits";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 457);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainWindow";
            Text = "YAPCA";
            FormClosing += MainWindow_FormClosing;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button6;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Button button7;
        private CheckBox checkBox1;
    }
}
