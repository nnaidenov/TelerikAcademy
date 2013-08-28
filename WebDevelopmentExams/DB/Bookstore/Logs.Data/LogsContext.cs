using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logs.Models;

namespace Logs.Data
{
    public class LogsContext : DbContext
    {
        public LogsContext()
            : base("LogsDBConnection")
        {
        }

        public DbSet<SearchLog> SearchLogs { get; set; }
    }
}
