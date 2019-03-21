using Dapper;

namespace FSL.eBook.RWP.ED2.DesignPatterns.RepositoryChapter
{
    public class DapperSqlRepository<TModel> : 
        SqlRepository
    {
        public string TableName { get; set; }

        public virtual void Insert(
            TModel model)
        {
            var command = $"INSERT INTO {TableName} (Id, Name) VALUES (@Id, @Name)";

            Database.Execute(command, model);
        }
    }
}