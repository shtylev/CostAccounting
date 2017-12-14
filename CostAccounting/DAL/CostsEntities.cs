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
        /// <summary>
        /// Возвращает список расходов, по статье, месяцу и году
        /// </summary>
        /// <param name="idArticle"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static List<Costs> GetCostsForMonthArticle(int idArticle, int month, int year)
        {
            return Config.db.Costs.Where(i => i.IdArticle == idArticle).Where(dm => dm.Date.Month == month).Where(dy => dy.Date.Year == year).ToList();
        }
    }
}
