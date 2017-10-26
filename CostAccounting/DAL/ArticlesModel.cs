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
        /// Получение статьи
        /// </summary>
        /// <param name="idArticle">id статьи</param>
        /// <returns></returns>
        public static Articles GetArticle(int idArticle)
        {
            return Config.db.Articles.Where(i => i.Id == idArticle).FirstOrDefault();
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
        /// <summary>
        /// Переименование выбранной статьи
        /// </summary>
        /// <param name="newName">Новое имя статьи</param>
        /// <param name="idArticle">id выбранной статьи</param>
        /// <returns></returns>
        public static string RenameArticle(string newName, int idArticle)
        {
            Articles article = GetArticle(idArticle);
            article.Name = newName;
            try
            {
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
