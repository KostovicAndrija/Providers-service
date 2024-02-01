using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities.Logger
{
    public interface ILogger
    {
        void LogQuery(string query, List<object> parameters);
    }

}
