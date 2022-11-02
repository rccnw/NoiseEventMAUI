namespace NoiseEventMaui.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        private readonly ReportApiService reportApiService;

        public MainPageViewModel(ReportApiService reportApiService)
        {
            Title = "Report Noise";
            this.reportApiService = reportApiService;
        }


        [RelayCommand]
        public async Task Report()
        {
            NoiseEvent noiseEvent = new()
            {
                Data = "its noisy here"
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
