using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostAccounting.Model_Data;

namespace CostAccounting.DAL
{
    public static class ArticlesModel
    {
        /// <summary>
        /// Получение всех активных статей
        /// </summary>
        /// <returns></returns>
        public static List<Articles> GetArticles()
        {
            return Config.db.Articles.Where(a => a.Active == true).OrderBy(n => n.Name).ToList();
        }
        /// <summary>
        /// Создание статьи
        /// </summary>
        /// <param name="nameArticle">Имя новой статьи</param>
        /// <returns></returns>
        public static string CreateArticle(string nameArticle)
        {
            Articles newArticle = new Articles();
            newArticle.Name = nameArticle;
            newArticle.Active = true;
            try
            {
                Config.db.Articles.Add(newArticle);
                Config.db.SaveChanges();
                return Resources.OK;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
