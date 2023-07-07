using System;
/*
 Em um portal de cursos online, cada usuário possui um código único, representado porum número inteiro.
Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode sematricular em quantos cursos quiser. Assim, o número total de alunos de um instrutor nãoé simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haveralunos repetidos em mais de um curso.
O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar aquantidade total e alunos dele, conforme exemplo.
 */

namespace x
{
    class Program
    {
        static HashSet<Aluno> set = new HashSet<Aluno>();
        static void AdicionarLista(int qtd)
        {
            for (int i = 0; i < qtd; i++)
            {
                int Id = int.Parse(Console.ReadLine());
                set.Add(new Aluno(Id));
            }
        }
        static void Main()
        {
            Console.Write("How many students for course A: ");
            int qtd = int.Parse(Console.ReadLine());
            AdicionarLista(qtd);
            Console.Write("How many students for course B: ");
            qtd = int.Parse(Console.ReadLine());
            AdicionarLista(qtd);
            Console.Write("How many students for course C: ");
            qtd = int.Parse(Console.ReadLine());
            AdicionarLista(qtd);
            Console.Write("Total students: {0}", set.Count);
        }
    }
    class Aluno
    {
        public int Id { get; private set; }
        public Aluno()
        {

        }
        public Aluno(int id)
        {
            Id = id;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is not Aluno)
            {
                throw new Exception("Error!");
            }
            Aluno other = (Aluno)obj;
            return Id.Equals(other.Id);
        }
    }
}
