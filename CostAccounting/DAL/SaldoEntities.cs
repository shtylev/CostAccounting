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
            return Config.db.Saldo.Where(t => t.Type == (int)References.TypeSaldo.startingPeriod).ToList();
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
                saldo = Config.db.Saldo.Where(t => t.Type == (int)References.TypeSaldo.startingPeriod).Where(i => i.IdAnalytic == idAnalytic).FirstOrDefault();

                if (saldo != null)
                    return true;
            }

            if (idArticle != null)
            {
                saldo = Config.db.Saldo.Where(t => t.Type == (int)References.TypeSaldo.startingPeriod).Where(i => i.IdArticle == idArticle).FirstOrDefault();

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
        /// <summary>
        /// Удаляет сальдо, вместе с сальдо на конец периода, по ид аналитики или статьи
        /// </summary>
        /// <param name="idSaldo"></param>
        /// <param name="idAnalytic"></param>
        /// <param name="idArticle"></param>
        /// <returns></returns>
        public static string DeleteSaldo(int idSaldo, int? idAnalytic, int? idArticle)
        {
            Saldo saldo = GetSaldoById(idSaldo);
            Saldo saldoEndPeriod = null;

            if (idAnalytic != null)
                saldoEndPeriod = GetSaldoEndPeriod(idAnalytic, null);
            if (idArticle != null)
                saldoEndPeriod = GetSaldoEndPeriod(null, idArticle);

            if (saldo != null && saldoEndPeriod != null)
            {
                try
                {
                    Config.db.Saldo.Remove(saldo);
                    Config.db.Saldo.Remove(saldoEndPeriod);
                    Config.db.SaveChanges();

                    return Resources.OK;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }

            return "Найти сальдо не удалось.";
        }
        /// <summary>
        /// Ищет сальдо на конец периода
        /// </summary>
        /// <param name="idAnalytic"></param>
        /// <param name="idArticle"></param>
        /// <returns></returns>
        public static Saldo GetSaldoEndPeriod(int? idAnalytic, int? idArticle)
        {
            if (idAnalytic != null)
                return Config.db.Saldo.Where(i => i.IdAnalytic == idAnalytic).Where(t => t.Type == (int)References.TypeSaldo.endPeriod).FirstOrDefault();

            if (idArticle != null)
                return Config.db.Saldo.Where(i => i.IdArticle == idArticle).Where(t => t.Type == (int)References.TypeSaldo.endPeriod).FirstOrDefault();

            return null;
        }
        /// <summary>
        /// Получает список сальдо на конец периода
        /// </summary>
        /// <returns></returns>
        public static List<Saldo> GetSaldosEndPeriod()
        {
            return Config.db.Saldo.Where(t => t.Type == (int)References.TypeSaldo.endPeriod).ToList();
        }
        /// <summary>
        /// Возвращает общую сумму, по ид аналитики или статьи
        /// </summary>
        /// <param name="idAnalytic"></param>
        /// <param name="idArticle"></param>
        /// <returns></returns>
        public static double GetTotalSumForSaldoEndPeriod(int? idAnalytic, int? idArticle)
        {
            Saldo saldo = new Saldo();

            if(idAnalytic != null)
            {
                saldo = Config.db.Saldo.Where(i => i.IdAnalytic == idAnalytic).Where(t => t.Type == (int)References.TypeSaldo.totalSumForEndPeriod).FirstOrDefault();

                if(saldo != null)
                    return (double)saldo.Sum;
            }

            if(idArticle != null)
            {
                saldo = Config.db.Saldo.Where(i => i.IdArticle == idArticle).Where(t => t.Type == (int)References.TypeSaldo.totalSumForEndPeriod).FirstOrDefault();

                if (saldo != null)
                    return (double)saldo.Sum;
            }

            return 0;
        }
        /// <summary>
        /// Возвращает сальдо общей суммы, по ид аналитики или статьи
        /// </summary>
        /// <param name="idAnalytic"></param>
        /// <param name="idArticle"></param>
        /// <returns></returns>
        public static Saldo GetSaldoTotalSumForEndPeriod(int? idAnalytic, int? idArticle)
        {
            Saldo saldo = new Saldo();

            if (idAnalytic != null)
            {
                saldo = Config.db.Saldo.Where(i => i.IdAnalytic == idAnalytic).Where(t => t.Type == (int)References.TypeSaldo.totalSumForEndPeriod).FirstOrDefault();

                if (saldo != null)
                    return saldo;
            }

            if (idArticle != null)
            {
                saldo = Config.db.Saldo.Where(i => i.IdArticle == idArticle).Where(t => t.Type == (int)References.TypeSaldo.totalSumForEndPeriod).FirstOrDefault();

                if (saldo != null)
                    return saldo;
            }

            return null;
        }
    }
}
