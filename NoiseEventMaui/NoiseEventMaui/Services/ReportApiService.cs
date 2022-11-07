namespace NoiseEventMaui.Services
{
    public class ReportApiService
    {
        HttpClient _httpClient;
        public static string BaseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5228" : "http://localhost:5228";
        public string StatusMessage;

        public ReportApiService()
        {
            _httpClient = new() { BaseAddress = new Uri(BaseAddress) };
        }

        public async Task Report(NoiseEvent noiseEvent)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("/noiseevents/", noiseEvent);
                //var response = await _httpClient.GetAsync("/noiseevents/");
                response.EnsureSuccessStatusCode();
                StatusMessage = "Report Successful";
            }
            catch (Exception ex)
            {
                Debug.WriteLine( $"{ex.Message}");
                StatusMessage = "Failed to report noise.";
            }
        }
    }
}
