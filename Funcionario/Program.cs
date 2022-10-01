namespace Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("Bem vindo! Atenção o seu resultado de benefício na empresa!");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("");

            Funcionario pessoa = new Funcionario("Takeda", 2200);
            Console.WriteLine("Nome: " + pessoa.getNome() + ", Salário Atual:  " + pessoa.getSalario());
            pessoa.aumentarSalario(10);

            Console.WriteLine("Nome: " + pessoa.getNome() + ", Salário vai aumentar 10% para: " + pessoa.getSalario ());
            Console.WriteLine("");

            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
        }
    }
}