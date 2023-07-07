using Aluno;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sem Ordenação (Dictionary)!
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();
            alunos.Add("Turma1", new Aluno("Patrick", 1235));
            alunos.Add("Turma2", new Aluno("Marcelo", 1234));
            alunos.Add("Turma3", new Aluno("André", 1236));
            alunos.Add("Turma4", new Aluno("Gustavo", 1237));
            alunos.Add("Turma5", new Aluno("Ricardp", 1238));
            foreach(var item in alunos)
            {
                Console.WriteLine(item);
            }*/

            //Com Ordenação (SortedList) -> Ele irá ordenar pela Key
            IDictionary<string, Alunos> alunos = new SortedList<string, Alunos>();
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