using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces;

namespace Teste.Service.Services
{
    public class ScanService : IScanService
    {
        private readonly IBaseRepository<Scan> _baseRepository;
        private readonly IScanRepository<Scan> _baseScanRepository;
        private readonly IMapper _mapper;

        public ScanService(IBaseRepository<Scan> baseRepository, IScanRepository<Scan> baseScanRepository,IMapper mapper)
        {
            _baseRepository = baseRepository;
            _baseScanRepository = baseScanRepository;
            _mapper = mapper;
        }
        public async Task<Scan> GetScanWithIncludesById(string scan_id)
        {
            return await _baseScanRepository.GetScanWithIncludesByScanId(scan_id);
        }
    }
}
