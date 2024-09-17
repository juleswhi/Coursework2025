global using LanguageExt;
global using System;

namespace SSD_Coursework;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new MainMenu());
    }
}
