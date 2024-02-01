using Library.Entities;
using Library.Utilities;
using Library.Utilities.Database;
using System;
using System.Data;
using System.Data.Common;
using Library.Utilities.Logger;

namespace Library.Utilities.Database
{
    public sealed class Database
    {
        private static Database instance;
        private IDbConnection connection;
        private ILogger logger;

        string logFilePath = "log.txt";

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    var config = TxtParser.ParseTxtFile("config.txt");

                    instance = new Database(config["connection"]);
                }

                return instance;
            }
        }

        private Database(string connectionString) 
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();

            connection = DatabaseProviderFactory.CreateProvider(connectionString);
            connection.Open();

            ILogger baseLogger = new BaseLogger();
            logger = new FileLoggerDecorator(baseLogger, logFilePath);
        }

        public int Update(string sql, List<object> parameters)
        {
            int rowsUpdated = 0;

            try
            {
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    if (parameters != null)
                    {
                        int parameterIndex = 0;

                        foreach (object param in parameters)
                        {
                            IDbDataParameter parameter = command.CreateParameter();
                            parameter.ParameterName = $"@{parameterIndex}";
                            parameter.Value = param;
                            command.Parameters.Add(parameter);

                            parameterIndex++;
                        }
                    }


                    rowsUpdated = command.ExecuteNonQuery();


                    logger.LogQuery(sql, parameters);

                }

            }


            catch (Exception ex)
            {
                // Handle the exception here, you might want to log it or throw a custom exception
                Console.WriteLine($"Error in Update method: {ex.Message}");
                // Optionally re-throw the exception if you want the calling code to be aware of it
                throw;
            }

            return rowsUpdated;
        }

        public List<Dictionary<string, object>> Query(string sql, List<object> parameters)
        {
            List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();

            using (IDbCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;

                if (parameters != null)
                {
                    int parameterIndex = 0;

                    foreach (object param in parameters)
                    {
                        IDbDataParameter parameter = command.CreateParameter();
                        parameter.ParameterName = $"@{parameterIndex}";
                        parameter.Value = param;

                        command.Parameters.Add(parameter);

                        parameterIndex++;
                    }
                }

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> result = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string name = reader.GetName(i);
                            object value = reader.GetValue(i);

                            result[name] = value;
                        }

                        results.Add(result);
                    }
                }

                logger.LogQuery(sql, parameters);

            }

            return results;
        }
    }
}
