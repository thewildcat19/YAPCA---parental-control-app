namespace YAPCA;

public class DateChecker
{
    public static void Check(object sender, EventArgs e)
    {

        if (ConfigManager.Config.Date != DateTime.Today)
        {
            ResetDate();
        }
    }

    public static void ResetDate()
    {
        ConfigManager.Config.Date = DateTime.Today;
        ConfigManager.Config.EducationalTime = 0;
        ConfigManager.Config.GameTime = 0;
        ConfigManager.Config.AreGamesUnlocked = false;
        ConfigManager.SaveConfig();
    }

}