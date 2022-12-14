using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces;
using Teste.Infra.Data.Context;

namespace Teste.Infra.Data.Repository
{
    public class ScanRepository : IScanRepository<Scan>
    {
        protected readonly DataContext _dataContext;

        public ScanRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<Scan> GetScanWithIncludesByScanId(string scan_id)
        {
            var scan = await _dataContext.Scan
               .Include(s => s.report)
                .ThenInclude(r => r.scans).Where(s => s.scan_id.Equals(scan_id)).FirstOrDefaultAsync();
            return scan;
        }


    }
}
