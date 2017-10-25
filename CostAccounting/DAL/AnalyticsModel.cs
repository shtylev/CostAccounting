using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostAccounting.Model_Data;

namespace CostAccounting.DAL
{
    public class AnalyticsModel
    {
        /// <summary>
        /// Получение всех активных аналитик
        /// </summary>
        /// <returns>Список аналитик</returns>
        public static List<Analytics> GetAnalytics()
        {
            return Config.db.Analytics.Where(a => a.Active == true).OrderBy(n => n.Name).ToList();
        }
        /// <summary>
        /// Создание аналитики
        /// </summary>
        /// <param name="nameAnalytic">Имя новой аналитики</param>
        /// <returns></returns>
        public static string CreateAnalytic(string nameAnalytic)
        {
            Analytics newAnalytic = new Analytics();
            newAnalytic.Name = nameAnalytic;
            newAnalytic.Active = true;
            try
            {
                Config.db.Analytics.Add(newAnalytic);
                Config.db.SaveChanges();                
                return Resources.OK;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }            
        }
    }
}
