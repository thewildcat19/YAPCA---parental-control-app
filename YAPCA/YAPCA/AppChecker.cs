using System.Diagnostics;
using System.Security;
using System.Windows.Forms;
using YAPCA.res;

namespace YAPCA;

public class AppChecker
{
    private static bool _gameAppsBlockedNotified = false;
    private static bool _gamesUnlockedNotified = ConfigManager.Config.AreGamesUnlocked ? true : false;


    public static void Check(string appName, TrayNotificationService notificationService)
    {
        if (ConfigManager.Config.EducationalTime >= ConfigManager.Config.EducationalLimit && !_gamesUnlockedNotified && ConfigManager.Config.GameTime < ConfigManager.Config.GameLimit)
        {
            notificationService.ShowNotification(
                Resources.GameAppsUnlocked_Title,
                Resources.GameAppsUnlocked_Text,
                ToolTipIcon.Info
            );
            _gamesUnlockedNotified = true;
            ConfigManager.Config.AreGamesUnlocked = true;
        }
        else if (ConfigManager.Config.EducationalTime < ConfigManager.Config.EducationalLimit)
        {
            ConfigManager.Config.AreGamesUnlocked = false;
            _gamesUnlockedNotified = false;
        }


        if (ConfigManager.Config.GameApps.Any(app => appName.Contains(app)))
        {
            if ((ConfigManager.Config.GameTime < ConfigManager.Config.GameLimit )&& ConfigManager.Config.IsKilling)
            {
                if (ConfigManager.Config.AreGamesUnlocked)
                {
                    Logger.LogGame(appName);
                }
                else if (!ConfigManager.Config.AreGamesUnlocked)
                {
                    notificationService.ShowNotification(
                        Resources.GameAppsBlocked_Title,
                        string.Format(Resources.GameAppsBlocked_Text, ((ConfigManager.Config.EducationalLimit - ConfigManager.Config.EducationalTime) / 60)),
                        ToolTipIcon.Warning
                    );
                    _gameAppsBlockedNotified = true;
                    AppKiller.CloseApp(appName);
                }
            }

            if((ConfigManager.Config.GameTime >= ConfigManager.Config.GameLimit) && ConfigManager.Config.IsKilling)
            {
                notificationService.ShowNotification(Resources.GameTimeLimit_Title,
                    string.Format(Resources.GameTimeLimit_Text, ConfigManager.Config.GameLimit / 60),
                    ToolTipIcon.Warning);
                _gameAppsBlockedNotified = false;
                AppKiller.CloseApp(appName);

            }
        }

        else if (ConfigManager.Config.EducationalApps.Any(app => appName.Contains(app)))
        {
            if (ConfigManager.Config.EducationalTime < ConfigManager.Config.EducationalLimit)
            {
                Logger.LogEducation(appName);
            }
            else
            {
                Logger.LogEducation(appName);
            }
        }

        if (ConfigManager.Config.GameTime >= ConfigManager.Config.GameLimit)
        {
            ConfigManager.Config.AreGamesUnlocked = false;
        }
    }
}