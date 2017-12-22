using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostAccounting.DAL
{
    public static class Colors
    {
        /// <summary>
        /// Возвращает цвет из hex значения
        /// </summary>
        /// <param name="colorHex"></param>
        /// <returns></returns>
        public static Color GetColor(string colorHex)
        {
            ColorConverter conv = new ColorConverter();
            return (Color)conv.ConvertFromString(colorHex);
        }
    }
}
