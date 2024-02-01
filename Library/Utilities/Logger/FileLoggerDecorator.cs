using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities.Logger
{
    public class FileLoggerDecorator : LoggerDecorator
    {
        private string _filePath;

        public FileLoggerDecorator(ILogger logger, string filePath) : base(logger)
        {
            _filePath = filePath;
        }

        public override void LogQuery(string sql, List<object> parameters)
        {
            try
            {
                string parametersString;
                if (parameters != null)
                {
                    parametersString = ((BaseLogger)_logger).ReplaceParameters(sql, parameters);
                }else
                {
                    parametersString = sql;
                }

                File.AppendAllText(_filePath, $"{DateTime.Now} - Logged Query:  {parametersString}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška prilikom logovanja: {ex.Message}");
            }
        }
    }


}
