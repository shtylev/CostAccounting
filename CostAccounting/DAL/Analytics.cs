using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostAccounting.Model_Data;

namespace CostAccounting.DAL
{
    public static class Analytics
    {
        public static List<Model_Data.Analytics> GetAnalitics()
        {
            return Config.db.Analytics.OrderBy(n => n.Name).ToList();
        }
    }
}
