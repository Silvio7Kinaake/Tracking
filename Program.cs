using Tracking.Entidades;

internal class Program
{
    
    /* VALIDAÇÃO PRODUTO #############################

    private static void Main(string[] args)
    {
    string descricao = "Vid Gol";
    double preco = 10;
    double peso = 3.5;
    double altura = 2.5;
    double largura = 2.8;
    double comprimento  = 3.9;
    var produto = new Produto(descricao, preco, peso, altura, largura, comprimento);
    Console.WriteLine(produto.Descricao);
    Console.WriteLine(produto.Preco);
    Console.WriteLine(produto.Peso);
    Console.WriteLine(produto.Altura);
    Console.WriteLine(produto.Largura);
    Console.WriteLine(produto.Comprimento);
    }
    */

    private static void Main(string[] args)
    {
        string razaosocial = "Kinaake Transportes";
        string nomefantasia = "Fex transportes";
        string cnpj = "28141158000109";
        string inscricaoestadual = ("339369369");
        var tranportadora = new Transportadora( razaosocial, nomefantasia, cnpj, inscricaoestadual);
        Console.WriteLine(tranportadora.RazaoSocial);
        Console.WriteLine(tranportadora.NomeFantasia);
        Console.WriteLine(tranportadora.Cnpj);
        Console.WriteLine(tranportadora.InscricaoEstadual);
    }
 
}
