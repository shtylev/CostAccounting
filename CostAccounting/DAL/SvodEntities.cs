using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostAccounting.DAL;
using CostAccounting.Model_Data;

namespace CostAccounting.DAL
{
    public static class SvodEntities
    {
        /// <summary>
        /// Возвращает общую сумму за месяц, по статье и году
        /// </summary>
        /// <param name="idArticle"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static int GetSumForMonthArticle(int idArticle, int month, int year)
        {
            List<Costs> costs = CostsEntities.GetCostsForMonthArticle(idArticle, month, year);
            
            if(costs.Count != 0)
            {
                double sum = costs.Sum(s => s.Sum);
                return Convert.ToInt32(Math.Round(sum, 0));
            }
            return 0;
        }
        public static int GetTotalSumForMonth(int month, int year)
        {
            return Convert.ToInt32(Math.Round(CostsEntities.GetTotalSumForMonth(month, year), 0));
        }
    }
}
