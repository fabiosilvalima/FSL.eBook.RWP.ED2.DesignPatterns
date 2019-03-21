namespace FSL.eBook.RWP.ED2.DesignPatterns.RepositoryChapter
{
    public interface IEntityRepository<TModel>
    {
        void Insert(
            TModel model);
    }
}
