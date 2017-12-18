using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostAccounting.DAL
{
    public static class ListBoxEntities
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
        public static void FillCheckedListBox<T>(CheckedListBox clb, List<T> reference)
        {
            ((ListBox)clb).DataSource = reference;
            ((ListBox)clb).DisplayMember = "Name";
            ((ListBox)clb).ValueMember = "Id";
        }
    }
}
