
namespace FSL.eBook.RWP.ED2.DesignPatterns.RepositoryChapter
{
    public sealed class DapperSqlProductRepository : 
        DapperSqlRepository<Product>, 
        IProductRepository
    {
        public DapperSqlProductRepository()
        {
            TableName = "Product";
        }
    }
}