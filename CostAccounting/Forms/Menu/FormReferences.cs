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
            if (lblTypeReference.Text == Resources.Analytics)
            {
                this.Text = Resources.Analytics;
                listBoxAnalytics.DataSource = Analytics.GetAnalitics();
            }
            if (lblTypeReference.Text == Resources.Articles)
            {
                this.Text = Resources.Articles;
                listBoxAnalytics.DataSource = Articles.GetArticles();                
            }

            listBoxAnalytics.DisplayMember = "Name";
            listBoxAnalytics.ValueMember = "Id";
        }
    }
}
