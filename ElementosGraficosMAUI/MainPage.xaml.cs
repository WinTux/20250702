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
    }

}
