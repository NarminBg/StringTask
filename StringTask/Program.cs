namespace StringTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encyription
            //Console.WriteLine(CeaserAndTimeIssue.Ceaser(1, "abcdsf."));
            #endregion
            #region Decryption
            //Console.WriteLine(CeaserAndTimeIssue.CeaserMethod());
            #endregion
            #region Time
            Console.WriteLine(CeaserAndTimeIssue.TimeIssue("14:24:43", "18:32:45", out string time3)); 
            #endregion
        }
    }
}