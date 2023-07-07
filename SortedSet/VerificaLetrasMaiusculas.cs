namespace LINQ
{
    public class VerificaLetrasMaiusculas : IComparer<string>
    {
        public int Compare(string? x, string? y)
            => string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
    }
}