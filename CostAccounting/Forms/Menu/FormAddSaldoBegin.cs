using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CostAccounting.Model;
using CostAccounting.Model_Data;
using CostAccounting.DAL;

namespace CostAccounting.Forms.Menu
{
    public partial class FormAddSaldoBegin : Form
    {
        //свойство для определения, не закрывается ли форма
        private bool FormIsClosed { get; set; } = false;

        public FormAddSaldoBegin()
        {
            InitializeComponent();

            //заполняем комбобоксы
            FillComboBox(cmbRefAnalytics, AnalyticsEntities.GetAnalytics());
            FillComboBox(cmbRefArticles, ArticlesEntities.GetArticles());

            txtSumAnalytic.LostFocus += new EventHandler(txtSumAnalytic_LostFocus);
            txtSumArticle.LostFocus += new EventHandler(txtSumArticle_LostFocus);
        }

        private void FormAddSaldoBegin_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Заполняет элемент ComboBox
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmb"></param>
        /// <param name="reference"></param>
        void FillComboBox<T>(ComboBox cmb, List<T> reference)
        {
            cmb.DataSource = reference;
            cmb.DisplayMember = "Name";
            cmb.ValueMember = "Id";
        }
        /// <summary>
        /// Проверяет введенное значение, в текстовом поле, на число
        /// </summary>
        /// <param name="txtBox">Текстовое поле, в которое вводится значение</param>
        void CheckForTheNumber(TextBox txtBox)
        {            
            double sum = 0;
            if (txtBox.Text != "" && !FormIsClosed)
            {
                if (!double.TryParse(txtBox.Text, out sum))
                {
                    MessageBox.Show("Сумма должна быть числом! Используйте точку, для копеек.");
                    txtBox.Focus();
                }
            }            
        }
        private void txtSumAnalytic_LostFocus(object sender, EventArgs e)
        {
            CheckForTheNumber(txtSumAnalytic);
        }
        private void txtSumArticle_LostFocus(object sender, EventArgs e)
        {
            CheckForTheNumber(txtSumArticle);
        }

        private void FormAddSaldoBegin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormIsClosed = true;
        }
    }
}
