using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SplashTimerForm splashTimerForm;
        public static BMICalculator bmiCalculator;
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashTimerForm = new SplashTimerForm();
            bmiCalculator = new BMICalculator();
            Application.Run(splashTimerForm);
        }
    }
}
