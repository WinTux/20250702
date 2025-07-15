namespace ElementosGraficosMAUI.Pages;

public partial class Ejemplo8page : ContentPage
{
	public Ejemplo8page()
	{
		InitializeComponent();
	}
	async void OnCargarImagenClicked(object sender, EventArgs e)
	{
		var resultados = await FilePicker.PickMultipleAsync(
				new PickOptions
				{
					FileTypes = FilePickerFileType.Images,
					PickerTitle = "Elija una imagen"
				}
			);

		if (resultados == null)
			return;
		else {
			foreach (var resultado in resultados) {
                var flujo = await resultado.OpenReadAsync();
                image.Source = ImageSource.FromStream(() => flujo);
            }
			lblInfo.Text = $"Se han cargado {resultados.Count()} imágenes.";
        }
	}
}