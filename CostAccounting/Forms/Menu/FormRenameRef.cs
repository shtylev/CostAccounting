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
    public partial class FormRenameRef : Form
    {
        FormReferences formRef;
        public FormRenameRef(FormReferences formRef)
        {
            InitializeComponent();
            this.formRef = formRef;
        }

        private void FormRenameRef_Load(object sender, EventArgs e)
        {
            if (formRef.lblTypeReference.Text == Resources.Analytics)
                this.Text = "Переименование аналитики";
            if(formRef.lblTypeReference.Text == Resources.Articles)
                this.Text = "Переименование статьи";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNewNameRef.Text != "")
            {
                string result = "";

                //получаем id выбранного справочника
                int idRef = (int)formRef.listBoxReference.SelectedValue;

                if (formRef.lblTypeReference.Text == Resources.Analytics)
                    result = AnalyticsModel.RenameAnalytic(txtNewNameRef.Text, idRef);
                if (formRef.lblTypeReference.Text == Resources.Articles)
                    result = ArticlesModel.RenameArticle(txtNewNameRef.Text, idRef);

                if (result == Resources.OK)
                {
                    formRef.GetReference();
                    this.Close();
                }                    
                else
                    MessageBox.Show(result, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
