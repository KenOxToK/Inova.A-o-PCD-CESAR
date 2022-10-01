using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Disciplina
    {
        private string DI;

        public Disciplina(String DI)
        {        
            this.DI = DI;       
        }
        public String getDI()
        {
            return DI;
        }
    }
}
