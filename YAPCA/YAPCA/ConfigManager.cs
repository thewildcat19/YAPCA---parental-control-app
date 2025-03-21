namespace YAPCA;

public static class ConfigManager
{
    private static readonly string configPath = "config.enc";
    public static AppConfig Config { get; private set; } = Encryption.LoadConfig();

    public static void SaveConfig()
    {
        Encryption.SaveConfig(Config);
    }
}