using System.Collections.Generic;
using System.Threading.Tasks;

using WebAppMessager.Business.Interfaces;
using WebAppMessager.Business.Models;

namespace WebAppMessager.Business.Services {
    public class LeituraService : ILeituraService {
        private readonly ILeituraRepository _leituraRepository;
        public LeituraService(ILeituraRepository leituraRepository) {
            _leituraRepository = leituraRepository;
        }

        public async Task<IEnumerable<ILeitura>> GetAll() {
            var leituras = await _leituraRepository.GetAll();
            return leituras;
        }

        public async Task<IEnumerable<ILeitura>> GetByPeriod(Period periodo) {
            return await _leituraRepository.GetByPeriod(periodo);
        }
    }
}
