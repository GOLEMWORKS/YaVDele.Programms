using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using YaVDele.CalculatorGrant.Data;
using Microsoft.Extensions.Configuration;

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

            var connectionString = builder.Configuration.GetConnectionString("AppDB");

            builder.Services.AddLocalization();
            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddDbContextFactory<AppDbContext>(options => options.UseSqlite(connectionString));

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