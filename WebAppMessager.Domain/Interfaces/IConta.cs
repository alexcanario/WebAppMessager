using System;

namespace WebAppMessager.Business.Interfaces {
    public interface IConta {
        Guid Id { get; set; }
        DateTime DataLeitura { get; set; }
        decimal Valor { get; }
    }
}
