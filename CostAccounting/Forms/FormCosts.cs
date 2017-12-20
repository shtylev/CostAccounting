using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CostAccounting.DAL;
using CostAccounting.Model_Data;
using CostAccounting.Model;

namespace CostAccounting.Forms
{
    public partial class FormCosts : Form
    {
        public DateTime? DateCostFrom { get; set; }
        public DateTime? DateCostTo { get; set; }
        public int? IdArticle { get; set; }

        List<Costs> costs = new List<Costs>();
        List<CostModel> costsModel = new List<CostModel>();

        public FormCosts()
        {
            InitializeComponent();
        }

        private void FormCosts_Load(object sender, EventArgs e)
        {
            if(DateCostFrom != null && DateCostTo != null && IdArticle != null)
            {
                ListBoxEntities.FillCheckedListBox(clbAnalytics, AnalyticsEntities.GetAnalytics());
                ListBoxEntities.FillCheckedListBox(clbArticles, ArticlesEntities.GetArticles());

                dtpDateCostFrom.Value = (DateTime)DateCostFrom;
                dtpDateCostTo.Value = (DateTime)DateCostTo;               

                if(IdArticle != 0)
                {
                    Articles article = ArticlesEntities.GetArticleById((int)IdArticle);
                    if(article != null)
                        clbArticles.SetItemChecked(clbArticles.Items.IndexOf(article), true);   //включаем галку для статьи
                }
                else
                {
                    //если переходят из общей суммы, то включаем галку у всех статей
                    IncludeAllInCheckListBox(clbArticles, false);
                }

                //включаем галку у всех аналитик
                IncludeAllInCheckListBox(clbAnalytics, false);
                checkBoxAllAnalytics.Checked = true;

                FillCostsModel();
                FillTableCosts();
            }
        }
        void FillTableCosts()
        {
            dgvCosts.DataSource = costsModel.ToList();
        }
        void FillCostsModel()
        {
            if (clbAnalytics.CheckedItems.Count != 0 && clbArticles.CheckedItems.Count != 0)
            {
                costs.Clear();

                List<Analytics> analytics = new List<Analytics>();
                List<Articles> articles = new List<Articles>();
                
                foreach(Analytics analytic in clbAnalytics.CheckedItems)
                {
                    analytics.Add(analytic);
                }

                foreach(Articles article in clbArticles.CheckedItems)
                {
                    articles.Add(article);
                }

                costs = CostsEntities.GetCostsForPeriod(analytics, articles, dtpDateCostFrom.Value, dtpDateCostTo.Value);

                costsModel.Clear();
                foreach(var cost in costs)
                {
                    costsModel.Add(new CostModel(cost.Id, cost.Analytics.Name, cost.Articles.Name, cost.Date, cost.Sum, cost.Message));
                }
            }
            else
                MessageBox.Show("Не было выбрано аналитик или статей!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillCostsModel();
            FillTableCosts();
        }
        void IncludeAllInCheckListBox(CheckedListBox checkBox, bool disable)
        {
            for (int index = 0; index < checkBox.Items.Count; index++)
            {
                if (disable)
                    checkBox.SetItemChecked(index, false);
                else
                    checkBox.SetItemChecked(index, true);
            }                        
        }

        private void checkBoxAllAnalytics_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked == true)
                IncludeAllInCheckListBox(clbAnalytics, false);
            else
                IncludeAllInCheckListBox(clbAnalytics, true);
        }

        private void checkBoxAllArticles_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked == true)
                IncludeAllInCheckListBox(clbArticles, false);
            else
                IncludeAllInCheckListBox(clbArticles, true);
        }

        private void dgvCosts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //сохраняем изменения для 3 столбцов: дата, сумма, комментарий
            DataGridViewCell editCell = (sender as DataGridView).CurrentCell;
            
            if(editCell != null)
            {
                Costs cost = CostsEntities.GetCostById((int)(sender as DataGridView).Rows[e.RowIndex].Cells[0].Value);

                if(cost != null)
                {
                    object newValue = editCell.Value;
                    string nameColumn = editCell.OwningColumn.Name;

                    switch (nameColumn)
                    {
                        case "Date":
                            cost.Date = Convert.ToDateTime(newValue).Date;
                            break;
                        case "Sum":
                            cost.Sum = Math.Round(Convert.ToDouble(newValue), 2);
                            break;
                        case "Message":
                            cost.Message = newValue == null ? null : newValue.ToString();
                            break;
                    }

                    Config.db.SaveChanges();
                }
            }
        }

        private void deleteConMenuItemGrid_Click(object sender, EventArgs e)
        {
            if (dgvCosts.SelectedRows.Count != 0)
            {
                for(int index = 0; index < dgvCosts.SelectedRows.Count; index++)
                {
                    CostModel selectedCost = (CostModel)dgvCosts.SelectedRows[index].DataBoundItem;

                    //удалить из бд
                    string result = "";
                    result = CostsEntities.DeleteCost(selectedCost.Id);

                    if (result == Resources.OK)
                    {
                        //удалить из модели
                        costsModel.Remove(selectedCost);
                    }
                    else
                        MessageBox.Show(result, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillTableCosts();
            }
            else
                MessageBox.Show("Не выбрана строка расхода!");
        }
    }
}
