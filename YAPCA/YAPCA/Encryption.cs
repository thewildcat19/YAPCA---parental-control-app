using System.Text;
using System.Text.Json;

namespace YAPCA;

public class Encryption
{
    private static readonly string FilePath = "config.json";

    // Encryption mode
    /*
    private static byte[] Encrypt(string text)
    {
        byte[] data = Encoding.UTF8.GetBytes(text);
        return ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
    }

    private static string Decrypt(byte[] encryptedData)
    {
        byte[] decrypted = ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);
        return Encoding.UTF8.GetString(decrypted);
    }
    */

    // Open mode
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
            // --- Encryption read ---
            /*
            using (var fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[] encryptedData = new byte[fs.Length];
                fs.Read(encryptedData, 0, encryptedData.Length);
                string json = Decrypt(encryptedData);
                return JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
            }
            */

            // --- Open read ---
            using (var reader = new StreamReader(FilePath))
            {
                string json = reader.ReadToEnd();
                return JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
            }
        }
        catch
        {
            return new AppConfig();
        }
    }

    public static void SaveConfig(AppConfig config)
    {
        string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });

        // --- Encryption write ---
        /*
        byte[] encryptedData = Encrypt(json);
        using (var fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.None))
        {
            fs.Write(encryptedData, 0, encryptedData.Length);

        }
        */

        // --- Open write ---
        using (var writer = new StreamWriter(FilePath, false)) // false = overwrite
        {
            writer.Write(json);
        }
    }
}