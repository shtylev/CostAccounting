using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostAccounting.Model
{
    public class CostModel
    {
        public int Id { get; set; }
        public string NameAnalytic { get; set; }
        public string NameArticle { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public double Sum { get; set; }

        public CostModel()
        {

        }
        public CostModel(int id, string nameAnalytic, string nameArticle, DateTime date, double sum, string message)
        {
            Id = id;
            NameAnalytic = nameAnalytic;
            NameArticle = nameArticle;
            Date = date;
            Sum = sum;
            Message = message;
        }
    }
}
