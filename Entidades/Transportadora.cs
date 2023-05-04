namespace Tracking.Entidades
{
    public class Transportadora 
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj{ get; set; }
        public string InscricaoEstadual { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string TipoTelefone { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string UfTransportadora { get; set; }
        public string SiteTransportadora { get; set; }
        
        //################################
        public Transportadora(string razaosocial, string nomefantasia, string cnpj, string inscricaoestadual)
        {
            SetRazaoSocial(razaosocial);
            SetNomeFantasia(nomefantasia);
            SetCnpj(cnpj);
            SetInscricaoEstadual(inscricaoestadual);
    
        }
        //################################
        public void SetRazaoSocial(string razaosocial)
        {
            if (String.IsNullOrWhiteSpace(razaosocial))
            throw new ArgumentNullException(" Razão solcial é obrigatória");
            RazaoSocial = razaosocial;
        }
        //###############################
        public void SetNomeFantasia(string nomefantasia)
        {
            if (String.IsNullOrWhiteSpace(nomefantasia))
            throw new ArgumentNullException(" Nome Fantasia é obrigatória");
            NomeFantasia = nomefantasia;
        }
        //##############################
        public void SetCnpj(string cnpj)
        {
            // Remove caracteres não numéricos
            cnpj = System.Text.RegularExpressions.Regex.Replace(cnpj, "[^0-9]", "");

            // Verifica se o CNPJ tem 14 dígitos
            if (cnpj.Length != 14)
            {
                throw new ArgumentException("O CNPJ informado não possui 14 dígitos.");
            }

            // Calcula o primeiro dígito verificador
            int soma = 0;
            int[] multiplicadores = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < 12; i++)
            {
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores[i];
            }
            int resto = soma % 11;
            int primeiroDigito = resto < 2 ? 0 : 11 - resto;

            // Calcula o segundo dígito verificador
            soma = 0;
            multiplicadores = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(cnpj[i].ToString()) * multiplicadores[i];
            }
            resto = soma % 11;
            int segundoDigito = resto < 2 ? 0 : 11 - resto;

            // Verifica se os dígitos verificadores estão corretos
            if (int.Parse(cnpj[12].ToString()) != primeiroDigito || int.Parse(cnpj[13].ToString()) != segundoDigito)
            {
                throw new ArgumentException("O CNPJ informado é inválido.");
            }
            Cnpj = cnpj;
        }

         //###################################
        public void SetInscricaoEstadual(string inscricaoestadual)
        {
            if (String.IsNullOrWhiteSpace(inscricaoestadual))
            throw new ArgumentException("A inscrição estadual é obrigatória");

            if (inscricaoestadual.Length != 9 && inscricaoestadual.Length != 12)
            throw new ArgumentException("A inscrição estadual deve ter 9 ou 12 dígitos");

            if (!int.TryParse(inscricaoestadual, out int result))
            throw new ArgumentException("A inscrição estadual deve ser um número inteiro");

            InscricaoEstadual = inscricaoestadual;
        }

        //########################################

        


    }

}