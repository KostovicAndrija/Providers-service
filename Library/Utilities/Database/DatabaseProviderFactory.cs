using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities.Database
{
    public class DatabaseProviderFactory
    {
    public static IDbConnection CreateProvider(string connectionString)
    {
        IDatabaseProvider provider = null;

        if (IsSqliteConnectionString(connectionString))
        {
            provider = new SqliteDatabaseProvider();
        }
        else if (IsMySqlConnectionString(connectionString))
        {
            provider = new MySqlConnectionProvider();
        }
        else
        {
            throw new Exception("Database not recognized!");
        }

        return provider.CreateConnection(connectionString);
    }

    private static bool IsSqliteConnectionString(string connectionString)
    {
        // Check if the connection string indicates SQLite (you can adjust this check based on your actual connection string)
        return connectionString.ToLower().Contains("data source");
    }

    private static bool IsMySqlConnectionString(string connectionString)
    {
        // Check if the connection string indicates MySQL (you can adjust this check based on your actual connection string)
        return connectionString.ToLower().Contains("server");
    }
    }
}
