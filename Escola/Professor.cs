using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public class Professor
    {
        private string NP;

        public Professor(String NP)
        {
            this.NP = NP;
        }
        public String getNP()
        {
            return NP;
        }
    }
}
