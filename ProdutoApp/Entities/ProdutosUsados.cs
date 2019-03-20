using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoApp.Entities
{
    class ProdutosUsados
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutosUsados()
        {
        }

        public ProdutosUsados(DateTime dataFabricacao)
        {
            DataFabricacao = dataFabricacao;
        }
    }
}
