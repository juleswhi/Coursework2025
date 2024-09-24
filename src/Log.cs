namespace SSD_Coursework;

//Should write to AppData/MoversAdmin/Logs/Date.log

internal static class Log
{
    public enum LogLocation
    {
        Debug,
        File,
        DebugFile,
    }

    public enum LogLevel
    {
        DEBUG,
        INFO,
        WARNING,
        ERROR,
        FATAL,
    }

    private static readonly LogDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"AppData\\Local\\MoversAdmin\\Logs");

    static Log()
    {
        Directory.CreateDirectory(LogDirectory);

        "Log File Found".Debug();
    }

    public static LogLocation Location { get; set; } = LogLocation.Debug;
    public static LogLevel Level { get; set; } = LogLevel.WARNING;

    private static void LocationPrint(Func<string> print)
    {
        switch (Location)
        {
            case LogLocation.Debug: System.Diagnostics.Debug.Print(print()); break;
            case LogLocation.DebugFile: System.Diagnostics.Debug.Print(print()); WriteErrFile(print());  break;
            case LogLocation.File: WriteErrFile(print()); break;
        };
    }

    public static void ClearLogFile()
    {
        
    }

    private static void WriteErrFile(string s)
    {
        
        File.AppendAllText(Path.Combine(LogDirectory, "log.txt"), s + "\n");
    }

    public static void Debug(this string message)
    {
        LocationPrint(() => message);
    }
}
