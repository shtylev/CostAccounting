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

namespace CostAccounting.Forms
{
    public partial class FormCosts : Form
    {
        public DateTime? DateCostFrom { get; set; }
        public DateTime? DateCostTo { get; set; }
        public int? IdArticle { get; set; }

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
                    for(int index = 0; index < clbArticles.Items.Count; index++)
                    {
                        clbArticles.SetItemChecked(index, true);
                    }
                }

                //включаем галку у всех аналитик
                for (int index = 0; index < clbAnalytics.Items.Count; index++)
                {
                    clbAnalytics.SetItemChecked(index, true);
                }       
            }
        }
    }
}
