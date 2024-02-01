using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities.Database
{
    public interface IDatabaseProvider
    {
        IDbConnection CreateConnection(string connectionString);
    }
}
