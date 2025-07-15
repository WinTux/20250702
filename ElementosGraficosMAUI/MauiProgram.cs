using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;
using ZXing.Net.Maui;

namespace ElementosGraficosMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitMediaElement()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }) // En caso de que no reconozca la lectura de QR (ZXing)
                .ConfigureMauiHandlers(h => {
                    h.AddHandler(typeof(ZXing.Net.Maui.Controls.CameraBarcodeReaderView), typeof(CameraBarcodeReaderViewHandler));
                    h.AddHandler(typeof(ZXing.Net.Maui.Controls.CameraView), typeof(CameraViewHandler));
                    h.AddHandler(typeof(ZXing.Net.Maui.Controls.BarcodeGeneratorView), typeof(BarcodeGeneratorViewHandler));
                })
                .UseMauiCommunityToolkit();
            builder.UseBarcodeReader();
            builder.UseMauiMaps();




            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<Pages.Ejemplo1page>();
            builder.Services.AddTransient<Pages.ScannerPage>();
            builder.Services.AddTransient<Pages.TrazosPage>();
            builder.Services.AddTransient<Pages.Ejemplo4page>();
            builder.Services.AddTransient<Pages.Ejemplo5page>();
            builder.Services.AddTransient<Pages.Ejemplo6page>();
            builder.Services.AddTransient<Pages.Ejemplo7page>();
            builder.Services.AddTransient<Pages.Ejemplo8page>();
            builder.Services.AddTransient<Pages.Ejemplo9page>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
