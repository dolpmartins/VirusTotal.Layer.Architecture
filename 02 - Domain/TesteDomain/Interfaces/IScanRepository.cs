using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Entities;

namespace Teste.Domain.Interfaces
{
    public interface IScanRepository<TEntity> where TEntity : BaseEntity
    {
        Task<Scan> GetScanWithIncludesByScanId(string scan_id);
    }
}
