namespace FSL.eBook.RWP.ED2.DesignPatterns.CompositeChapter
{
    public class Control : 
        IControl
    {
        public int Id { get; set; }

        public string Render()
        {
            return $"control {Id}";
        }
    }
}