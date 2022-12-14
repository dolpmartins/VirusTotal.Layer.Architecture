using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Teste.Domain.Entities;
using Teste.WebApp.Helper;
using Teste.WebApp.Model;

namespace Teste.WebApp.Pages
{
    public class ScansModel : PageModel
    {
        private readonly ILogger<ScansModel> _logger;
        private readonly IApiVirusTotal _apiVirusTotal;

        public IList<Scan> Scans { get; set; }


        public ScansModel(ILogger<ScansModel> logger, IApiVirusTotal apiVirusTotal)
        {
            _logger = logger;
            _apiVirusTotal = apiVirusTotal;
        }

        public async Task OnGetAsync()
        {
            Scans = await _apiVirusTotal.Scans();
        }
    }
}