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
            ListBoxEntities.FillComboBox(cmbRefAnalytics, AnalyticsEntities.GetAnalytics());
            ListBoxEntities.FillComboBox(cmbRefArticles, ArticlesEntities.GetArticles());

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
        private void txtSumAnalytic_LostFocus(object sender, EventArgs e)
        {
            if(!NumbersValidation.CheckForTheNumberDouble(txtSumAnalytic.Text, FormIsClosed))
            {
                MessageBox.Show("Сумма должна быть числом!");
                txtSumAnalytic.Focus();
            }            
        }
        private void txtSumArticle_LostFocus(object sender, EventArgs e)
        {
            if (!NumbersValidation.CheckForTheNumberDouble(txtSumArticle.Text, FormIsClosed))
            {
                MessageBox.Show("Сумма должна быть числом!");
                txtSumAnalytic.Focus();
            }
        }

        private void FormAddSaldoBegin_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormIsClosed = true;
        }

        private void FillTable()
        {
            dgwSaldoBegin.DataSource = saldosModel.ToList();

            //красим таблицу
            SaldoEntities.PaintTableSaldo(dgwSaldoBegin, saldosModel);
        }

        private void btnAddAnalytic_Click(object sender, EventArgs e)
        {           

            if (SaldoEntities.FindEntryRefInSaldoStartingPeriodById((int)cmbRefAnalytics.SelectedValue, null))  //выполняем поиск уже добавленной аналитики, проверка на дубль
                MessageBox.Show("Такая аналитика уже добавлена!");
            else
            {
                Saldo saldoStartPeriod = new Saldo();
                Saldo saldoEndPeriod = new Saldo();
                try
                {
                    //добавляем сальдо на начало периода
                    saldoStartPeriod.Type = (int)References.TypeSaldo.startingPeriod;
                    saldoStartPeriod.Sum = txtSumAnalytic.Text == "" ? 0 : Math.Round(Convert.ToDouble(txtSumAnalytic.Text.Replace(",", ".")), 2);
                    saldoStartPeriod.IdAnalytic = (int)cmbRefAnalytics.SelectedValue;
                    Config.db.Saldo.Add(saldoStartPeriod);

                    //сразу же делаем сальдо на конец периода. Таким образом сальдо на начало и на конец всегда будут равны
                    saldoEndPeriod.Type = (int)References.TypeSaldo.endPeriod;
                    saldoEndPeriod.Sum = saldoStartPeriod.Sum + CostsEntities.GetTotalSumCosts((int)cmbRefAnalytics.SelectedValue, null); //SaldoEntities.GetTotalSumForSaldoEndPeriod((int)cmbRefAnalytics.SelectedValue, null);
                    saldoEndPeriod.IdAnalytic = (int)cmbRefAnalytics.SelectedValue;
                    Config.db.Saldo.Add(saldoEndPeriod);

                    Config.db.SaveChanges();

                    saldosModel.Add(new SaldoModel(saldoStartPeriod.Analytics.Name, (double)saldoStartPeriod.Sum, null, saldoStartPeriod.IdAnalytic, saldoStartPeriod.Id));
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
                Saldo saldoStartPeriod = new Saldo();
                Saldo saldoEndPeriod = new Saldo();

                try
                {
                    //добавляем сальдо на начало периода
                    saldoStartPeriod.Type = (int)References.TypeSaldo.startingPeriod;
                    saldoStartPeriod.Sum = txtSumArticle.Text == "" ? 0 : Math.Round(Convert.ToDouble(txtSumArticle.Text.Replace(",", ".")), 2);
                    saldoStartPeriod.IdArticle = (int)cmbRefArticles.SelectedValue;
                    Config.db.Saldo.Add(saldoStartPeriod);

                    //сразу же делаем сальдо на конец периода. Таким образом сальдо на начало и на конец всегда будут равны
                    saldoEndPeriod.Type = (int)References.TypeSaldo.endPeriod;
                    saldoEndPeriod.Sum = saldoStartPeriod.Sum - CostsEntities.GetTotalSumCosts(null, (int)cmbRefArticles.SelectedValue); //SaldoEntities.GetTotalSumForSaldoEndPeriod(null, (int)cmbRefArticles.SelectedValue);
                    saldoEndPeriod.IdArticle = (int)cmbRefArticles.SelectedValue;
                    Config.db.Saldo.Add(saldoEndPeriod);

                    Config.db.SaveChanges();

                    saldosModel.Add(new SaldoModel(saldoStartPeriod.Articles.Name, (double)saldoStartPeriod.Sum, saldoStartPeriod.IdArticle, null, saldoStartPeriod.Id));
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
                string result = "";
                if(selectedSaldo.IdAnalytic != null)
                    result = SaldoEntities.DeleteSaldo(selectedSaldo.Id, selectedSaldo.IdAnalytic, null);
                if(selectedSaldo.IdArticle != null)
                    result = SaldoEntities.DeleteSaldo(selectedSaldo.Id, null, selectedSaldo.IdArticle);

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
                MessageBox.Show("Не выбрана строка справочника!");
        }
    }
}
