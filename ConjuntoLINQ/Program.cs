using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjunto utilizando LINQ (Operações de conjunto)

            string[] seq1 = { "Janeiro", "Fevereiro", "março" };
            string[] seq2 = { "Fevereiro", "Março", "Abril" };

            //aqui pego todos os elementos e junto
            var consulta = seq1.Concat(seq2).ToList();
            consulta.ForEach(x=> Console.WriteLine(x));

            Console.WriteLine();

            //Não temos a repetição de "Fevereiro", pois a palavra é exatamente igual
            var sequenciaUnion = seq1.Union(seq2).ToList();
            sequenciaUnion.ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            //Não temos a repetição de "Fevereiro", e nem "Março/março" pois são a mesma palavra apesar das letras maiuscula de minuscula
            //para manter nesse caso a palavra com a letra minuscula, só comparar a segunda lista seq2.Union(seq1, ...)
            var sequenciaUnion_SemLetra_Minuscula = seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase).ToList();
            sequenciaUnion_SemLetra_Minuscula.ForEach(x => Console.WriteLine(x));

            Console.WriteLine();

            //Para pegar a interseguição das duas sequencia:  a palavra q se repete 
            var Interseguicao = seq1.Intersect(seq2, StringComparer.InvariantCultureIgnoreCase).ToList();
            Interseguicao.ForEach(x => Console.WriteLine(x));

            //pegar tudo que tem na primeira sequencia seq1 que não tem na segunda sequencia
            var Execeao = seq1.Except(seq2, StringComparer.InvariantCultureIgnoreCase).ToList();
            Execeao.ForEach(x => Console.WriteLine(x));
        }
    }
}