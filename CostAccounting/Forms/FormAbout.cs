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
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();

            label2.Text = "С наилучшими пожеланиями,\nс любовью, всегда Ваш LEOpoldik!";
            label3.Text = "Copyright \u00A9 2017 Штылев Александр";
        }
    }
}
