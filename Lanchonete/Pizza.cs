using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class Pizza : Produto
    {
        private List<UsoIngrediente> _ingrediente;
        private UsoIngrediente _molho;
        private UsoIngrediente _recheio;
        private UsoIngrediente _borda;

        public float CalcularPreco()
        {
            return 0;
        }
    }
}
