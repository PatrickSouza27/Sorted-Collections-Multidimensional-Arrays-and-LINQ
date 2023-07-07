
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
            mes.Sort((p1, p2) => p1.QtdDias.CompareTo(p2.QtdDias));


            //WHERE E ORDERBY
            //utilizando o Linq // pegando somente meses q tem mais de 30 dias e ordenando de forma decrescente pelo nome
            foreach (Mes me in mes.Where(x=> x.QtdDias > 30).OrderByDescending(x=> x.Nome))
            {
                Console.WriteLine(me);
            }

            //SELECT
            //Retornar somente o Nome do Mês, n quero os dias
            foreach (string me in mes.Where(x => x.QtdDias > 30).OrderByDescending(x => x.Nome).Select(x=> x.Nome.ToUpper()))
            {
                Console.WriteLine(me);
            }

            // Pegar o primeiro trimestre
            var trimestre = mes.Take(3);

            //pegar os meses depois do primeiro trimestre
            var depoisTrimestre = mes.Skip(3);

            //Não pegar o ultimo mes
            var sem_pegar_o_ultimo_valor = mes.Take(mes.Count - 1);

            //pegar somente os 3 ultimos meses
            var pegando_os_3_ultimos_valores = mes.Skip(mes.Count - 3);

            //pegando o segundo trimestre
            var segundo_trimestre = mes.Skip(6).Take(3);

            //pegando todos os meses até achar um que tenha e letra 'S', quando achar, quero parar / começa com a letra S
            //TAKEWhile
            var ate_encontrar_S = mes.TakeWhile(x=> x.Nome.StartsWith("S"));

            //Pular os meses até que o mês comece com a letra 'S'
            //SKIPWhile
            var pularmeses = mes.SkipWhile(x => x.Nome.StartsWith("S"));



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
            if (obj is not Mes)
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



