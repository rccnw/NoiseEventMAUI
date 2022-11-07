namespace NoiseEventMaui.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        IGeolocation geolocation;

        private readonly ReportApiService reportApiService;

        public MainPageViewModel(ReportApiService reportApiService, IGeolocation geolocation)
        {
            Title = "Report Noise";
            this.reportApiService = reportApiService;
            this.geolocation = geolocation;
        }


        [RelayCommand]
        public async Task Report()
        {

            var location = await geolocation.GetLastKnownLocationAsync();
            if (location == null)
            {
                location = await geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)
                });
            }



            NoiseEvent noiseEvent = new()
            {
                Data = "its noisy here",
                UtcTime = DateTime.UtcNow.ToString(),
                Longitude= location.Longitude,
                Latitude= location.Latitude
            };
            await reportApiService.Report(noiseEvent);

            await ShowAlert(reportApiService.StatusMessage);
        }

        private async Task ShowAlert(string message)
        {
            await Shell.Current.DisplayAlert("Info", message, "Ok");
        }
    }
}
