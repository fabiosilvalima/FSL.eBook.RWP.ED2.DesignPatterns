namespace FSL.eBook.RWP.ED2.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public interface IUnitOfWork
    {
        void Add(
            IEntity entity);

        void Commit();
    }
}
