using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostAccounting.Model_Data;

namespace CostAccounting.DAL
{
    public static class Config
    {
        static DbEntities _db;        
        public static DbEntities db
        {
            get
            {
                if (_db == null)
                    return _db = new DbEntities();
                else
                    return _db;
            }
        }
    }
}
