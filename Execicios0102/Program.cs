namespace Execicios0102
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Ex#01 - Thiago Kenj
            int num1, num2;

            Console.Write("Entre com 1 Valor: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com 1 Valor: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Erro, Valores Iguais");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("A ordem crescente é: " + num2 + " e " + num1);
            }
            else
            {
                Console.WriteLine("A ordem crescente é: " + num1 + " e " + num2);
            }
        }
    }
}