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
        /// Получает все активные аналитики
        /// </summary>
        /// <returns>Список аналитик</returns>
        public static List<Analytics> GetAnalytics()
        {
            return Config.db.Analytics.Where(a => a.Active == true).OrderBy(n => n.Name).ToList();
        }
        /// <summary>
        /// Получает одну аналитику
        /// </summary>
        /// <param name="idAnalytic">id аналитики</param>
        /// <returns></returns>
        public static Analytics GetAnalytic(int idAnalytic)
        {
            return Config.db.Analytics.Where(i => i.Id == idAnalytic).FirstOrDefault();
        }
        /// <summary>
        /// Создает аналитику
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
        /// <summary>
        /// Переименовывает аналитику
        /// </summary>
        /// <param name="newName">Новое имя аналитики</param>
        /// <param name="idAnalytic">id выбранной аналитики</param>
        /// <returns></returns>
        public static string RenameAnalytic(string newName, int idAnalytic)
        {
            Analytics analytic = GetAnalytic(idAnalytic);
            try
            {
                analytic.Name = newName;
                Config.db.SaveChanges();
                return Resources.OK;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Добавляет аналитику в архив
        /// </summary>
        /// <param name="idAnalytic">id выбранной аналитики</param>
        /// <returns></returns>
        public static string AddAnalyticToArchive(int idAnalytic)
        {
            Analytics analytic = GetAnalytic(idAnalytic);
            try
            {
                analytic.Active = false;
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
