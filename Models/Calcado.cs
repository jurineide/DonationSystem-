using DonationSystem.Enums;
using DonationSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationSystem.Models
{
    public  class Calcado : Produto {
        public string Material {  get; set; }
        public ETamanhoCalcado Tamanho { get; set; }
        public ECategoriaCalcado Categoria { get; set; }
        public ETipoAjuste TipoAjuste { get; set; }

        public override void ExibirInformacaoesProduto()
        {
            throw new NotImplementedException();
        }
    }
}
