using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Lanche:Produto
    {
        private List<UsoIngrediente> _recheio;
        private UsoIngrediente _pao;
        private UsoIngrediente _molho;

        public float CalcularPreco()
        {
            return 0;
        }
    }
}
