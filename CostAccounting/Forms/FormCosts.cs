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

namespace CostAccounting.Forms
{
    public partial class FormCosts : Form
    {
        public DateTime DateCostFrom { get; set; }
        public DateTime DateCostTo { get; set; }
        public int IdArticle { get; set; }

        public FormCosts()
        {
            InitializeComponent();
        }

        private void FormCosts_Load(object sender, EventArgs e)
        {
            ListBoxEntities.FillCheckedListBox(clbAnalytics, AnalyticsEntities.GetAnalytics());
            ListBoxEntities.FillCheckedListBox(clbArticles, ArticlesEntities.GetArticles());

            dtpDateCostFrom.Value = DateCostFrom;
            dtpDateCostTo.Value = DateCostTo;
        }
    }
}
