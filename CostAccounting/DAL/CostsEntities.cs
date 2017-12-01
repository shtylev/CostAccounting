using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostAccounting.Model_Data;

namespace CostAccounting.DAL
{
    public static class CostsEntities
    {
        public static List<Costs> GetCosts()
        {
            return Config.db.Costs.ToList();
        }
    }
}
