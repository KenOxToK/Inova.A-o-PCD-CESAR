namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("               Bem vindo(a)! A Sistema de Escola           ");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            Console.WriteLine("");

            Disciplina material = new Disciplina("Analise e desenvolvimento de sistemas");
            Console.WriteLine("Disciplina: " + material.getDI());
            Console.WriteLine("");

            Professor profissonal = new Professor("Fabio");
            Console.WriteLine("Professor: " + profissonal.getNP());
            Console.WriteLine("");

            Aluno estudante = new Aluno ("Thoma");
            Console.WriteLine("Nome do aluno: " + estudante.getNA()); 

            //"\t" + "Professor: " + estudante.getNP() + "\t" + "Disciplina :" + estudante.getDI() );

            Console.WriteLine("");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
        }
    }
}