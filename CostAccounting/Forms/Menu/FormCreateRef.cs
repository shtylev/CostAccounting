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
    public partial class FormCreateRef : Form
    {
        private FormReferences formRef;
        public FormCreateRef(FormReferences formRef)
        {
            InitializeComponent();
            this.formRef = formRef;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string result = "";

            if (formRef.lblTypeReference.Text == Resources.Analytics)
                result = AnalyticsModel.CreateAnalytic(txtNameRef.Text);
            if (formRef.lblTypeReference.Text == Resources.Articles)
                result = ArticlesModel.CreateArticle(txtNameRef.Text);

            if (result == Resources.OK)
            {
                formRef.GetReference();
                this.Close();
            }
            else
                MessageBox.Show(result, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FormCreateRef_Load(object sender, EventArgs e)
        {
            if (formRef.lblTypeReference.Text == Resources.Analytics)
                this.Text = "Создание аналитики";
            if (formRef.lblTypeReference.Text == Resources.Articles)
                this.Text = "Создание статьи";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();            
        }
    }
}
