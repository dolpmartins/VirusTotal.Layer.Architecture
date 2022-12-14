using Teste.Domain.Entities;
using Teste.Service.Helper;
using Teste.WebApp.Model;

namespace Teste.WebApp.Helper
{
    public class ApiVirusTotal : IApiVirusTotal
    {
        private readonly IConfiguration _configuration;
        private readonly ApiHelper _apiHelper;
        private readonly ILogger<ApiVirusTotal> _logger;
        private readonly string _baseApi;

        public ApiVirusTotal(IConfiguration configuration, ApiHelper apiHelper, ILogger<ApiVirusTotal> logger)
        {
            _configuration = configuration;
            _apiHelper = apiHelper;
            _logger = logger;
            _baseApi = _configuration.GetSection("BaseAPI").Value;
        }
        public async Task<object> SendFile(SendFileDto sendFileDto)
        {
            return await _apiHelper.PostAsync<Scan>($"{_baseApi}VirusTotal/Scan", sendFileDto);
        }
        public async Task<object> SendFiles()
        {
            return await _apiHelper.PostAsync<string>($"{_baseApi}VirusTotal/Scan", null);
        }
        public async Task<List<Scan>> Scans()
        {
            return await _apiHelper.GetAsync<List<Scan>>($"{_baseApi}VirusTotal/Scans");
        }
        public async Task<Scan> Detail(string scan_id)
        {
            return await _apiHelper.GetAsync<Scan>($"{_baseApi}VirusTotal/Detail/{scan_id}");
        }
        
        public async Task<object> Dashboard()
        {
            return await _apiHelper.GetAsync<string>($"{_baseApi}VirusTotal/Scan");
        }
    }
}
