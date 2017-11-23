﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CostAccounting.Model_Data;

namespace CostAccounting.DAL
{
    static public class SaldoEntities
    {
        /// <summary>
        /// Получает список сальдо на начало периода
        /// </summary>
        /// <returns></returns>
        public static List<Saldo> GetSaldosStartingPeriod()
        {
            return Config.db.Saldo.Where(t => t.Type == (int)Dictionary.TypeSaldo.saldoStartingPeriod).ToList();
        }
        /// <summary>
        /// Выполняет поиск справочника в сальдо на начало периода
        /// </summary>
        /// <param name="idAnalytic">id аналитики</param>
        /// <param name="idArticle">id статьи</param>
        /// <returns></returns>
        public static bool FindEntryRefInSaldoStartingPeriodById(int? idAnalytic, int? idArticle)
        {
            Saldo saldo = new Saldo();

            if (idAnalytic != null)
            {
                saldo = Config.db.Saldo.Where(t => t.Type == (int)Dictionary.TypeSaldo.saldoStartingPeriod).Where(i => i.IdAnalytic == idAnalytic).FirstOrDefault();

                if (saldo != null)
                    return true;
            }

            if (idArticle != null)
            {
                saldo = Config.db.Saldo.Where(t => t.Type == (int)Dictionary.TypeSaldo.saldoStartingPeriod).Where(i => i.IdArticle == idArticle).FirstOrDefault();

                if (saldo != null)
                    return true;
            }

            return false;
        }
        /// <summary>
        /// Поиск сальдо
        /// </summary>
        /// <param name="idSaldo">Id сальдо</param>
        /// <returns></returns>
        public static Saldo GetSaldoById(int idSaldo)
        {
            return Config.db.Saldo.Where(i => i.Id == idSaldo).FirstOrDefault();
        } 
        /// <summary>
        /// Удаляет сальдо
        /// </summary>
        /// <param name="idSaldo"></param>
        /// <returns></returns>
        public static string DeleteSaldo(int idSaldo)
        {
            Saldo saldo = GetSaldoById(idSaldo);

            if(saldo != null)
            {
                try
                {
                    Config.db.Saldo.Remove(saldo);
                    Config.db.SaveChanges();

                    return Resources.OK;
                }
                catch(Exception ex)
                {
                    return ex.Message;
                }
            }

            return "Найти сальдо не удалось.";
        }
    }
}
