using ZXing.Net.Maui;

namespace ElementosGraficosMAUI.Pages;

public partial class ScannerPage : ContentPage
{
	public ScannerPage()
	{
		InitializeComponent();
		lectorCodigo.Options = new BarcodeReaderOptions { 
			AutoRotate = true,
			Formats = BarcodeFormat.QrCode,
			TryHarder = true,
			Multiple = false
        };

    }
	async void OnCodigoBarrasDetectado(object sender, BarcodeDetectionEventArgs e) {
		Dispatcher.Dispatch(() =>
		{
			resultadoCodigo.Text = $"[{e.Results[0].Format}] {e.Results[0].Value}";
		});
    }
}