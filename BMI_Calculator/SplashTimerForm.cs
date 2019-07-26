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
 * Last modified: July 25, 2019
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
        /// <summary>
        /// This is the event handler for the SplashTimerForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimerForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
        /// <summary>
        /// This is the event handler for the Tick event of SplashTimer and hide SplashTimerForm and show bmiCalculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.bmiCalculator.Show();
            this.Hide();
        }
    }
}
