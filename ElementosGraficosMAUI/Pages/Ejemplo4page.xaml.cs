using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace ElementosGraficosMAUI.Pages;

public partial class Ejemplo4page : ContentPage
{
	public Ejemplo4page()
	{
		InitializeComponent();
		/*
		Location ubicacionInicial = new Location(19.4326, -99.1332); // Ciudad de México
		MapSpan mapSpan = new MapSpan(ubicacionInicial,0.01,0.01);
		mimapa.MoveToRegion(mapSpan);
		*/

		// Creando un pin de manera programática
		mimapa.Pins.Add(
			new Pin { 
				Label = "EDUCOMSER S.R.L.",
				Address = "Usando pin genérico",
                Type = PinType.Generic,
				Location = new Location(-16.502259702117247, -68.129393724734), // La Paz, Bolivia
            }
		);
        mimapa.Pins.Add(
            new Pin
            {
                Label = "EDUCOMSER S.R.L.",
                Address = "Usando pin guardado",
                Type = PinType.SavedPin,
                Location = new Location(-16.503842685337773, -68.12772919530981), // La Paz, Bolivia
            }
        );
        mimapa.Pins.Add(
            new Pin
            {
                Label = "EDUCOMSER S.R.L.",
                Address = "Usando pin de resultado de búsqueda",
                Type = PinType.SearchResult,
                Location = new Location(-16.507678221079665, -68.13051485312381), // La Paz, Bolivia
            }
        );

        // Cambiando el tipo de mapa
        mimapa.MapType = MapType.Street; // Mapa de calles

        // Polígonos y circulos
        Polygon polygon = new Polygon
        {
            StrokeColor = Colors.Chocolate,
            StrokeWidth = 14,
            FillColor = Color.FromArgb("#AA00FFFF"),
            Geopath = 
            {
                new Location(-16.501204595944262, -68.13166888376233), // La Paz, Bolivia
                new Location(-16.501961087966492, -68.13074333899232), // La Paz, Bolivia
                new Location(-16.502633926942277, -68.13189647673858), // La Paz, Bolivia
                new Location(-16.501699225678273, -68.13249580490933) // Volver al inicio
            }
        };
        mimapa.MapElements.Add(polygon);
    }

    async void OnMapaClic(object sender, MapClickedEventArgs e) { 
        System.Diagnostics.Debug.WriteLine($"Mapa clic en: {e.Location.Latitude}, {e.Location.Longitude}");
        Polygon polygon = new Polygon
        {
            StrokeColor = Colors.Chocolate,
            StrokeWidth = 14,
            FillColor = Color.FromArgb("#AA00FFFF"),
            Geopath =
            {
                new Location(-16.50062849850255, -68.13298724540051), // La Paz, Bolivia
                new Location(-16.500820967353775, -68.1328022976906), // La Paz, Bolivia
                new Location(-16.500989647762527, -68.13305039827706), // La Paz, Bolivia
                new Location(-16.500842593055424, -68.13315189397153) // Volver al inicio
            }
        };
        mimapa.MapElements.Add(polygon);

        Polyline polilyne = new Polyline
        {
            StrokeColor = Colors.Indigo,
            StrokeWidth = 10,
            Geopath =
            {
                new Location(-16.501070743570107, -68.13691307840595), // La Paz, Bolivia
                new Location(-16.501164022682115, -68.1368620431748), // La Paz, Bolivia
                new Location(-16.50103098524641, -68.13652393476838), // La Paz, Bolivia
                new Location(-16.501038631078522, -68.1363293629496), // La Paz, Bolivia
                new Location(-16.500917826895737, -68.13618901606392), // La Paz, Bolivia
                new Location(-16.500593775449392, -68.13520347853337),
                new Location(-16.501126578308696, -68.13449520007748), // La Paz, Bolivia
                new Location(-16.50039716488863, -68.13403747783914), // La Paz, Bolivia
                new Location(-16.500982345011973, -68.13331478265691),
                new Location(-16.500852472006198, -68.13311898140479)
            }
        };
        mimapa.MapElements.Add(polilyne);

        Circle circulo = new Circle
        {
            Center = e.Location,
            StrokeColor = Colors.Green,
            StrokeWidth = 15,
            FillColor = Color.FromArgb("#AA00DD00"),
            Radius = new Distance(100) // Radio de 100 metros
        };
        mimapa.MapElements.Add(circulo);
    }
}