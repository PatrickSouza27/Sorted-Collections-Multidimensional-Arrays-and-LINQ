using System.Net.Http.Headers;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[,] resultado = new string[3, 3]
            //{
            //    {"Alemanha", "Espanha", "Italia" },
            //    {"Argentina", "Holanda", "França" },
            //    {"Holanda", "Alemanha", "Alemanha" }
            //};
            string[,] resultado = new string[3, 3];

            resultado[0, 0] = "Alemanha";
            resultado[1, 0] = "Argentina";
            resultado[2, 0] = "Holanda";

            resultado[0, 1] = "Espanha";
            resultado[1, 1] = "Holanda";
            resultado[2, 1] = "Alemanha";

            resultado[0, 2] = "Italia";
            resultado[1, 2] = "França";
            resultado[2, 2] = "Alemanha";

            /*
             * Resultado:
            2014        2010        2006
            Alemanha    Espanha     Italia
            Argentina   Holanda     França
            Holanda     Alemanha    Alemanha*/
            for (int copa = 0; copa < 3; copa++)
            {
                int ano = 2014 - copa * 4;
                //PadRight -> Para tabular exemplo   ano1 tabulação ano2 tabulação ano3
                Console.Write(ano.ToString().PadRight(12));
            }
            Console.WriteLine();

            for(int posicao = 0; posicao < 3; posicao++)
            {
                for (int copa = 0; copa < 3; copa++)
                {
                    Console.Write(resultado[posicao, copa].ToString().PadRight(12));
                }
                Console.WriteLine();
            }

            //string[][] familias = new string[3][];
            //{ 
            //    "Fred", "Wilma", "Pedrita",
            //    "Homer", "Marge", "Lisa", "Bart", "Maggie",
            //    "Florinda", "Kiko"

            //};

            //eu sei quantas linhas vai ter, mas eu n sei quantos membros de cada familia vai ter
            //Array dentiado / retilhado (Array de Arrays)
            string[][] familias = new string[3][];
            familias[0] = new string[] { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] { "Homer", "Marge", "Lisa", "Bart", "Maggie" };
            familias[2] = new string[] { "Florinda", "Kiko" };

            foreach(var familia in familias)
            {
                Console.WriteLine(string.Join(",", familia));
            }


        }
    }
}


