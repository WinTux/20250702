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
}