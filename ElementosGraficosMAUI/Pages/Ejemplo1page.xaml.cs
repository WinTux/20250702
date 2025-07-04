using System.Timers;

namespace ElementosGraficosMAUI.Pages;

public partial class Ejemplo1page : ContentPage
{
	public Ejemplo1page()
	{
		InitializeComponent();
        var temporizador = new System.Timers.Timer(1000);
        temporizador.Elapsed += new System.Timers.ElapsedEventHandler(RedibujarReloj);
        temporizador.Start();
    }
    public void RedibujarReloj(object sender, ElapsedEventArgs e)
    {
        var graphicsView = this.relojGraphicsView;
        graphicsView.Invalidate();
    }
}