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

namespace CostAccounting
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void menuItemAnalyticsReference_Click(object sender, EventArgs e)
        {
            FormAnalytics formAnalytics = new FormAnalytics();
            formAnalytics.ShowDialog();
        }
    }
}
