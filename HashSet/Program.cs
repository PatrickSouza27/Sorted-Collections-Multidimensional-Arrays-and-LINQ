using Aluno;
using System.Net.Http.Headers;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mesma coisa, com o Hashset vc tem a lista, mas sem ordenação
            ISet<string> set = new HashSet<string>()
            {
                "Vanessa",
                "Ana",
                "Patrick",
                "Raissa",
                "Diego"
                
            };
            set.Add("Fabio");
            set.Add("Ricardo");

            //Repetir o Fabio não ira aparecer na lista
            set.Add("Fabio");
            //mas se repetir o fabio com letras maiusculas, ele funciona
            set.Add("FABIO");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }


            ISet<int> number = new HashSet<int>()
            {
                1,
                3,
                4,
                12
            };
            ISet<int> number2 = new HashSet<int>()
            {
                1,
                2,
                3,
                4,
                5
            };
            //Sem Ordenação, não é muito bom, o melhor nesse caso é o SortedSet
            foreach (var item in number.Union(number2))
            {
                Console.WriteLine(item);
            }
        }
    }
}


