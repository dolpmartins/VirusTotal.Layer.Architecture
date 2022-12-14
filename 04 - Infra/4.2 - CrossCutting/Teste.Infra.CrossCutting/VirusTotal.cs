using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Teste.Domain.Interfaces;
using entiies = Teste.Domain.Entities;
namespace Teste.Infra.CrossCutting
{
    public class VirusTotal: IVirusTotal
    {
        public async Task<entiies.Scan> Scan(string fileBase64)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://www.virustotal.com/vtapi/v2/file/scan"),
                Headers =
                {
                    { "accept", "text/plain" },
                },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "apikey", "xx" },
                    { "file", $"data:text/xml;name=nvd-rss.xml;base64,{fileBase64}" },
                }),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<entiies.Scan>(body);

            }
        }

    }
}
