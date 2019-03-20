using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoApp.Entities
{
    class ProdutosImportados : Produto
    {
        public double VlrAlfandega { get; set; }

        public ProdutosImportados()
        {
        }

        public ProdutosImportados(double perco, double vlrAlfandega) 
            : base(preco)
        {
            VlrAlfandega = vlrAlfandega;
        }
        public double Total()
        {
            return preco + VlrAlfandega;
        }


    }
}
