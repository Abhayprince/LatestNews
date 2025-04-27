using LatestNews.ViewModels;
using Microsoft.Extensions.Logging;
using Refit;

namespace LatestNews
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            ConfigureRefit(builder.Services);

            builder.Services.AddSingleton<MainPageViewModel>()
                            ;//.AddSingleton<MainPage>();

            builder.Services.AddTransient<NewsDetailsViewModel>()
                ;//.AddTransient<NewsDetailPage>();

            return builder.Build();
        }

        private static void ConfigureRefit(IServiceCollection services)
        {
            // https://newsdata.io/api/1/latest?apikey=pub_821184d8ee598fd91ad8253bdb1958949016d

            services.AddRefitClient<INewsApi>()
                .ConfigureHttpClient(httpClient => httpClient.BaseAddress = new Uri("https://newsdata.io"));

            // DelegatingHandler -  Add ApiKey to all the outgoing requests
        }
    }
}
