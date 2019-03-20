using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoApp.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string EtiquetaPreco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string etiquetaPreco)
        {
            EtiquetaPreco = etiquetaPreco;
        }
    }
}
