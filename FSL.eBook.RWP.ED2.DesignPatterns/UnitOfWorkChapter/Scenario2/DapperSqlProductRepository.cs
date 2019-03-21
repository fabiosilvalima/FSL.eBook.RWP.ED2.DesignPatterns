
namespace FSL.eBook.RWP.ED2.DesignPatterns.UnitOfWorkChapter.Scenario2
{
    public sealed class DapperSqlProductRepository : 
        RepositoryChapter.DapperSqlRepository<Product>, 
        IProductRepository
    {
        public DapperSqlProductRepository()
        {
            TableName = "Product";
        }
    }
}