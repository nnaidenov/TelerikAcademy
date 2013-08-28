using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logs.Models;
using Logs.Data;

namespace Logs.Client
{
    public static class LogsMaker
    {
        static void Main(string[] args)
        {
        }

        public static void AddLog(string xml)
        {
            LogsContext context = new LogsContext();

            SearchLog myLog = new SearchLog();
            myLog.Date = DateTime.Now;
            myLog.QueryXml = xml.ToString();

            context.SearchLogs.Add(myLog);
            context.SaveChanges();
        }
    }
}
