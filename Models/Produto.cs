using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationSystem.Model{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Genero { get; set; }
        public string Foto { get; set; }
        public bool Status { get; set; }
        public virtual string ExibirDados()
        {
            string mensagem;
            mensagem = $"Nome: {Nome} \nDescrição: {Descricao} \nGenero: {Genero}";
            return mensagem;

        }
        public abstract void ExibirInformacaoesProduto();
    }
}
