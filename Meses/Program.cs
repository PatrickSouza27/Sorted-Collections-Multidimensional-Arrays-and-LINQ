
using System.Net.Http.Headers;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mes> mes = new List<Mes>()
            {
                new Mes("Janeiro", 31),
                new Mes("Fevereiro", 28),
                new Mes("Março", 31),
                new Mes("Abril", 30),
                new Mes("Maio", 31),
                new Mes("Junho", 30),
                new Mes("Julho", 31),
                new Mes("Julho", 31),
                new Mes("Agosto", 31),
                new Mes("Setembro", 30),
                new Mes("Outubro", 31),
                new Mes("Novembro", 30),
                new Mes("Dezembro", 31),
            };
            //Ou utilizar fazendo Lambda
            mes.Sort((p1, p2)=> p1.QtdDias.CompareTo(p2.QtdDias));
            foreach(Mes me in mes)
            {
                Console.WriteLine(me);
            }


        }
    }
    class Mes : IComparable
    {
        public string Nome { get; set; }
        public int QtdDias { get; set; }

        public Mes(string nome, int qtdDias)
        {
            Nome = nome;
            QtdDias = qtdDias;
        }
        public int CompareTo(object? obj)
        {
            if(obj is not Mes)
                throw new ArgumentException("Obj Invalido");

            Mes Other = obj as Mes;
            return QtdDias.CompareTo(Other.QtdDias);

        }
        public override string ToString()
        {
            return Nome.ToUpper() + ", " + QtdDias;
        }
    }
}



