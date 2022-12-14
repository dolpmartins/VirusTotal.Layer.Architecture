using FluentValidation;
using System.Collections.Generic;
using System.Threading.Tasks;
using Teste.Domain.Entities;

namespace Teste.Domain.Interfaces
{
    public interface IScanService
    {
        Task<Scan> GetScanWithIncludesById(string scan_id);
    }
}
