using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostAccounting.DAL
{
    public static class NumbersValidation
    {
        /// <summary>
        /// Проверяет введенное значение, в текстовом поле, на число с точкой
        /// </summary>
        /// <param name="txtBox">Текстовое поле, в которое вводится значение</param>
        public static bool CheckForTheNumberDouble(string number, bool formIsClosed)
        {
            double sum = 0;
            if (number != "" && !formIsClosed) //проверка на закрытие формы необходима для того, чтобы не получать данную ошибку, постоянно, если в txt поле ошибочное значение, когда закрывают форму
            {
                if (!double.TryParse(number.Replace(",", "."), out sum))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
