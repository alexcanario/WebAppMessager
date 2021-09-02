using System.Collections.Generic;

using WebAppMessager.Business.Models;

namespace WebAppMessager.Business.Interfaces {
    public interface IContasService {
        IConta ProcessarLeitura(ILeitura leitura);
        IEnumerable<IConta> ProcessarLeituras(IEnumerable<ILeitura> leitura);
    }
}
