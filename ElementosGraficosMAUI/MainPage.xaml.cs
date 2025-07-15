using ElementosGraficosMAUI.Pages;
using System.Timers;

namespace ElementosGraficosMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        
        async void OnEjemplo1Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Ejemplo1page));
        }
        async void OnEjemplo2Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ScannerPage));
        }
        async void OnEjemplo3Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(TrazosPage));
        }
        async void OnEjemplo4Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Ejemplo4page));
        }
        async void OnEjemplo5Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Ejemplo5page));
        }
        async void OnEjemplo6Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Ejemplo6page));
        }
        async void OnEjemplo8Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Ejemplo8page));
        }
        async void OnEjemplo9Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Ejemplo9page));
        }
    }

}
