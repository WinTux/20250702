using CommunityToolkit.Maui.Views;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace ElementosGraficosMAUI.Pages;

public partial class Ejemplo9page : ContentPage
{
	public Ejemplo9page()
	{
		InitializeComponent();
	}
	async void OnTomarFotoClicked(object sender, EventArgs e)
	{
		var resultado = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions { Title = "Tomar Fotito" });
		if (resultado != null)
		{
			var flujoFoto = await resultado.OpenReadAsync();
            fotito.Source = ImageSource.FromStream(() => flujoFoto);
        }
	}
    async void OnTomarFotoClicked2(object sender, EventArgs e)
    {
		await camara.CaptureImage(CancellationToken.None);
    }

    async void OnCapturaTomada(object sender, MediaCapturedEventArgs e)
    {
		Dispatcher.Dispatch(() => {
            fotito2.Source = ImageSource.FromStream(() => e.Media);
			return;
        });
    }
}