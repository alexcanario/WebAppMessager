using System.Collections.Generic;

using WebAppMessager.Business.Interfaces;
using WebAppMessager.Business.Models;

namespace WebAppMessager.Business.Services {
    public class ContasService : IContasService {
        public IConta ProcessarLeitura(ILeitura leitura) {
            var conta = new ContaAgua(leitura);
            return conta;
        }

        public IEnumerable<IConta> ProcessarLeituras(IEnumerable<ILeitura> leituras) {
            var listaContas = new List<IConta>();
            foreach (var leitura in leituras) {
                listaContas.Add(new ContaAgua(leitura));
            }

            return listaContas;
        }
    }
}
