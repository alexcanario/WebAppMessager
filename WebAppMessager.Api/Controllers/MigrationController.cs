using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using WebAppMessager.Business.Interfaces;
using WebAppMessager.Business.Models;

namespace WebAppMessager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MigrationController : Controller {
        private readonly ILeituraService _leituraService;
        private IEnumerable<ILeitura> _leituraList = null;
        public MigrationController(ILeituraService leituraService) {
            _leituraService = leituraService;
        }

        [HttpGet("ObterLeituras")]
        [ProducesResponseType(typeof(IEnumerable<Leitura>), 200)]
        public async Task<IActionResult> GetAll() {
            _leituraList = await ObterLeituras();
            
            if(_leituraList is null) return NotFound();

            return Ok(_leituraList);
        }

        [HttpGet("ObterLeiturasPorPeriodo")]
        public async Task<IActionResult> GetByPeriod(Period period) {
            _leituraList = await ObterLeiturasPorPeriodo(period);

            if(_leituraList is null) return NotFound();

            return Ok(_leituraList);
        }

        //[HttpGet("ObterContas")]
        //public IActionResult GetAllOrders() { 
            
        //}


        [HttpGet("heathcheck")]
        public IActionResult HeathCheck() {
            return Ok($"{DateTime.UtcNow:O}");
        }

        //[HttpPost("migrar")]
        //public async Task<IActionResult> Migrar() {
        //    if(_leituraList is null) return NotFound();

        //    return Ok(_leituraList);
        //}

        private async Task<IEnumerable<ILeitura>> ObterLeituras() {
            var leituras = await _leituraService.GetAll();

            return leituras ?? null;
        }

        private async Task<IEnumerable<ILeitura>> ObterLeiturasPorPeriodo(Period period) {
            var leituras = await _leituraService.GetByPeriod(period);

            return leituras ?? null;
        }
    }
}
