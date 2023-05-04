using Tracking.Enumeradores;

namespace Tracking.Entidades
{
    public class Produto
    {
    public int Codigo { get; set; }
    public string? Descricao { get; set; }
    public SituacaoProdutoEnum Situacao { get; set; }
    public double Preco { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double Largura { get; set; }
    public double Comprimento { get; set; }
    
        public Produto(string descricao, double preco, double peso, double altura, double largura, double comprimento)
        {
            SetDescricao(descricao);
            SetPreco(preco);
            SetPeso(peso);
            SetAltura(altura);
            SetLargura(largura);
            SetComprimento(comprimento);
        }
        public void SetDescricao(string descricao)
        {
            if (String.IsNullOrWhiteSpace(descricao))
            throw new ArgumentNullException(" A descrição é obrigatória");
            Descricao = descricao;
        }
        
        public void SetPreco(double preco)
        {   
            if (preco <= 0)
            {
                throw new ArgumentException("O preço não pode menor ou igla a 0!");
            }
            Preco = preco;  
        }

        public void SetPeso(double peso)
        {
            if (peso <= 0)
            {
                throw new ArgumentException("O peso não pode ser menor ou igla a 0!");
            }
            Peso = peso;  
        }

        public void SetAltura(double altura)
        {
            if (altura <= 0)
            {
                throw new ArgumentException("A altuta não pode ser menor ou igual a 0!");
            }
            Altura = altura;  
        }

        public void SetLargura(double largura)
        {
            if (largura <= 0)
            {
                throw new ArgumentException("A largura não pode ser menor ou igual a 0!");
            }
            Largura = largura;  
        }

        public void SetComprimento(double comprimento)
        {
            if (comprimento <= 0)
            {
                throw new ArgumentException("O comprimento não pode ser menor ou igual a 0!");
            }
            Comprimento = comprimento;  
        }
   }
}


   