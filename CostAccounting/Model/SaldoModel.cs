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
        public int? IdArticle { get; set; }
        public int? IdAnalytic { get; set; }
        public int Id { get; set; }

        public SaldoModel(string name, double sum, int? idArticle, int? idAnalytic, int id)
        {
            Name = name;
            Sum = sum;
            IdAnalytic = idAnalytic;
            IdArticle = idArticle;
            Id = id;
        }
    }
}
