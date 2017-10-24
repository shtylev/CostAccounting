using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostAccounting.Model_Data;

namespace CostAccounting.DAL
{
    public static class Articles
    {
        public static List<Model_Data.Articles> GetArticles()
        {
            return Config.db.Articles.Where(a => a.Active == true).OrderBy(n => n.Name).ToList();
        }
    }
}
