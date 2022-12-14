using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Teste.WebApp.Helper;
using Teste.WebApp.Model;

namespace Teste.WebApp.Pages
{
    public class SendFileModel : PageModel
    {
        private readonly ILogger<SendFileModel> _logger;
        private readonly IApiVirusTotal _apiVirusTotal;
        
        [BindProperty]
        public IFormFile Upload { get; set; }


        public SendFileModel(ILogger<SendFileModel> logger, IApiVirusTotal apiVirusTotal)
        {
            _logger = logger;
            _apiVirusTotal = apiVirusTotal;
        }

        public void OnGet()
        {
        }

        
        public async Task OnPostAsync()
        {
            if (Upload.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    Upload.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    string fileBase64 = Convert.ToBase64String(fileBytes);
                    await _apiVirusTotal.SendFile(new SendFileDto() { FileBase64 = fileBase64});
                    TempData["Message"] = "Arquivo enviado para scan com sucesso.";
                }
            }
            
        }
    }
}