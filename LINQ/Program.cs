using Aluno;
/*
 Dictionary
• Armazenamento em tabela hash
• Extremamente rápido: inserção, remoção e busca O(1) • A ordem dos elementos não é garantida
• SortedDictionary
• Armazenamento em árvore
• Rápido: inserção, remoção e busca O(log(n)) • Os elementos são armazenados ordenadamente conforme implementação
IComparer<T>
 */
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ordenado e agilidade para adicionar e remover elemento (melhor opção)
            IDictionary<string, Alunos> alunos = new SortedDictionary<string, Alunos>();
            alunos.Add("Turma5", new Alunos("Patrick", 1235));
            alunos.Add("Turma3", new Alunos("Marcelo", 1234));
            alunos.Add("Turma4", new Alunos("André", 1236));
            alunos.Add("Turma2", new Alunos("Gustavo", 1237));
            alunos.Add("Turma1", new Alunos("Ricardp", 1238));
            Console.WriteLine();
            foreach (var item in alunos)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}