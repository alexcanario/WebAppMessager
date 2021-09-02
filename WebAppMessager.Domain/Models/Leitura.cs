using System;

namespace WebAppMessager.Business.Models {
    public class Leitura : Entity, ILeitura {
        public Leitura() { }
        public Leitura(Guid id, DateTime dataLeitura, string codigHidrometro, decimal leituraAnterior, decimal leituraAtual) {
            Id = id;
            DataLeitura = dataLeitura;
            CodigoHidrometro = codigHidrometro;
            LeituraAnterior = leituraAnterior;
            LeituraAtual = leituraAtual;
        }

        public DateTime DataLeitura { get; set; }
        public string CodigoHidrometro { get; set; }
        public decimal LeituraAnterior { get; set; }
        public decimal LeituraAtual { get; set; }
        //public string Linha() => $"{Id}|{DataLeitura:s}|{CodigoHidrometro}|{LeituraAnterior}|{LeituraAtual}";
    }
}
