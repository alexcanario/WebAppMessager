using System.Collections.Generic;
using System.Threading.Tasks;

using WebAppMessager.Business.Models;

namespace WebAppMessager.Business.Interfaces {
    public interface ILeituraRepository : IRepository<Leitura> {
        Task<IEnumerable<ILeitura>> GetAll();

        Task<IEnumerable<ILeitura>> GetByPeriod(Period periodo);
    }
}
