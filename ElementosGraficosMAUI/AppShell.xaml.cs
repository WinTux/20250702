﻿namespace ElementosGraficosMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Pages.Ejemplo1page), typeof(Pages.Ejemplo1page));
            Routing.RegisterRoute(nameof(Pages.ScannerPage), typeof(Pages.ScannerPage));
            Routing.RegisterRoute(nameof(Pages.TrazosPage), typeof(Pages.TrazosPage));
            Routing.RegisterRoute(nameof(Pages.Ejemplo4page), typeof(Pages.Ejemplo4page));
            Routing.RegisterRoute(nameof(Pages.Ejemplo5page), typeof(Pages.Ejemplo5page));
            Routing.RegisterRoute(nameof(Pages.Ejemplo6page), typeof(Pages.Ejemplo6page));
            Routing.RegisterRoute(nameof(Pages.Ejemplo7page), typeof(Pages.Ejemplo7page));
        }
    }
}
