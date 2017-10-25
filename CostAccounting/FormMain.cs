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

namespace CostAccounting
{
    public partial class formMain : Form
    {
        FormReferences formReference = new FormReferences();

        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            
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
            formReference.lblTypeReference.Text = typeReference;
            formReference.ShowDialog();
        }
    }
}
