namespace ElementosGraficosMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Pages.Ejemplo1page), typeof(Pages.Ejemplo1page));
        }
    }
}
