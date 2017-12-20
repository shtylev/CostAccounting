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
        /// <summary>
        /// Возвращает список расходов, за период, по определенным аналитикам и статьям
        /// </summary>
        /// <param name="analytics"></param>
        /// <param name="articles"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public static List<Costs> GetCostsForPeriod(List<Analytics> analytics, List<Articles> articles, DateTime dateFrom, DateTime dateTo)
        {
            List<Costs> costs = new List<Costs>();

            foreach (var analytic in analytics)
            {
                foreach (var article in articles)
                {
                    costs.AddRange(Config.db.Costs.Where(dm => dm.Date >= dateFrom).Where(dy => dy.Date <= dateTo).
                        Where(ni => ni.Analytics.Id == analytic.Id).Where(na => na.Articles.Id == article.Id).ToList());
                }                   
            }

            return costs.OrderBy(n => n.Articles.Name).ThenBy(d => d.Date).ToList();
        }
        /// <summary>
        /// Возвращает общую сумму расходов по всем статьям, за месяц
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static double GetTotalSumForMonth(int month, int year)
        {
            List<Costs> costs = Config.db.Costs.Where(dm => dm.Date.Month == month).Where(dy => dy.Date.Year == year).ToList();

            if (costs.Count != 0)
                return costs.Sum(s => s.Sum);

            return 0;
        }
        /// <summary>
        /// Получает расход
        /// </summary>
        /// <param name="idCost"></param>
        /// <returns></returns>
        public static Costs GetCostById(int idCost)
        {
            return Config.db.Costs.Where(i => i.Id == idCost).FirstOrDefault();
        }
        public static string DeleteCost(int idCost)
        {
            Costs cost = GetCostById(idCost);

            if (cost != null)
            {
                try
                {
                    Config.db.Costs.Remove(cost);
                    Config.db.SaveChanges();

                    return Resources.OK;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }

            return "Найти расход не удалось.";
        }
    }
}
