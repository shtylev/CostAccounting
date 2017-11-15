using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostAccounting.Model_Data;

namespace CostAccounting.DAL
{
    static public class SaldoEntities
    {
        public static List<Saldo> GetSaldosStartingPeriod()
        {
            return Config.db.Saldo.Where(t => t.Type == (int)Dictionary.TypeSaldo.saldoStartingPeriod).ToList();
        }
    }
}
