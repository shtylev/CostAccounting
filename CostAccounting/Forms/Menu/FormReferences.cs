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

namespace CostAccounting.Forms.Menu
{
    public partial class FormReferences : Form
    {        
        public FormReferences()
        {
            InitializeComponent();            
        }

        private void FormAnalytics_Load(object sender, EventArgs e)
        {
            GetReference();
            //listBoxAnalytics.ForeColor = Color.Red;
        }

        private void conMenuCreate_Click(object sender, EventArgs e)
        {
            //Analytics analytic = (Analytics)listBoxAnalytics.SelectedItem;
            //int id = (int)listBoxAnalytics.SelectedValue;
            FormCreateRef formCreateRef = new FormCreateRef(this);
            formCreateRef.ShowDialog();
        }

        public void GetReference()
        {
            if (lblTypeReference.Text == Resources.Analytics)
            {
                this.Text = Resources.Analytics;
                listBoxAnalytics.DataSource = AnalyticsModel.GetAnalytics();
            }
            if (lblTypeReference.Text == Resources.Articles)
            {
                this.Text = Resources.Articles;
                listBoxAnalytics.DataSource = ArticlesModel.GetArticles();
            }

            listBoxAnalytics.DisplayMember = "Name";
            listBoxAnalytics.ValueMember = "Id";
        }
    }
}
