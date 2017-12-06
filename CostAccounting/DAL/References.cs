using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostAccounting.DAL
{
    public class References
    {
        public enum TypeSaldo
        {
            startingPeriod = 1,         //сальдо на начало периода
            endPeriod = 2,              //сальдо на конец периода
            totalSumForEndPeriod = 3,   //общие суммы, для сальдо на конец периода
        }
    }
}
