using System.Threading.Tasks;
using Teste.Domain.Entities;

namespace Teste.Domain.Interfaces
{
    public interface IVirusTotal
    {
        Task<Scan> Scan(string fileBase64);
    }
}
