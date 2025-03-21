namespace YAPCA;

public class TrayNotificationService
{
    private readonly NotifyIcon _trayIcon;

    public TrayNotificationService(NotifyIcon trayIcon)
    {
        _trayIcon = trayIcon;
    }

    public void ShowNotification(string title, string message, ToolTipIcon icon = ToolTipIcon.Info)
    {
        _trayIcon.BalloonTipTitle = title;
        _trayIcon.BalloonTipText = message;
        _trayIcon.BalloonTipIcon = icon;
        _trayIcon.ShowBalloonTip(3000);
    }
}