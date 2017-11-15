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
        List<SaldoModel> saldosModel = new List<SaldoModel>();
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
                SaldoModel saldoModel = new SaldoModel();
                foreach(Saldo saldo in saldos)
                {
                    if (saldo.IdAnalytic != null)
                        saldoModel.Name = saldo.Analytics.Name;
                    if (saldo.IdArticle != null)
                        saldoModel.Name = saldo.Articles.Name;

                    saldoModel.Sum = (double)saldo.Sum;
                    saldosModel.Add(saldoModel);
                }
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

        private void btnAddAnalytic_Click(object sender, EventArgs e)
        {
            Saldo saldo = new Saldo();
            saldo.Type = (int)Dictionary.TypeSaldo.saldoStartingPeriod;
            saldo.Sum = Convert.ToDouble(txtSumAnalytic.Text);
            saldo.IdAnalytic = (int)cmbRefAnalytics.SelectedValue;
            try
            {
                Config.db.Saldo.Add(saldo);
                Config.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
