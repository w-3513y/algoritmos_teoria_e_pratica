namespace Exercicios
{

    public class Ordenacoes
    {
        public static void Ordenacao(int[] list)
        {
            for (var j = 1; j < list.Length; j++)
            {
                var key = list[j];
                var switcher = j - 1;
                while (switcher >= 0 && list[switcher] > key)
                {
                    list[switcher + 1] = list[switcher];
                    switcher--;
                }
                list[switcher + 1] = key;
            }
        }

    }
}
