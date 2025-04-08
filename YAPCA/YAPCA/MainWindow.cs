using System.Diagnostics;
using YAPCA.res;
using Timer = System.Windows.Forms.Timer;

namespace YAPCA
{
    public partial class MainWindow : Form
    {
        private Timer _timer_fast;
        private Timer _timer_long;
        //  private NotifyIcon trayIcon;
        private TrayNotificationService _NotificationService;
        private bool _isInitializing = true;

        public MainWindow()
        {
            InitializeComponent();
            LocalizationManager.SetLanguage(ConfigManager.Config.Lang);
            LocalizationManager.LocalizeUiElements(this);

            // Синхронизируем язык в комбинированном списке
            LanguageCombo.SelectedItem = ConfigManager.Config.Lang;

            _isInitializing = false; // После инициализации можно обработать изменения

            UpdateInfo(this, EventArgs.Empty);
            DateChecker.Check(this, EventArgs.Empty);
            _NotificationService = new TrayNotificationService(trayIcon);
            trayMenu.Items.Add(Resources.OpenTrayMenu, null, ShowMainWindow);
            trayMenu.Items.Add(Resources.ExitTrayMenu, null, ExitApp);
            AppKillingCheckBox.Checked = ConfigManager.Config.IsKilling;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Hide();
            numericUpDown1.Value = ConfigManager.Config.GameLimit / 60;
            numericUpDown2.Value = ConfigManager.Config.EducationalLimit / 60;
            textBox1.Text = ConfigManager.Config.Password;
            foreach (var elem in ConfigManager.Config.GameApps)
            {
                listBox1.Items.Add(elem);
            }
            foreach (var elem in ConfigManager.Config.EducationalApps)
            {
                listBox2.Items.Add(elem);
            }
            _timer_fast = new Timer();
            _timer_fast.Interval = 10000;
            _timer_fast.Tick += UpdateInfo;
            _timer_fast.Start();

            _timer_long = new Timer();
            _timer_long.Interval = 300000;
            _timer_long.Tick += DateChecker.Check;
            _timer_long.Start();
            WindowTracker.StartTracking(_NotificationService);
           
        }

        private void ShowMainWindow(object? sender, EventArgs e)
        {
            if (Password.CheckPassword())
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                //  trayIcon.Visible=false;
            }

            //without password
            //this.Show();
            //this.WindowState = FormWindowState.Normal;
            //this.ShowInTaskbar = true;
            //  trayIcon.Visible=false;
        }

        private void ExitApp(object sender, EventArgs e)
        {
            if (Password.CheckPassword())
            {
                trayIcon.Dispose();
                //  Application.Exit();
                Environment.Exit(0);
            }

            //without password
            //trayIcon.Dispose();
            //Application.Exit();
            //Environment.Exit(0);
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                trayIcon.Visible = true;
            }
            else
            {
                base.OnFormClosing(e);
            }
        }

        private void CloseApp(IEnumerable<string> appName)
        {
            var processes = appName.SelectMany(name => Process.GetProcessesByName(name)).ToList();
            processes.ForEach(processes => processes.Kill());
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            string activeWindow = WindowTracker.GetActiveWindowProcessName();
            label1.Text = string.Format(Resources.MainWindow_UpdateInfo_Game_apps__used_time, ((ConfigManager.Config.GameTime / 60.0).ToString("F2")));
            label2.Text = string.Format(Resources.MainWindow_UpdateInfo_Education_apps_used_time, (ConfigManager.Config.EducationalTime / 60.0).ToString("F2"));
            label3.Text = string.Format(Resources.MainWindow_UpdateInfo_Active_Window, activeWindow);
            label4.Text = string.Format(Resources.MainWindow_UpdateInfo_Are_games_unlocked, ConfigManager.Config.AreGamesUnlocked);
            label5.Text = string.Format(Resources.MainWindow_UpdateInfo_System_Date, ConfigManager.Config.Date);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                var items = listBox1.Items.Cast<string>();
                CloseApp(items);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable files (*.exe)|*.exe";
                openFileDialog.Title = "Pick exe file";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    if (!listBox1.Items.Contains(fileName))
                    {
                        listBox1.Items.Add(fileName);
                        ConfigManager.Config.GameApps.Add(fileName);
                        ConfigManager.SaveConfig();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                ConfigManager.Config.GameApps.Remove(listBox1.SelectedItem.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem);
                ConfigManager.SaveConfig();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                ConfigManager.Config.EducationalApps.Remove(listBox2.SelectedItem.ToString());
                listBox2.Items.Remove(listBox2.SelectedItem);
                ConfigManager.SaveConfig();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable files (*.exe)|*.exe";
                openFileDialog.Title = "Pick exe file";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    if (!listBox2.Items.Contains(fileName))
                    {
                        listBox2.Items.Add(fileName);
                        ConfigManager.Config.EducationalApps.Add(fileName);
                        ConfigManager.SaveConfig();
                    }
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConfigManager.Config.GameLimit = ((int)numericUpDown1.Value) * 60;
            ConfigManager.Config.EducationalLimit = ((int)numericUpDown2.Value) * 60;
            _NotificationService.ShowNotification(
                Resources.LimitsChanged_Title,
                string.Format(Resources.LimitsChanged_Text, ConfigManager.Config.GameLimit / 60, ConfigManager.Config.EducationalLimit / 60), 
                ToolTipIcon.Warning);
            ConfigManager.SaveConfig();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ConfigManager.Config.Password = textBox1.Text;
            _NotificationService.ShowNotification(
                "",
                Resources.PasswordChanged,
                ToolTipIcon.Info
                );
            ConfigManager.SaveConfig();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ConfigManager.Config.IsKilling = AppKillingCheckBox.Checked;
            ConfigManager.SaveConfig();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void LanguageCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return; 

            if (LanguageCombo.SelectedItem != null)
            {
                string selectedLang = LanguageCombo.SelectedItem.ToString();
                if (selectedLang != ConfigManager.Config.Lang)
                {
                    ConfigManager.Config.Lang = selectedLang;
                    ConfigManager.SaveConfig();
                    LocalizationManager.SetLanguage(selectedLang);
                    LocalizationManager.LocalizeUiElements(this);
                    Application.Restart(); 
                }
            }
        }
    }

}
