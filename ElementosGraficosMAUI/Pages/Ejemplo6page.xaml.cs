namespace ElementosGraficosMAUI.Pages;

public partial class Ejemplo6page : ContentPage
{
	public Ejemplo6page()
	{
		InitializeComponent();
	}
	async void OnIrOtraPageClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(Ejemplo7page));
    }
}