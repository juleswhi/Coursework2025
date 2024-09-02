global using LanguageExt;
global using LanguageExt.Common;
global using LanguageExt.Effects;
global using LanguageExt.Pipes;
global using LanguageExt.Pretty;
global using static LanguageExt.Prelude;

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