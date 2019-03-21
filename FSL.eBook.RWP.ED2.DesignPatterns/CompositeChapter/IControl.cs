namespace FSL.eBook.RWP.ED2.DesignPatterns.CompositeChapter
{
    public interface IControl
    {
        int Id { get; set; }
        string Render();
    }
}