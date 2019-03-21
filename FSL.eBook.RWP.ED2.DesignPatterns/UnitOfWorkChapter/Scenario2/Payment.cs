namespace FSL.eBook.RWP.ED2.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public sealed class Payment : 
        IEntity
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? ProductId { get; internal set; }

        public void Insert()
        {
            // same logic of product model
        }
    }
}