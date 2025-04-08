using System.Diagnostics;

namespace YAPCA;

public class AppKiller
{
    public static void CloseApp(string appName)
    {
        if (ConfigManager.Config.IsKilling)
        {

            var processes = Process.GetProcessesByName(appName);
            foreach (var process in processes)
            {
                try
                {
                    if (!process.HasExited)
                    {
                        process.CloseMainWindow();  
                        process.WaitForExit(5000); 
                    }

                   
                    if (!process.HasExited)
                    {
                        process.Kill();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error killing process {appName}: {ex.Message}");
                }
            }
        }
    }
}