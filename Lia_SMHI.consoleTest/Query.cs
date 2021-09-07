using System;
using System.Collections.Generic;
using ZignSec.Integrations.SMHI.Gateway.Services.Models;

namespace Lia_SMHI.consoleTest
{
    internal class Query : IQuery
    {
        public DateTime From{ get; set; }
        public DateTime To { get; set; }
        public string Interval { get; set; }

        public Query(DateTime from, DateTime to)
        {
            From = from;
            To = to;
        }

        public Query(DateTime from, DateTime to, string interval) : this(from, to)
        {
            Interval = interval;
        }

        public IDictionary<string, string> GetQueryParams()
        {
            var dict = new Dictionary<string, string>();
            dict["from"] = From.ToString("yyyy-MM-dd");
            dict["to"] = To.ToString("yyyy-MM-dd");
            if (Interval != null)
                dict["interval"] = Interval;
            return dict;

        }
    }
}
