namespace Tracking.Entidades
{
    public class ColetaMercadoria
    {
        public int CodigoColeta { get; set; }
        public int NotaFiscalColeta { get; set; }
        public int NumeroPedidoCompra { get; set; }
        public string CpfCnpjCliente { get; set; }
        public string NomeCliente { get; set; }
        public int CodigoTransportadora { get; set; }
        public string NomeFantasiaTransportadora { get; set; }
        public string DescricaoProduto { get; set; }

    }
}