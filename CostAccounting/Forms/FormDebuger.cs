using CostAccounting.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostAccounting.Forms
{
    public partial class FormDebuger : Form
    {
        public FormDebuger()
        {
            InitializeComponent();
        }

        private void MenuItemPerform_Click(object sender, EventArgs e)
        {
            Debugger debug = new Debugger(txtQuery.Text);
            DataTable result = debug.GetData();
            dgvResultQuery.DataSource = result;
        }
    }
}
