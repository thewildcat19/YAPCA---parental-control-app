using System.Diagnostics;
using System.Security;
using System.Windows.Forms;

namespace YAPCA;

public class AppChecker
{
    private static bool _gameAppsBlockedNotified = false;
    private static bool _gamesUnlockedNotified = false;

    public static void Check(string appName, TrayNotificationService notificationService)
    {
        if (ConfigManager.Config.EducationalTime >= ConfigManager.Config.EducationalLimit && !_gamesUnlockedNotified)
        {
            notificationService.ShowNotification(
                "Game Apps Unlocked",
                "You have completed your educational time limit. Game apps are now unlocked.",
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
                        "Game Apps Blocked",
                        "Game apps are blocked until you finish your educational time (" + ((ConfigManager.Config.EducationalLimit - ConfigManager.Config.EducationalTime) / 60) + ") min",
                        ToolTipIcon.Warning
                    );
                    _gameAppsBlockedNotified = true;
                    AppKiller.CloseApp(appName);
                }
            }

            else if((ConfigManager.Config.GameTime > ConfigManager.Config.GameLimit) && ConfigManager.Config.IsKilling)
            {
                notificationService.ShowNotification("Game time limit exceeded",
                    $"You`ve exceeded your time limit for games ({ConfigManager.Config.GameLimit / 60} minutes)",
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
    }
}