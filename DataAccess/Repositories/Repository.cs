using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public abstract class Repository
    {
        private readonly string ConnectionString;
        public Repository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["connDBTIENDA"].ToString();
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
