using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nicous
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            ActiveControl = bunifuButton1;
            bunifuCircleProgress1.Value = 0;
            bunifuCircleProgress2.Value = 0;
            await Task.Delay(3000);
            bunifuSnackbar1.Show(this, "Howdy You!, Welcome to Nicous Systems", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2000,"",Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight);
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCircleProgress2_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuChartCanvas1_Load(object sender, EventArgs e)
        {
           
        }
        int dataOne=0;
        int dataTwo = 2;
        private async void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 80; i++)
            {
                dataOne++;
                await Task.Delay(300);
                dataTwo++;
                if (dataOne <= 60) {
                    bunifuCircleProgress1.Value = dataOne;
                }
                await Task.Delay(400);
                if (dataTwo <= 75)
                {
                    bunifuCircleProgress2.Value = dataTwo;
                }
           
    
                else
                {
                    bunifuCircleProgress1.Animated = false;
                    bunifuCircleProgress2.Animated = false;
                    timer1.Stop();
                    break;
                }
            }
        
        }
      
    }
}
