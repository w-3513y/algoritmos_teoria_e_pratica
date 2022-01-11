using Exercicios;

namespace algoritmos_teoria_e_pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            var desordenada = new int[] { 5, 2, 4, 6, 1, 3 };
            foreach (var item in desordenada)
            {
                System.Console.Write($"{item},");
            }
            System.Console.WriteLine("");
            Ordenacoes.Ordenacao(desordenada);
            foreach (var item in desordenada)
            {
                System.Console.Write($"{item},");
            }
        }
    }
}
