namespace Execicios0104
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            int A, M, D;

            Console.Write("Entre com sua idade somente em anos: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Entre com sua idade somente em meses: ");
            M = int.Parse(Console.ReadLine());

            Console.Write("Entre com sua idade somente em dias: ");
            D = int.Parse(Console.ReadLine());

            D = (D + (A * 365) + (M * 30));

            Console.WriteLine("Sua idade em dias é: " + D);
        }
    }
}