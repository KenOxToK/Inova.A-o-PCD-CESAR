namespace Execicios0106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // hn = Hora normaos , he = Hora Extras 
            // sl = Salario_liquido, sb = salario_bruto ip = imposto
            int hn, he;
            double sl, sb, ip;

            Console.Write("Quantas horas foram trabalhadas? ");
            hn = int.Parse(Console.ReadLine());

            Console.Write("Quantas horas-extras foram feitas? ");
            he = int.Parse(Console.ReadLine());


            sb = (hn * 10 + he * 15);
            ip = (10 / 100) * sb;
            sl = (0.90 * sb);

            Console.WriteLine("Salário Bruto: R$ " + sb + 12 / 2);
            Console.WriteLine("Imposto: R$ " + ip + 10 / 2);
            Console.WriteLine("Salário Líquido: R$ " + sl + 12 / 2);
        }
    }
}