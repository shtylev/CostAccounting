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
    public partial class FormRefArchive : Form
    {
        private FormReferences formRef;
        public FormRefArchive(FormReferences formRef)
        {
            InitializeComponent();
            this.formRef = formRef;
        }

        private void FormRefArchive_Load(object sender, EventArgs e)
        {
            GetRefArchive();
        }
        private void GetRefArchive()
        {
            if (formRef.lblTypeReference.Text == Resources.Analytics)
            {
                this.Text = "Архив аналитик";
                listBoxRefArchive.DataSource = AnalyticsModel.GerAnalyticsArchive();
            }
            if (formRef.lblTypeReference.Text == Resources.Articles)
            {
                this.Text = "Архив статей";
                listBoxRefArchive.DataSource = ArticlesModel.GetArticlesArchive();
            }

            listBoxRefArchive.DisplayMember = "Name";
            listBoxRefArchive.ValueMember = "Id";
        }
    }
}
