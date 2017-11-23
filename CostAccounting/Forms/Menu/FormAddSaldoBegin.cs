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
        List<SaldoModel> saldosModel = new List<SaldoModel>();  //список, для заполнения таблицы; модель сальдо на начало периода
        List<Saldo> saldos = new List<Saldo>();

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
            saldos = SaldoEntities.GetSaldosStartingPeriod();

            if(saldos.Count != 0)
            {
                foreach (Saldo saldo in saldos)
                {
                    if (saldo.IdAnalytic != null)
                        saldosModel.Add(new SaldoModel(saldo.Analytics.Name, (double)saldo.Sum, null, saldo.IdAnalytic, saldo.Id));
                    if (saldo.IdArticle != null)
                        saldosModel.Add(new SaldoModel(saldo.Articles.Name, (double)saldo.Sum, saldo.IdArticle, null, saldo.Id));
                }

                FillTable();
            }

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
            cmb.AutoCompleteCustomSource = (reference as AutoCompleteStringCollection); //включаем автозаполнение, AutoCompleteMode и AutoCompleteSource
        }
        /// <summary>
        /// Проверяет введенное значение, в текстовом поле, на число
        /// </summary>
        /// <param name="txtBox">Текстовое поле, в которое вводится значение</param>
        void CheckForTheNumber(TextBox txtBox)
        {            
            double sum = 0;
            if (txtBox.Text != "" && !FormIsClosed) //проверка на закрытие формы необходима для того, чтобы не получать данную ошибку, постоянно, если в txt поле ошибочное значение, когда закрывают форму
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

        private void FillTable()
        {
            dgwSaldoBegin.DataSource = saldosModel.ToList();
        }

        private void btnAddAnalytic_Click(object sender, EventArgs e)
        {           

            if (SaldoEntities.FindEntryRefInSaldoStartingPeriodById((int)cmbRefAnalytics.SelectedValue, null))  //выполняем поиск уже добавленной аналитики, проверка на дубль
                MessageBox.Show("Такая аналитика уже добавлена!");
            else
            {
                Saldo saldo = new Saldo();
                try
                {
                    saldo.Type = (int)Dictionary.TypeSaldo.saldoStartingPeriod;
                    saldo.Sum = txtSumAnalytic.Text == "" ? 0 : Convert.ToDouble(txtSumAnalytic.Text);
                    saldo.IdAnalytic = (int)cmbRefAnalytics.SelectedValue;
                    Config.db.Saldo.Add(saldo);
                    Config.db.SaveChanges();

                    saldosModel.Add(new SaldoModel(saldo.Analytics.Name, (double)saldo.Sum, null, saldo.IdAnalytic, saldo.Id));
                    FillTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }                       
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            if (SaldoEntities.FindEntryRefInSaldoStartingPeriodById(null, (int)cmbRefArticles.SelectedValue))   //выполняем поиск уже добавленной статьи, проверка на дубль
                MessageBox.Show("Такая статья уже добавлена!");
            else
            {
                Saldo saldo = new Saldo();

                try
                {
                    saldo.Type = (int)Dictionary.TypeSaldo.saldoStartingPeriod;
                    saldo.Sum = txtSumArticle.Text == "" ? 0 : Convert.ToDouble(txtSumArticle.Text);
                    saldo.IdArticle = (int)cmbRefArticles.SelectedValue;
                    Config.db.Saldo.Add(saldo);
                    Config.db.SaveChanges();

                    saldosModel.Add(new SaldoModel(saldo.Articles.Name, (double)saldo.Sum, saldo.IdArticle, null, saldo.Id));
                    FillTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void ContextMenuItemDeleteRef_Click(object sender, EventArgs e)
        {
            if (dgwSaldoBegin.SelectedRows.Count != 0)
            {
                SaldoModel selectedSaldo = (SaldoModel)dgwSaldoBegin.SelectedRows[0].DataBoundItem;

                //удалить из бд
                string result = SaldoEntities.DeleteSaldo(selectedSaldo.Id);

                if (result == Resources.OK)
                {
                    //удалить из модели
                    saldosModel.Remove(selectedSaldo);
                    FillTable();
                }
                else
                    MessageBox.Show(result, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Не выбрана строка справочника.");
        }
    }
}
