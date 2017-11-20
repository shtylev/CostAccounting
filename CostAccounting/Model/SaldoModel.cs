using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostAccounting.Model
{
    public class SaldoModel
    {
        public string Name { get; set; }
        public double Sum { get; set; }

        public SaldoModel(string name, double sum)
        {
            Name = name;
            Sum = sum;
        }
    }
}
