using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Teste.App.API.Model;
using Teste.Domain.Entities;
using Teste.Domain.Interfaces;
using Teste.Service.Services;

namespace Teste.App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VirusTotalController : ControllerBase
    {
        private readonly ILogger<VirusTotalController> _logger;
        private IBaseService<Scan> _baseService;
        private IScanService _scanService;
        private IVirusTotalService _virusTotal;

        private async Task<IActionResult> Execute<T>(Func<Task<T>> func)
        {
            try
            {
               
                var result = await func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        private async Task<IActionResult> Execute(Func<object> func)
        {
            try
            {

                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public VirusTotalController(ILogger<VirusTotalController> logger, IBaseService<Scan> baseService, IScanService scanService, IVirusTotalService virusTotal)
        {
            _baseService = baseService;
            _logger = logger;
            _scanService = scanService;
            _virusTotal = virusTotal;
        }


        [HttpPost("Scan")]
        public async Task<IActionResult> Scan(ScanDTO scanDTO)
        {

            _logger.LogInformation($"Call Scan method: {JsonConvert.SerializeObject(scanDTO)}");
            return await Execute<Scan>(() => _virusTotal.Scan(scanDTO.FileBase64));
        }

        [HttpGet("Scans")]
        public async Task<IActionResult> Scans()
        {

            _logger.LogInformation($"Call Reports method");
            return await Execute(() => _baseService.Get<Scan>());
        }

        [HttpGet("Detail/{scan_id}")]
        public async Task<IActionResult> Detail(string scan_id)
        {

            _logger.LogInformation($"Call Detail method");
            return await Execute<Scan>(() => _scanService.GetScanWithIncludesById(scan_id));
        }
    }
}
