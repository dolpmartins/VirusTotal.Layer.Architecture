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
    public class VirusTotalService : IVirusTotalService
    {
        private readonly IBaseRepository<Scan> _baseRepository;
        private readonly IVirusTotal _virusTotal;

        public VirusTotalService(IBaseRepository<Scan> baseRepository, IVirusTotal virusTotal)
        {
            _baseRepository = baseRepository;
            _virusTotal = virusTotal;
        }
        public async Task<Scan> Scan(string fileBase64)
        {
            var result = await _virusTotal.Scan(fileBase64);

            _baseRepository.Insert(result);

            return result;
        }

    }
}
