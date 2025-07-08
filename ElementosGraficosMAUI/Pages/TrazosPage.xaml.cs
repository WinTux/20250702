using CommunityToolkit.Maui.Core;

namespace ElementosGraficosMAUI.Pages;

public partial class TrazosPage : ContentPage
{
	public TrazosPage()
	{
		InitializeComponent();
	}
	async void OnLineaDibujada(object sender, DrawingLineCompletedEventArgs e)
	{
		//DisplayAlert("Línea Dibujada", "Se ha dibujado una línea en el canvas.", "OK");
		var stream = await lienzo.GetImageStream(200,200);
        Dispatcher.Dispatch(() => { 
			imagen.Source = ImageSource.FromStream(() => stream);
        });
    }
}