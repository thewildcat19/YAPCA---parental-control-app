using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;
using Timer = System.Timers.Timer;

namespace YAPCA;

public static class WindowTracker
{

    [DllImport("user32.dll")]
    private static extern IntPtr GetForegroundWindow();
    [DllImport("user32.dll")]
    private static extern int GetWindowText(IntPtr hWd, StringBuilder text, int count);

    [DllImport("user32.dll")]
    private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

    private static TrayNotificationService _notificationService;

    private static Timer timer;

    public static void StartTracking(TrayNotificationService notificationService)
    {
        _notificationService = notificationService;
        timer = new Timer(10000);
        timer.Elapsed += TrackActiveWindowProcessName;
        timer.AutoReset = true;
        timer.Start();
    }
    public static string GetActiveWindowProcessName()
    {
        const int nChars = 256;
        StringBuilder windowText = new StringBuilder(nChars);
        IntPtr hwnd = GetForegroundWindow();
        GetWindowThreadProcessId(hwnd, out uint processId);
        Process process = Process.GetProcessById((int)processId);
        return process.ProcessName;
    }
    private static void TrackActiveWindowProcessName(object sender, ElapsedEventArgs e)
    {
        const int nChars = 256;
        StringBuilder windowText = new StringBuilder(nChars);
        IntPtr hwnd = GetForegroundWindow();
        GetWindowThreadProcessId(hwnd, out uint processId);
        Process process = Process.GetProcessById((int)processId);
        AppChecker.Check(process.ProcessName, _notificationService);
    }
}