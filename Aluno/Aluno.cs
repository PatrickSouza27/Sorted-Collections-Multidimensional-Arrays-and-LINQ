namespace Aluno
{
    public class Alunos
    {
        public string Nome { get; set; }
        public int NumeroMatricula { get; set; }
        public Alunos() { }
        public Alunos(string nome, int num)
        {
            Nome = nome;
            NumeroMatricula = num;
        }
        public override string ToString() => Nome + ", " + NumeroMatricula;
    }
}