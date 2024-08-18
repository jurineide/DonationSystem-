using DonationSystem.Enums;
using DonationSystem.Model;
using DonationSystem.Models;

namespace DonationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Roupa produto = new Roupa();
            produto.Nome = "Jaqueta";
            produto.Descricao = "Jaqueta feminina";
            produto.Genero = "Feminino";
            produto.Tamanho = ETamanhoRoupa.Doze;
            produto.Categoria = ECategoriaRoupa.Camisetas;

            Console.WriteLine(produto.ExibirDados());
        }
    }
}