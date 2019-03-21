using FSL.eBook.RWP.ED2.DesignPatterns.RepositoryChapter;

namespace FSL.eBook.RWP.ED2.DesignPatterns.UnitOfWorkChapter.Scenario1
{
    public sealed class DapperSqlPaymentRepository : 
        DapperSqlRepository<Payment>, 
        IPaymentRepository
    {
        public DapperSqlPaymentRepository()
        {
            TableName = "Payment";
        }
    }
}