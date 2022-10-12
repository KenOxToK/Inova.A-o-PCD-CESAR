namespace Execicios0103
{
    public class Program
    {       
            static void Main(string[] args)
            {
               
                int A, B, C;

                A = 10;
                B = 20;
                C = A;
                A = B;
                B = C;

                Console.WriteLine("A: " + A + " e B: " + B);
            }
    }
}