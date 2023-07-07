using System;
/*Um site de internet registra um log de acessos dos usuários. Umregistro de log consiste no nome de usuário e o instante em que ousuário acessou o site no padrão ISO 8601, separados por espaço,
conforme exemplo. Fazer um programa que leia o log de acessos apartir de um arquivo, e daí informe quantos usuários distintosacessaram o site.*/


/*
amanda 2020-08-26T20:45:08
alex86 2020-08-26T21:49:37
bobbrown 2020-08-27T03:19:13
amanda 2020-08-27T08:11:00
jeniffer3 2020-08-27T09:19:24
alex86 2020-08-27T22:39:52
amanda 2020-08-28T07:42:19
*/

namespace Exercicio
{
    class Program
    {
        static void Main()
        {
            HashSet<IsoName> x = new HashSet<IsoName>();
            string Caminho = @"C:\Users\Usuario\Documents\teste\Sla.txt";
            string[] Linha = File.ReadAllText(Caminho).Split("\n");
            foreach (string l in Linha)
            {
                string[] partes = l.Split(" ");
                x.Add(new IsoName(partes[0], partes[1]));
            }
            Console.WriteLine("Users: " + x.Count);
            foreach (IsoName j in x)
            {
                Console.WriteLine(j);
            }
        }
    }

    class IsoName
    {
        public string? Name { get; set; }
        public string? Iso { get; set; }

        public IsoName()
        {

        }
        public IsoName(string? name, string? iso)
        {
            Name = name;
            Iso = iso;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is not IsoName)
            {
                throw new Exception("Error! Objetos Diferentes!");
            }
            IsoName other = (IsoName)obj;
            return Name.Equals(other.Name);
        }
        public override string ToString()
        {
            return Name + " " + Iso;
        }
    }
}