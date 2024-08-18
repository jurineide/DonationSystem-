using DonationSystem.Enums;
using DonationSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationSystem.Models
{
    public class Roupa : Produto {
        public ECategoriaRoupa Categoria { get; set; }
        public ETamanhoRoupa Tamanho { get; set; }

        public string Material { get; set; }
        public EComprimentoRoupa TipoComprimento {  get; set; }

        public override string ExibirDados()
        {
            string mensagem =  base.ExibirDados();
             mensagem += $"\nCategoria: {Categoria} \nTamanho: {Tamanho}";

            return mensagem;
        }

        public override void ExibirInformacaoesProduto()
        {
            throw new NotImplementedException();
        }
    }
}
