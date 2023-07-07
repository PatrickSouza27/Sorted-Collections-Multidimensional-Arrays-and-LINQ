
using System.Net.Http.Headers;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mesma coisa, com o Hashset vc tem a lista, mas sem ordenação
            SortedSet<string> set = new SortedSet<string>(new VerificaLetrasMaiusculas())
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
            //mas se repetir o fabio com letras maiusculas, ele funciona, já com o SORTEDSet // 
            set.Add("FABIO");

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }


            ISet<int> number = new SortedSet<int>()
            {
                1,
                3,
                4,
                12

            };
            ISet<int> number2 = new SortedSet<int>()
            {
                1,
                2,
                3,
                4,
                5,

            };
            //Sem Ordenação, não é muito bom, o melhor nesse caso é o SortedSet
            //Ordernar por ordem decrescente/ crescente Order() 1, 2, 3, 4, 5 12,  OrderDescending -> 12, 5, 4, 3, 2, 1
            //foreach (var item in number.Union(number2).Order())
            //foreach (var item in number.Union(number2).OrderDescending())
            foreach (var item in number.Union(number2))
            {
                Console.WriteLine(item);
            }

            //Coleção de numeros é um subconjunto de outra coleção, se pertence a outro aluno
            bool pertenceALista = number.IsSubsetOf(number2);
            //aqui ele pega a segunda lista como comparação
            Console.WriteLine(pertenceALista); // nesse caso é falso, pq existe numeros diferentes na lista e lista 2 q seria o 12
            // 1 ok, 3ok, 4ok 12no - false


            //Coleção de numeros é um Superconjunto, se uma lista está contido dentro do outro
            //aqui ele pega a lista 1 como comparação
            bool pertenceALista2 = number.IsSupersetOf(number2);
            Console.WriteLine(pertenceALista2);

            //ver se todos os numeros são os mesmos
            bool pertenceALista3 = number.SetEquals(number2);
            Console.WriteLine(pertenceALista3);

            //remover oque está o outro conjunto(number2) q faz parte do meu conjunto principal(number)
            number.ExceptWith(number2);
            //é tipo void
            Console.WriteLine(number);

            //Interseguição entre os dois conjuntos
            number.IntersectWith(number2);

            //quais são a interseguição que está entre o conjunto number, ou number2
            number.SymmetricExceptWith(number2);

            //União de conjuntos
            number.UnionWith(number2);


            //quando vc coloca com o With, ele pega o number e joga implementa direto, exemplo number = number.Union(number2)

            


        }
    }
}



