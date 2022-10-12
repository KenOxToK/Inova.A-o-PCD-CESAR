namespace Execicios0101
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Informe o número 1: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o número 2: ");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Valor 1 é maior " + num1);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Erro, valores Iguais");
            }
            else
            {
                Console.WriteLine("Valor 2 é maior " + num2);
            }
        }
    }
}