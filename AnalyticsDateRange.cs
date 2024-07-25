using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Management_System
{
    internal class AnalyticsDateRange
    {
        public static DateTime DateStart { get; set; } = DateTime.Now.AddDays(-7);
        public static DateTime DateEnd { get; set; } = DateTime.Now;
    }
}
