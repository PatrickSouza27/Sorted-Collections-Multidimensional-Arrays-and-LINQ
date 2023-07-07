using System;
/*
 Na contagem de votos de uma eleição, são gerados vários registrosde votação contendo o nome do candidato e a quantidade de votos(formato .csv) que ele obteve em uma urna de votação. Você devefazer um programa para ler os registros de votação a partir de umarquivo, e daí gerar um relatório consolidado com os totais de cadacandidato.
 */

/*
Alex Blue,15
Maria Green,22
Bob Brown,21
Alex Blue,30
Bob Brown,15
Maria Green,27
Maria Green,22
Bob Brown,25
Alex Blue,31
 */

/*Resposta:
Alex Blue: 76
Maria Green: 71
Bob Brown: 61
 */
namespace x
{
    class Program
    {
        static void Main()
        {

            string caminho = @"C:\Users\Usuario\Documents\teste\ExercFicDic\Arquivo.txt";
            string[] Linha = File.ReadAllText(caminho).Split("\n");
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string L in Linha)
            {
                string[] p = L.Split(',');
                string nome = p[0];
                int votos = int.Parse(p[1]);
                if (dic.ContainsKey(nome))
                {
                    dic[nome] += votos;
                }
                else
                {
                    dic[nome] = votos;
                }

            }
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

        }
    }
}