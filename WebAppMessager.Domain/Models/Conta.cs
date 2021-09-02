using System;

using WebAppMessager.Business.Interfaces;

namespace WebAppMessager.Business.Models {
    public abstract class Conta : IConta {
        protected readonly ILeitura _leitura;
        public Conta(ILeitura leitura) {
            _leitura = leitura;
            Id = _leitura.Id;
            DataLeitura = _leitura.DataLeitura;
        }
        public Guid Id { get; set; }
        public DateTime DataLeitura { get; set; }
        public decimal Valor { get => CalcularConta(); }

        protected virtual decimal CalcularConta() => ((_leitura.LeituraAtual - _leitura.LeituraAnterior) * 3) + 15;
    }
}
