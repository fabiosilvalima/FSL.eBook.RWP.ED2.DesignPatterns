namespace FSL.eBook.RWP.ED2.DesignPatterns.ProxyChapter
{
    public sealed class Calc : 
        ICalc
    {
        public string Message { get; set; }

        public double Calculate()
        {
            Message = "Calculated!";

            return 32 * 9;
        }
    }
}