using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    public class Funcionario
    {
        private String nome;
        private float salario;

        public Funcionario(String nome, float salario)
        {
            this.nome = nome;
            this.salario = salario;
        }
        // Nome de Funcionario
        public String getNome()
        {
            return nome;
        }
        // Salário
        public float getSalario()
        {
            return salario;
        }
        // Aumentar de Salário
        public void aumentarSalario(float porcentagemDeAumento)
        {
            this.salario += this.salario * (1 + (porcentagemDeAumento / 100));
        }
    }

   
}
