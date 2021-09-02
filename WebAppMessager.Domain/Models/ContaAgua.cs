namespace WebAppMessager.Business.Models {
    public class ContaAgua : Conta {
        public ContaAgua(ILeitura leitura) : base(leitura) { }
        protected override decimal CalcularConta() {
            return ((_leitura.LeituraAtual - _leitura.LeituraAnterior) * 2.5M) + 25;
        }
    }
}
