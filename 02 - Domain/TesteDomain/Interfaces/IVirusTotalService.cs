using System.Threading.Tasks;
using Teste.Domain.Entities;

namespace Teste.Domain.Interfaces
{
    public interface IVirusTotalService
    {
        Task<Scan> Scan(string fileBase64);
    }
}
