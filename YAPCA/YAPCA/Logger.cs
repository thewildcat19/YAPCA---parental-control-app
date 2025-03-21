namespace YAPCA;

public class Logger
{
    public static void LogGame(string activeWindow)
    {
        var config = ConfigManager.Config;
        config.GameTime += 10;
        ConfigManager.SaveConfig();
    }
    public static void LogEducation(string activeWindow)
    {
        var config = ConfigManager.Config;
        config.EducationalTime += 10;
        ConfigManager.SaveConfig();
    }
}