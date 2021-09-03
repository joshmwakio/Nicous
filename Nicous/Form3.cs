using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nicous
{
    public partial class DashForm : Form
    {
        public DashForm()
        {
            InitializeComponent();
        }

        private void DashForm_Load(object sender, EventArgs e)
        {
            List<Double> profitDataList = new List<double>()
            {
                50.90,
                70,
                80,
                90,
                53,
                45,
                73
            };
            List<Double> expenseDataList = new List<double>()
            {
                50,
                75,
                30,
                50,
                43,
                95,
                73
            };
            bunifuBarChart1.Data = profitDataList;
            bunifuBarChart2.Data = expenseDataList;
        }
    }
}
