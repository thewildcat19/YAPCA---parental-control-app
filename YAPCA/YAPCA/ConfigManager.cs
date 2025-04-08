namespace YAPCA;

public static class ConfigManager
{
    public static AppConfig Config { get; private set; } = Encryption.LoadConfig();

    public static void SaveConfig()
    {
        Encryption.SaveConfig(Config);
    }
}