namespace CarroViagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro Camaro = new Carro(10, 40);
            RC estadoCarro = RC.CA;

            int distancia;
            if (Camaro.AG(20) == AC.COK)
            {
                while (estadoCarro == RC.CA)
                {
                    try
                    {
                        Console.WriteLine("Qual a distancia pecorrida:");
                        distancia = int.Parse(Console.ReadLine());
                        estadoCarro = Camaro.Andar(distancia);
                        Console.WriteLine("O meu combustivel atual e " + Camaro.OG().ToString("F1"));
                        Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadKey();
                        Console.Clear();    
                    }
                }
                Console.WriteLine("Estado final do carro:" + estadoCarro);
            }         
        }
    }
}