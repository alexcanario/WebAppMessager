using System;

namespace WebAppMessager.Business.Models {
    public interface ILeitura {
        Guid Id {  get; set; } 
        string CodigoHidrometro { get; set; }
        DateTime DataLeitura { get; set; }
        decimal LeituraAnterior { get; set; }
        decimal LeituraAtual { get; set; }
    }
}