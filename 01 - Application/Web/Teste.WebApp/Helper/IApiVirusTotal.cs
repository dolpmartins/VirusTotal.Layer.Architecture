using Teste.Domain.Entities;
using Teste.WebApp.Model;

namespace Teste.WebApp.Helper
{
    public interface IApiVirusTotal
    {
        Task<object> SendFile(SendFileDto fileBase64);
        Task<object> SendFiles();
        Task<List<Scan>> Scans();
        Task<Scan> Detail(string scan_id);
        Task<object> Dashboard();
    }
}
