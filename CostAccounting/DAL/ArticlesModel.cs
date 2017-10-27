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
        /// Получает все активные статьи
        /// </summary>
        /// <returns></returns>
        public static List<Articles> GetArticles()
        {
            return Config.db.Articles.Where(a => a.Active == true).OrderBy(n => n.Name).ToList();
        }
        /// <summary>
        /// Получает одну статью
        /// </summary>
        /// <param name="idArticle">id статьи</param>
        /// <returns></returns>
        public static Articles GetArticle(int idArticle)
        {
            return Config.db.Articles.Where(i => i.Id == idArticle).FirstOrDefault();
        }

        /// <summary>
        /// Создает статью
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
        /// Переименовывает статью
        /// </summary>
        /// <param name="newName">Новое имя статьи</param>
        /// <param name="idArticle">id выбранной статьи</param>
        /// <returns></returns>
        public static string RenameArticle(string newName, int idArticle)
        {
            Articles article = GetArticle(idArticle);
            try
            {
                article.Name = newName;
                Config.db.SaveChanges();
                return Resources.OK;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Добавляет статью в архив
        /// </summary>
        /// <param name="idArticle">id выбранной статьи</param>
        /// <returns></returns>
        public static string AddArticleToArchive(int idArticle)
        {
            Articles article = GetArticle(idArticle);
            try
            {
                article.Active = false;
                Config.db.SaveChanges();
                return Resources.OK;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// Получает все архивные статьи
        /// </summary>
        /// <returns></returns>
        public static List<Articles> GetArticlesArchive()
        {
            return Config.db.Articles.Where(a => a.Active == false).OrderBy(n => n.Name).ToList();
        }
        /// <summary>
        /// Удаляет статью из архива
        /// </summary>
        /// <param name="idArticle">id выбранной статьи</param>
        /// <returns></returns>
        public static string RemoveFromArchive(int idArticle)
        {
            Articles article = GetArticle(idArticle);

            try
            {
                article.Active = true;
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
