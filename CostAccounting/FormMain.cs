using CostAccounting.DAL;
using CostAccounting.Forms.Menu;
using CostAccounting.Model;
using CostAccounting.Model_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            dgvSvod.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(dgvSvod_CellMouseDoubleClick);
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            ComboBoxEntities.FillComboBox(cmbCostsAnalytics, AnalyticsEntities.GetAnalytics());
            ComboBoxEntities.FillComboBox(cmbCostsArticles, ArticlesEntities.GetArticles());

            //заполняем сальдо на конец периода
            FillSaldoModelEndPeriod();
            FillTableSaldoEndPeriod();

            //для даты свода с, устанавливаем дату меньшую на 6 месяцев от текущей
            dtpSvodDateFrom.Value = DateTime.Now.AddMonths(-6);

            //устанавливаем формат отображения дат в виде "дек.17"
            dtpSvodDateFrom.CustomFormat = "MMM.yy";
            dtpSvodDateTo.CustomFormat =  "MMM.yy";

            FillTableSvod();
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

                    FillSaldoModelEndPeriod();
                    FillTableSaldoEndPeriod();
                    FillTableSvod();
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

        private void btnUpdateSvod_Click(object sender, EventArgs e)
        {
            //проверяем, не больше ли дата начала даты конца
            if (dtpSvodDateFrom.Value > dtpSvodDateTo.Value)
                MessageBox.Show("Дата начала не может быть больше даты конца!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            FillTableSvod();
        }
        void FillTableSvod()
        {
            List<Articles> articles = ArticlesEntities.GetArticles();

            dgvSvod.Rows.Clear();
            dgvSvod.Columns.Clear();

            #region добавляем столбцы
            dgvSvod.Columns.Add("IdArticle", "IdArticle");
            dgvSvod.Columns[0].Visible = false; //столбец Id невидимым
            dgvSvod.Columns.Add("Article", "Статья");

            string dateFrom = dtpSvodDateFrom.Value.Month.ToString() + dtpSvodDateFrom.Value.Year.ToString();
            string dateTo = dtpSvodDateTo.Value.Month.ToString() + dtpSvodDateTo.Value.Year.ToString();
            DateTime processedDate = dtpSvodDateFrom.Value;

            while (dateFrom != dateTo)
            {
                dgvSvod.Columns.Add(processedDate.ToString("dd.MM.yyyy"), processedDate.ToString("MMM.yy"));

                processedDate = processedDate.AddMonths(1);
                dateFrom = processedDate.Month.ToString() + processedDate.Year.ToString();
            }

            //добавляем последний столбец
            if (dateFrom == dateTo)
            {
                dgvSvod.Columns.Add(processedDate.ToString("dd.MM.yyyy"), processedDate.ToString("MMM.yy"));
            }
            #endregion

            #region добавляем строки
            for (int indexRows = 0; indexRows <= articles.Count; indexRows++)
            {
                dgvSvod.Rows.Add();
                foreach (DataGridViewTextBoxColumn columnSvod in dgvSvod.Columns)
                {
                    //добавляем ячейки
                    switch (columnSvod.Name)
                    {
                        case "IdArticle":
                            if (indexRows != articles.Count)
                                dgvSvod.Rows[indexRows].Cells[columnSvod.Name].Value = articles[indexRows].Id;  //id статьи
                            else
                                dgvSvod.Rows[indexRows].Cells[columnSvod.Name].Value = 0;   //последняя строка для общих расходов
                            break;
                        case "Article":
                            if (indexRows != articles.Count)
                                dgvSvod.Rows[indexRows].Cells[columnSvod.Name].Value = articles[indexRows].Name;    //имя статьи
                            else
                                dgvSvod.Rows[indexRows].Cells[columnSvod.Name].Value = "Общие расходы"; //последняя строка
                            break;
                        default:
                            //добавляем ячейки для сумм
                            DateTime nameColumn = Convert.ToDateTime(columnSvod.Name);
                            if (indexRows != articles.Count)
                            {
                                dgvSvod.Rows[indexRows].Cells[columnSvod.Name].Value = SvodEntities.GetSumForMonthArticle(articles[indexRows].Id, nameColumn.Month, nameColumn.Year);
                            }
                            else
                            {
                                dgvSvod.Rows[indexRows].Cells[columnSvod.Name].Value = SvodEntities.GetTotalSumForMonth(nameColumn.Month, nameColumn.Year);
                            }
                            break;
                    }
                }
            }            
            #endregion
        }

        void dgvSvod_CellMouseDoubleClick(Object sender, DataGridViewCellMouseEventArgs e)
        {

            DateTime monthCosts = Convert.ToDateTime((sender as DataGridView).Columns[e.ColumnIndex].Name); //получаем имя столбца
            int idArticle = (int)(sender as DataGridView).Rows[e.RowIndex].Cells[0].Value;  //получаем id статьи из первой ячейки
            
        }
    }
}
