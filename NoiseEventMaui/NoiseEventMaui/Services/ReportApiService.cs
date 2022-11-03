namespace NoiseEventMaui.Services
{
    public class ReportApiService
    {
        HttpClient _httpClient;
        public static string BaseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:8099" : "http://localhost:8099";
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
                response.EnsureSuccessStatusCode();
                StatusMessage = "Report Successful";
            }
            catch (Exception /*ex*/)
            {
                StatusMessage = "Failed to report noise.";
            }
        }
    }
}
