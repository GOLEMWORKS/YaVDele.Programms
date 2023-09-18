using Microsoft.Extensions.Logging;
using YaVDele.CalculatorGrant.Data;

namespace YaVDele.CalculatorGrant
{
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

                //Шрифты ЯВделе

                    //avenir
                    fonts.AddFont("avenirnextcyr-bold.ttf", "AvenirNextCyrBold");
                    fonts.AddFont("avenirnextcyr-demi.ttf", "AvenirNextCyrDemi");
                    fonts.AddFont("avenirnextcyr-medium.ttf", "AvenirNextCyrMedium");
                    fonts.AddFont("avenitnextcyr-regular.ttf", "AvenirNextCyrRegular");

                    //maler
                    fonts.AddFont("Maler.ttf", "Maler");

                    //beachwood
                    fonts.AddFont("beachwood.otf", "Beachwood");
                });

            builder.Services.AddLocalization();
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddSingleton<Calculations>();

            return builder.Build();
        }
    }
}