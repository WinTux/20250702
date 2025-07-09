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
        mimapa.MapType = MapType.Hybrid; // Mapa de calles

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
}