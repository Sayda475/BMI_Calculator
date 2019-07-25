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
    public partial class BMICalculator : Form
    {
        private double _Height { get; set; }
        private double _Weight { get; set; }
        private double _BMI { get; set; }
        //private double _BMI_Level { get; set; }
        public BMICalculator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for ImperialButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            Height_value_Label.Text = "in";
            Weight_Value_Label.Text = "lb";
            Result_Text_Box.Text = string.Empty;

        }
        /// <summary>
        /// This is the event handler for MetricButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            Height_value_Label.Text = "cm";
            Weight_Value_Label.Text = "kg";
            Result_Text_Box.Text = string.Empty;
        }
        /// <summary>
        /// This is the event handler for CalculateButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Result_Text_Box.Text = _BMI.ToString("F1");

            double _Height = Convert.ToDouble(Height_Text_Box.Text);
            double _Weight = Convert.ToDouble (Weight_Text_Box.Text);
            if (_Height != 0 && _Weight != 0)
            {
                if (MetricButton.Checked == true)
                {
                    _BMI = (_Weight / _Height / _Height) * 10000;
                    Result_Text_Box.Text = string.Format($"{_BMI:F1}").ToString();

                    DisplayCondition();
                }
                else if (ImperialButton.Checked == true)
                {
                    _BMI = _Weight * 703 / (_Height * _Height);
                    Result_Text_Box.Text = string.Format($"{_BMI:F1}").ToString();
                    DisplayCondition();
                }
            }

            else
            {
                Result_Text_Box.Text = "Please enter all values";
                Result_Text_Box.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// This the event hanlder for ResetButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            ImperialButton.Checked = true;
            MetricButton.Checked = false;
            Height_value_Label.Text = "in";
            Weight_Value_Label.Text = "lb";
            Height_Text_Box.Text = string.Empty;
            Weight_Text_Box.Text = string.Empty;
            Result_Text_Box.Text = string.Empty;
            Condition_Text_Box.Text = string.Empty;
            Condition_Text_Box.BackColor = Color.Black;
            BMI_Progress_Bar.Value = 0;
        }

        private void DisplayCondition()
        {

            if (_BMI <= 18.5)
            {
                BMI_Progress_Bar.ForeColor = Color.Wheat;
                BMI_Progress_Bar.Value = 25;
                Condition_Text_Box.Text = "Underweight";
                Condition_Text_Box.ForeColor = Color.Wheat;
                Condition_Text_Box.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (_BMI <= 24.9)
            {
                BMI_Progress_Bar.ForeColor = Color.DarkSeaGreen;
                Condition_Text_Box.Text = "Normal";
                BMI_Progress_Bar.Value = 50;
                Condition_Text_Box.ForeColor = Color.DarkSeaGreen;
                Condition_Text_Box.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (_BMI <= 29.9)
            {
                BMI_Progress_Bar.ForeColor = Color.SandyBrown;
                Condition_Text_Box.Text = "Overweight";
                BMI_Progress_Bar.Value = 75;
                Condition_Text_Box.ForeColor = Color.SandyBrown;
                Condition_Text_Box.Font = new Font(this.Font, FontStyle.Bold);
            }
            else if (_BMI >= 30)
            {
                BMI_Progress_Bar.ForeColor = Color.Tomato;
                Condition_Text_Box.Text = "Obese";
                BMI_Progress_Bar.Value = 100;
                Condition_Text_Box.ForeColor = Color.Tomato;
                Condition_Text_Box.Font = new Font(this.Font, FontStyle.Bold);
            }
        }
        /// <summary>
        /// This is the event handler for the Height_Text_Box KeyPress event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Height_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericDigit(e);
        }

        /// <summary>
        /// This is the event handler for the Weight_Text_Box KeyPress event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Weight_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumericDigit(e);
        }

        /// <summary>
        /// This is the method to validate field content for only numeric values
        /// </summary>
        /// <param name="e"></param>
        private static void ValidateNumericDigit(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// This is the event handler for the load form event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// This is the event handler for the closing form event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }  
    }
}      
    

