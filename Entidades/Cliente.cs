using Tracking.Enumeradores;

namespace Tracking.Entidades
{
    public class Cliente
    {
        public int CodigoCliente { get; set; }
        public string NomeCliente { get; set; }
        public TipoClienteEnum TipoCliente { get; set; }
        public string CpfCnpjCliente { get; set; }
        public string EmailCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string CidadeCliente { get; set; }
        public string CepCliente { get; set; }
        public string UfCliente { get; set; }
    }
}