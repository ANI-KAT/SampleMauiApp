using Microsoft.Extensions.Logging;

namespace SampleMauiApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton(typeof(IDetectPlatform), typeof(Platforms.DetectPlatform));
        builder.Services.AddTransient<ViewModels.FirstViewModel>();
        builder.Services.AddTransient<ViewModels.SecondViewModel>();
        builder.Services.AddTransient<Views.FirstView>();
        builder.Services.AddTransient<Views.SecondView>();
        Routing.RegisterRoute("SecondScreen", typeof(Views.SecondView));

        return builder.Build();
    }
}
