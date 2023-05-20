using Microsoft.Extensions.Options;
using Portfolio.Models;
using Portfolio.Models.Api;
using System.Net.Http.Json;

namespace Portfolio.Services
{
    public interface IApiService
    {
        Task<List<Addon>> GetAddons();
        Task GetMe();
    }

    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<GmodstoreSettings> _settings;

        public ApiService(HttpClient httpClient, IOptions<GmodstoreSettings> settings)
        {
            _httpClient = httpClient;
            _settings = settings;
        }

        public async Task<List<Addon>> GetAddons()
        {
            try
            {
                _httpClient.BaseAddress = new Uri(_settings.Value.ApiUrl);
                var addons = await _httpClient.GetFromJsonAsync<List<Addon>>(_settings.Value.GetMeAddons!);

                return addons;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task GetMe()
        {
            throw new NotImplementedException();
        }
    }
}
