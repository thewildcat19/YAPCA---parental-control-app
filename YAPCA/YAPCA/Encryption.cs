using System.Text;
using System.Text.Json;

namespace YAPCA;

public class Encryption
{
    private static readonly string FilePath = "config.json";

    //Encryption mode
    /*private static byte[] Encrypt(string Text)
    {
        byte[] data = Encoding.UTF8.GetBytes(Text);
        return ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
    }

    private static string Decrypt(byte[] encryptedData)
    {
        byte[] decrypted = ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);
        return Encoding.UTF8.GetString(decrypted);
    }*/

    //open mode
    public static AppConfig LoadConfig()
    {
        if (!File.Exists(FilePath))
        {
            var defaultConfig = new AppConfig();
            SaveConfig(defaultConfig);
            return defaultConfig;
        }
        try
        {
            //byte[] encryptedData = File.ReadAllBytes(FilePath);
            //string json = Decrypt(encryptedData);
            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
        }
        catch
        {
            return new AppConfig();
        }
    }

    public static void SaveConfig(AppConfig config)
    {
        string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
        //byte[] encryptedData = Encrypt(json);
        //File.WriteAllBytes(FilePath, encryptedData);
        File.WriteAllText(FilePath, json);
    }
}