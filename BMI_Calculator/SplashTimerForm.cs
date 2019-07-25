using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* BMI Calculator
 * Author: Sayda Rahman
 * ID# 301042327
 * Last modified: July 24, 2019
 * Description: COMP123 Assignment4- calculation of BMI by using imperial or metric units.
 */
namespace BMI_Calculator
{
    public partial class SplashTimerForm : Form
    {
        public SplashTimerForm()
        {
            InitializeComponent();
        }

        private void SplashTimerForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.bmiCalculator.Show();
            Program.splashTimerForm.Close();
            this.Hide();
        }
    }
}
