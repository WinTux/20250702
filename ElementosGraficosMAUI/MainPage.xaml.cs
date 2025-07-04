using System.Timers;

namespace ElementosGraficosMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var temporizador = new System.Timers.Timer(1000);
            temporizador.Elapsed += new System.Timers.ElapsedEventHandler(RedibujarReloj);
            temporizador.Start();
        }
        public void RedibujarReloj(object sender, ElapsedEventArgs e) {
            var graphicsView = this.relojGraphicsView;
            graphicsView.Invalidate();
        }
    }

}
