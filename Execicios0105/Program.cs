namespace Execicios0105
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ex#01 - Thiago Kenj
            int Q; // Q = Quantidade 

            Console.Write("Quantas Maçãs Você Quer Comprar? ");
            Q = int.Parse(Console.ReadLine());

            if (Q < 12)
            {
                Console.WriteLine("O Total é de:" + Q * 1.30 + " Reais");
            }
            else
            {
                Console.WriteLine("O Total é de:" + Q * 1.00 + " Reais");
            }
        }
    }
}