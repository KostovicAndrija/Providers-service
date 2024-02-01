using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities.Logger
{
    public class BaseLogger : ILogger
    {

        private readonly string LogFilePath = "log.txt";


        public void LogQuery(string query, List<object> parameters = null)
        {
            try
            {
                string logMessage;

                if(parameters != null)
                {
                    logMessage = $"{DateTime.Now} - Query executed: {ReplaceParameters(query, parameters)}";
                }else
                {
                    logMessage = $"{DateTime.Now} - Query executed: {query}";
                }

                using (StreamWriter sw = File.AppendText(LogFilePath))
                {
                    sw.WriteLine(logMessage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom logovanja: {ex.Message}");
            }
        }


        internal string ReplaceParameters(string query, List<object> parameters)
        {
            string modifiedQuery = query;

            for (int i = 0; i < parameters.Count; i++)
            {
                string parameterName = $"@{i}";
                object parameterValue = parameters[i];

                modifiedQuery = modifiedQuery.Replace(parameterName, parameterValue.ToString());
            }

            return modifiedQuery;
        }
    }


}
