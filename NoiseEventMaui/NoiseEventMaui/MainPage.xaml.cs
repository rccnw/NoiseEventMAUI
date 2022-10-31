namespace NoiseEventMaui;


using CommunityToolkit.Maui.Alerts;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

		var hanaLoc = new Location(20.7557, -155.9880);
		MapSpan mapSpan = MapSpan.FromCenterAndRadius(hanaLoc, Distance.FromKilometers(3));
		map.MoveToRegion(mapSpan);
		map.Pins.Add(new Pin
		{ 
			Label = "Noise Event",
			Location = hanaLoc
		});
    }
}

