namespace ElementosGraficosMAUI.Pages;

public partial class Ejemplo5page : ContentPage
{
	public Ejemplo5page()
	{
		InitializeComponent();
	}
	public void OnPlayPauseClicked(object sender, EventArgs e) {
		if(video4.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing)
			video4.Pause();
		else
			video4.Play();

    }
	public void OnReducirVolClic(object sender, EventArgs e) { 
		if(video4.Volume > 0)
			video4.Volume -= 0.1;
    }
    public void OnAumentarVolClic(object sender, EventArgs e)
    {
        if (video4.Volume < 1)
            video4.Volume += 0.1;
    }
}