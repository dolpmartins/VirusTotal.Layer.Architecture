using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Teste.Service.Helper
{
    public class ApiHelper
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public ApiHelper(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }

        public async Task<T> PostAsync<T>(string uri, object content)
        {
            StringContent contentDto = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(uri, contentDto);
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }


        public async Task<T> GetAsync<T>(string uri)
        {
            var response = await _httpClient.GetAsync(uri);
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
