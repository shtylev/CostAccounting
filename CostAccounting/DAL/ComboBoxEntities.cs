using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostAccounting.DAL
{
    public static class ComboBoxEntities
    {
        /// <summary>
        /// Заполняет элемент ComboBox
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmb"></param>
        /// <param name="reference"></param>
        public static void FillComboBox<T>(ComboBox cmb, List<T> reference)
        {
            cmb.DataSource = reference;
            cmb.DisplayMember = "Name";
            cmb.ValueMember = "Id";
            cmb.AutoCompleteCustomSource = (reference as AutoCompleteStringCollection); //включаем автозаполнение, AutoCompleteMode и AutoCompleteSource
        }
    }
}
