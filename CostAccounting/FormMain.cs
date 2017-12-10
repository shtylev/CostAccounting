using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CostAccounting.Forms.Menu;
using CostAccounting.DAL;
using CostAccounting.Model_Data;
using CostAccounting.Model;

namespace CostAccounting
{
    public partial class formMain : Form
    {        
        private bool FormIsClosed { get; set; } = false;    //свойство для определения, не закрывается ли форма
        List<SaldoModel> saldosModelEndPeriod = new List<SaldoModel>();  //список, для заполнения таблицы; модель сальдо на конец периода
        List<Saldo> saldosEndPeriod = new List<Saldo>();

        public formMain()
        {
            InitializeComponent();

            txtSumCost.LostFocus += new EventHandler(txtSumCost_LostFocus);
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            ComboBoxEntities.FillComboBox(cmbCostsAnalytics, AnalyticsEntities.GetAnalytics());
            ComboBoxEntities.FillComboBox(cmbCostsArticles, ArticlesEntities.GetArticles());

            FillSaldoModelEndPeriod();
            FillTableSaldoEndPeriod();
        }
        private void txtSumCost_LostFocus(object sender, EventArgs e)
        {
            if (!NumbersValidation.CheckForTheNumberDouble(txtSumCost.Text, FormIsClosed))
            {
                MessageBox.Show("Сумма расходов должна быть числом!");
                txtSumCost.Focus();
            }
        }

        private void menuItemAnalyticsReference_Click(object sender, EventArgs e)
        {
            ShowFormReference(Resources.Analytics);
        }

        private void menuItemArticlesReference_Click(object sender, EventArgs e)
        {
            ShowFormReference(Resources.Articles);
        }

        private void ShowFormReference(string typeReference)
        {       
            FormReferences formReference = new FormReferences();
            formReference.lblTypeReference.Text = typeReference;
            formReference.ShowDialog();
        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Config.db.Dispose();
        }

        private void menuItemAddSaldoBegin_Click(object sender, EventArgs e)
        {
            FormAddSaldoBegin formAddSaldoBegin = new FormAddSaldoBegin();
            formAddSaldoBegin.ShowDialog();
        }        

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormIsClosed = true;
        }

        private void btnAddCost_Click(object sender, EventArgs e)
        {
            Costs cost = new Costs();
            int idAnalytic = (int)cmbCostsAnalytics.SelectedValue;
            int idArticle = (int)cmbCostsArticles.SelectedValue;
            int typeSaldoTotalSum = (int)References.TypeSaldo.totalSumForEndPeriod;
            double sumCost = txtSumCost.Text == "" ? 0 : Math.Round(Convert.ToDouble(txtSumCost.Text.Replace(",", ".")), 2);

            if (sumCost != 0)
            {
                try
                {
                    //добавляем расход в таблицу
                    cost.IdAnalytic = idAnalytic;
                    cost.IdArticle = idArticle;
                    cost.Sum = sumCost;
                    cost.Message = txtCostMessage.Text == "" ? null : txtCostMessage.Text;
                    cost.Date = dtpCostDate.Value.Date;
                    Config.db.Costs.Add(cost);

                    //прибавление суммы расхода к общей сумме сальдо
                    Saldo saldoTotalSumArticle = SaldoEntities.GetSaldoTotalSumForEndPeriod(null, idArticle);
                    Saldo saldoTotalSumAnalytic = SaldoEntities.GetSaldoTotalSumForEndPeriod(idAnalytic, null);
                    
                    //обрабатываем общую сумму по аналитике
                    if (saldoTotalSumAnalytic != null)
                    {
                        saldoTotalSumAnalytic.Sum += sumCost;
                    }
                    else
                    {
                        //если нет общей суммы, то создавать
                        saldoTotalSumAnalytic = new Saldo();
                        saldoTotalSumAnalytic.Type = typeSaldoTotalSum;
                        saldoTotalSumAnalytic.IdAnalytic = idAnalytic;
                        saldoTotalSumAnalytic.Sum = sumCost;
                        Config.db.Saldo.Add(saldoTotalSumAnalytic);
                    }                    

                    //обрабатываем общую сумму по статье
                    if (saldoTotalSumArticle != null)
                        saldoTotalSumArticle.Sum += sumCost;
                    else
                    {
                        //если нет общей суммы, то создавать
                        saldoTotalSumArticle = new Saldo();
                        saldoTotalSumArticle.Type = typeSaldoTotalSum;
                        saldoTotalSumArticle.IdArticle = idArticle;
                        saldoTotalSumArticle.Sum = sumCost;
                        Config.db.Saldo.Add(saldoTotalSumArticle);
                    }

                    //реализовать изменение сумм у сальдо на конец периода
                    //найти сальдо на конец периода
                    Saldo saldoEndPeriodAnalytic = SaldoEntities.GetSaldoEndPeriod(idAnalytic, null);
                    Saldo saldoEndPeriodArticle = SaldoEntities.GetSaldoEndPeriod(null, idArticle);

                    //если есть, то прибавить/отнять сумму этого сальдо с суммой расхода
                    if (saldoEndPeriodAnalytic != null)
                        saldoEndPeriodAnalytic.Sum += sumCost;
                    if (saldoEndPeriodArticle != null)
                        saldoEndPeriodArticle.Sum -= sumCost;

                    Config.db.SaveChanges();

                    dataGridView1.DataSource = CostsEntities.GetCosts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Вы добавляете нулевой расход! Одумайтесь! Зачем?");                        
        }

        private void btnUpdateSaldoEndPeriod_Click(object sender, EventArgs e)
        {
            FillSaldoModelEndPeriod();
            FillTableSaldoEndPeriod();
        }
        void FillTableSaldoEndPeriod()
        {
            dgvSaldoEndPeriod.DataSource = saldosModelEndPeriod.ToList();
        }
        void FillSaldoModelEndPeriod()
        {
            saldosEndPeriod.Clear();
            saldosEndPeriod = SaldoEntities.GetSaldosEndPeriod();

            if(saldosEndPeriod.Count != 0)
            {
                saldosModelEndPeriod.Clear();

                foreach (Saldo saldoEndPeriod in saldosEndPeriod)
                {
                    if (saldoEndPeriod.IdAnalytic != null)
                        saldosModelEndPeriod.Add(new SaldoModel(saldoEndPeriod.Analytics.Name, (double)saldoEndPeriod.Sum, null, saldoEndPeriod.IdAnalytic, saldoEndPeriod.Id));
                    if (saldoEndPeriod.IdArticle != null)
                        saldosModelEndPeriod.Add(new SaldoModel(saldoEndPeriod.Articles.Name, (double)saldoEndPeriod.Sum, saldoEndPeriod.IdArticle, null, saldoEndPeriod.Id));
                }
            }            
        }
    }
}
