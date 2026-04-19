using Microsoft.Extensions.Logging;

namespace MyExpenses;   // ⚠️ match your project name

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>();

        return builder.Build();
    }
}