namespace FSL.eBook.RWP.ED2.DesignPatterns.ProxyChapter
{
    public interface ICalc
    {
        double Calculate();
        string Message { get; set; }
    }
}