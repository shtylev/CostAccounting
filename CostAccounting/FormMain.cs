﻿using System;
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
using CostAccounting.Model_Data;

namespace CostAccounting
{
    public partial class formMain : Form
    {
        //свойство для определения, не закрывается ли форма
        private bool FormIsClosed { get; set; } = false;

        public formMain()
        {
            InitializeComponent();

            txtSumCost.LostFocus += new EventHandler(txtSumCost_LostFocus);
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            ComboBoxEntities.FillComboBox(cmbCostsAnalytics, AnalyticsEntities.GetAnalytics());
            ComboBoxEntities.FillComboBox(cmbCostsArticles, ArticlesEntities.GetArticles());
        }
        private void txtSumCost_LostFocus(object sender, EventArgs e)
        {
            if (!NumbersValidation.CheckForTheNumberDouble(txtSumCost.Text, FormIsClosed))
            {
                MessageBox.Show("Сумма расходов должна быть числом!");
                txtSumCost.Focus();
            }
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
            FormReferences formReference = new FormReferences();
            formReference.lblTypeReference.Text = typeReference;
            formReference.ShowDialog();
        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Config.db.Dispose();
        }

        private void menuItemAddSaldoBegin_Click(object sender, EventArgs e)
        {
            FormAddSaldoBegin formAddSaldoBegin = new FormAddSaldoBegin();
            formAddSaldoBegin.ShowDialog();
        }        

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormIsClosed = true;
        }

        private void btnAddCost_Click(object sender, EventArgs e)
        {
            Costs cost = new Costs();

            try
            {
                //добавляем расход в таблицу
                cost.IdAnalytic = (int)cmbCostsAnalytics.SelectedValue;
                cost.IdArticle = (int)cmbCostsArticles.SelectedValue;
                cost.Sum = txtSumCost.Text == "" ? 0 : Math.Round(Convert.ToDouble(txtSumCost.Text.Replace(",", ".")), 2);
                cost.Message = txtCostMessage.Text == "" ? null : txtCostMessage.Text;
                cost.Date = dtpCostDate.Value.Date;
                Config.db.Costs.Add(cost);
                //Config.db.SaveChanges();

                //прибавление суммы к общей сумме сальдо на конец периода
                

                //если нет общей суммы в сальдо на конец периода добавляемой в расходы аналитики, то создавать

                dataGridView1.DataSource = CostsEntities.GetCosts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
