using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WebAPI.Services
{
    public class DataAccessService
    {
        private readonly Dictionary<string, string> connectionStrings;
        public string DatabaseName { get; set; }
        public DataAccessService(Dictionary<string,string> connectionStrings)
        {
            this.connectionStrings = connectionStrings;
        }
        public static SqlCommand SelectAllCommand(string tableName)
        {
            SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM [dbo].[{tableName}] WITH (nolock)");
            
            return command;
        }

        public SqlDataReader GetSqlReader(SqlCommand sqlCommand)
        {
            SqlConnection connection = new SqlConnection(connectionStrings[DatabaseName]);
            connection.Open();
            sqlCommand.Connection = connection;

            // When the user of this calls myReader.Close() method the underlying database connection is also to be closed.
            SqlDataReader reader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
    }
}
