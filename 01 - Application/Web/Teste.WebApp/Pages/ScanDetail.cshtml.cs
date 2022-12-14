using Microsoft.AspNetCore.Mvc.RazorPages;
using Teste.Domain.Entities;
using Teste.WebApp.Helper;


namespace Teste.WebApp.Pages
{
    public class ScanDetailModel : PageModel
    {
        private readonly ILogger<ScanDetailModel> _logger;
        private readonly IApiVirusTotal _apiVirusTotal;

        public Scan Detail { get; set; }


        public ScanDetailModel(ILogger<ScanDetailModel> logger, IApiVirusTotal apiVirusTotal)
        {
            _logger = logger;
            _apiVirusTotal = apiVirusTotal;
        }

        public async Task OnGetAsync(string scan_id)
        {
            Detail = await _apiVirusTotal.Detail(scan_id);
        }
    }
}