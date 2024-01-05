using Microsoft.Extensions.Logging;
using MovieRatingApp.Mobile.Controls;
using MovieRatingApp.Mobile.Handlers;

namespace MovieRatingApp.Mobile;

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
            }).ConfigureMauiHandlers(handlers => 
			{
				handlers.AddHandler(typeof(RatingView), typeof(RatingViewHandler));
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		var app = builder.Build();

        AppLogger.Initialize(app.Services.GetService<ILoggerFactory>());

        return app;
	}
}
