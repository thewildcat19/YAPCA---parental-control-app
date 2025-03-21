namespace YAPCA;

public class AppConfig
{
    public string Password { get; set; } = "123";
    public int GameTime { get; set; } = 0;
    public int GameLimit { get; set; } = 0;
    public int EducationalTime { get; set; } = 0;
    public int EducationalLimit { get; set; } = 0;
    public List<string> GameApps { get; set; } = new List<string>();
    public List<string> EducationalApps { get; set; } = new List<string>();
    public bool AreGamesUnlocked { get; set; } = false;
    public bool IsKilling { get; set; } = true;
    public DateTime Date { get; set; } = DateTime.Today;
}