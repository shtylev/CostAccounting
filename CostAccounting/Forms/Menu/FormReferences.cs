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
            FormCreateRef formCreateRef = new FormCreateRef(this);
            formCreateRef.ShowDialog();
        }

        public void GetReference()
        {
            if (lblTypeReference.Text == Resources.Analytics)
            {
                this.Text = Resources.Analytics;
                listBoxReference.DataSource = AnalyticsEntities.GetAnalytics();
            }
            if (lblTypeReference.Text == Resources.Articles)
            {
                this.Text = Resources.Articles;
                listBoxReference.DataSource = ArticlesEntities.GetArticles();
            }

            listBoxReference.DisplayMember = "Name";
            listBoxReference.ValueMember = "Id";
        }

        private void conMenuRename_Click(object sender, EventArgs e)
        {
            FormRenameRef formRenRef = new FormRenameRef(this);
            formRenRef.ShowDialog();
        }

        private void conMenuAddArchive_Click(object sender, EventArgs e)
        {
            int idRef = (int)listBoxReference.SelectedValue;
            string result = "";

            DialogResult resultDialog = MessageBox.Show("Вы уверены в своих действиях?", "Перемещение в архив", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            if(resultDialog == DialogResult.Yes)
            {
                if (lblTypeReference.Text == Resources.Analytics)                
                    result = AnalyticsEntities.AddAnalyticToArchive(idRef);
                
                if (lblTypeReference.Text == Resources.Articles)                
                    result = ArticlesEntities.AddArticleToArchive(idRef);

                if (result == Resources.OK)
                    GetReference();
                else
                    MessageBox.Show(result, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void conMenuShowArchive_Click(object sender, EventArgs e)
        {
            FormRefArchive formRefArchive = new FormRefArchive(this);
            formRefArchive.ShowDialog();
        }

        private void conMenuEditColor_Click(object sender, EventArgs e)
        {
            int idRef = (int)listBoxReference.SelectedValue;
            Analytics analytic = new Analytics();
            Articles article = new Articles();

            //устанавливаем цвет для выбранного справочника в colordialog
            if (lblTypeReference.Text == Resources.Analytics)
            {
                analytic = AnalyticsEntities.GetAnalyticById(idRef);

                if (analytic != null && analytic.Color != null)
                    colorDialogRef.Color = Colors.GetColor(analytic.Color);
                else
                    colorDialogRef.Color = Color.White;
            }
            if (lblTypeReference.Text == Resources.Articles)
            {
                article = ArticlesEntities.GetArticleById(idRef);

                if(article != null && article.Color != null)
                    colorDialogRef.Color = Colors.GetColor(article.Color);
                else
                    colorDialogRef.Color = Color.White;
            }

            //устанавливаем новый цвет для выбранного справочника
            if (colorDialogRef.ShowDialog() == DialogResult.OK)
            {
                Color colorValue = Color.FromArgb(colorDialogRef.Color.R, colorDialogRef.Color.G, colorDialogRef.Color.B); //приводим к hex виду
                string color = "#" + colorValue.Name;

                if (lblTypeReference.Text == Resources.Analytics)
                {
                    if (analytic != null)
                        analytic.Color = color;
                }
                
                if (lblTypeReference.Text == Resources.Articles)
                {
                    if (article != null)
                        article.Color = color;
                }
                Config.db.SaveChanges();
            }                   
        }
    }
}
