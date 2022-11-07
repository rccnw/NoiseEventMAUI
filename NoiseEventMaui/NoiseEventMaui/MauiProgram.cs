//using IMap = Microsoft.Maui.Maps.IMap;

namespace NoiseEventMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			// Initialise the toolkit
			.UseMauiApp<App>().UseMauiCommunityToolkit()
            .UseMauiMaps()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddTransient<ReportApiService>();
        builder.Services.AddSingleton<MainPageViewModel>();
		builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
        //builder.Services.AddSingleton<IMap>(Map.Default);

        builder.Services.AddSingleton<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
