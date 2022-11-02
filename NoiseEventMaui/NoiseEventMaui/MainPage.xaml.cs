namespace NoiseEventMaui;

public partial class MainPage : ContentPage
{
    private readonly MainPageViewModel mainPageViewModel;

    public MainPage(MainPageViewModel model)
	{
		InitializeComponent();
        BindingContext = model;
        mainPageViewModel = model;
    }


    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

		//var hanaLoc = new Location(20.7557, -155.9880);
		//MapSpan mapSpan = MapSpan.FromCenterAndRadius(hanaLoc, Distance.FromKilometers(3));
		//map.MoveToRegion(mapSpan);
		//map.Pins.Add(new Pin
		//{ 
		//	Label = "Noise Event",
		//	Location = hanaLoc
		//});
    }
}

