namespace BMI_Calculator
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.Height_Text_Box = new System.Windows.Forms.TextBox();
            this.Weight_Text_Box = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Weight_Value_Label = new System.Windows.Forms.Label();
            this.Height_value_Label = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMILabel = new System.Windows.Forms.Label();
            this.Result_Text_Box = new System.Windows.Forms.TextBox();
            this.BMI_Progress_Bar = new System.Windows.Forms.ProgressBar();
            this.Condition_Text_Box = new System.Windows.Forms.TextBox();
            this.Condition_Label = new System.Windows.Forms.Label();
            this.Underweight_Label = new System.Windows.Forms.Label();
            this.Normal_Label = new System.Windows.Forms.Label();
            this.Overweight_Label = new System.Windows.Forms.Label();
            this.Obese_Label = new System.Windows.Forms.Label();
            this.BMITableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Location = new System.Drawing.Point(30, 6);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialButton.TabIndex = 1;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // MetricButton
            // 
            this.MetricButton.AutoSize = true;
            this.MetricButton.Location = new System.Drawing.Point(163, 5);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(106, 35);
            this.MetricButton.TabIndex = 2;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // Height_Text_Box
            // 
            this.Height_Text_Box.Location = new System.Drawing.Point(155, 3);
            this.Height_Text_Box.Name = "Height_Text_Box";
            this.Height_Text_Box.Size = new System.Drawing.Size(84, 38);
            this.Height_Text_Box.TabIndex = 4;
            this.Height_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Height_Text_Box_KeyPress);
            // 
            // Weight_Text_Box
            // 
            this.Weight_Text_Box.Location = new System.Drawing.Point(155, 44);
            this.Weight_Text_Box.Name = "Weight_Text_Box";
            this.Weight_Text_Box.Size = new System.Drawing.Size(84, 38);
            this.Weight_Text_Box.TabIndex = 5;
            this.Weight_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Weight_Text_Box_KeyPress);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(136, 41);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "My Height";
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 41);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(141, 42);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "My Weight";
            // 
            // BMITableLayoutPanel
            // 
            this.BMITableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMITableLayoutPanel.ColumnCount = 3;
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.83612F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.10033F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.57143F));
            this.BMITableLayoutPanel.Controls.Add(this.Weight_Value_Label, 2, 1);
            this.BMITableLayoutPanel.Controls.Add(this.Weight_Text_Box, 1, 1);
            this.BMITableLayoutPanel.Controls.Add(this.HeightLabel, 0, 0);
            this.BMITableLayoutPanel.Controls.Add(this.WeightLabel, 0, 1);
            this.BMITableLayoutPanel.Controls.Add(this.Height_Text_Box, 1, 0);
            this.BMITableLayoutPanel.Controls.Add(this.Height_value_Label, 2, 0);
            this.BMITableLayoutPanel.Location = new System.Drawing.Point(3, 46);
            this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
            this.BMITableLayoutPanel.RowCount = 2;
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMITableLayoutPanel.Size = new System.Drawing.Size(299, 83);
            this.BMITableLayoutPanel.TabIndex = 6;
            // 
            // Weight_Value_Label
            // 
            this.Weight_Value_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Weight_Value_Label.AutoSize = true;
            this.Weight_Value_Label.Location = new System.Drawing.Point(245, 41);
            this.Weight_Value_Label.Name = "Weight_Value_Label";
            this.Weight_Value_Label.Size = new System.Drawing.Size(35, 42);
            this.Weight_Value_Label.TabIndex = 7;
            this.Weight_Value_Label.Text = "lb";
            // 
            // Height_value_Label
            // 
            this.Height_value_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Height_value_Label.AutoSize = true;
            this.Height_value_Label.Location = new System.Drawing.Point(245, 0);
            this.Height_value_Label.Name = "Height_value_Label";
            this.Height_value_Label.Size = new System.Drawing.Size(35, 41);
            this.Height_value_Label.TabIndex = 6;
            this.Height_value_Label.Text = "in";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(12, 136);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(153, 37);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Calculate BMI";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.LightCoral;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(171, 136);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(121, 37);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMILabel.Location = new System.Drawing.Point(24, 185);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(62, 31);
            this.BMILabel.TabIndex = 9;
            this.BMILabel.Text = "BMI";
            // 
            // Result_Text_Box
            // 
            this.Result_Text_Box.ForeColor = System.Drawing.Color.DimGray;
            this.Result_Text_Box.Location = new System.Drawing.Point(92, 183);
            this.Result_Text_Box.Name = "Result_Text_Box";
            this.Result_Text_Box.Size = new System.Drawing.Size(200, 38);
            this.Result_Text_Box.TabIndex = 10;
            // 
            // BMI_Progress_Bar
            // 
            this.BMI_Progress_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMI_Progress_Bar.Location = new System.Drawing.Point(12, 229);
            this.BMI_Progress_Bar.Name = "BMI_Progress_Bar";
            this.BMI_Progress_Bar.Size = new System.Drawing.Size(280, 25);
            this.BMI_Progress_Bar.TabIndex = 11;
            // 
            // Condition_Text_Box
            // 
            this.Condition_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condition_Text_Box.Location = new System.Drawing.Point(146, 261);
            this.Condition_Text_Box.Multiline = true;
            this.Condition_Text_Box.Name = "Condition_Text_Box";
            this.Condition_Text_Box.Size = new System.Drawing.Size(144, 34);
            this.Condition_Text_Box.TabIndex = 12;
            // 
            // Condition_Label
            // 
            this.Condition_Label.AutoSize = true;
            this.Condition_Label.Location = new System.Drawing.Point(17, 261);
            this.Condition_Label.Name = "Condition_Label";
            this.Condition_Label.Size = new System.Drawing.Size(129, 31);
            this.Condition_Label.TabIndex = 13;
            this.Condition_Label.Text = "Condition";
            // 
            // Underweight_Label
            // 
            this.Underweight_Label.AutoSize = true;
            this.Underweight_Label.BackColor = System.Drawing.Color.Wheat;
            this.Underweight_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Underweight_Label.Location = new System.Drawing.Point(14, 301);
            this.Underweight_Label.Name = "Underweight_Label";
            this.Underweight_Label.Size = new System.Drawing.Size(275, 29);
            this.Underweight_Label.TabIndex = 14;
            this.Underweight_Label.Text = "Underweight        <   18.5";
            // 
            // Normal_Label
            // 
            this.Normal_Label.AutoSize = true;
            this.Normal_Label.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Normal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Normal_Label.Location = new System.Drawing.Point(13, 334);
            this.Normal_Label.Name = "Normal_Label";
            this.Normal_Label.Size = new System.Drawing.Size(274, 29);
            this.Normal_Label.TabIndex = 15;
            this.Normal_Label.Text = "Normal         18.5 to 24.9 ";
            // 
            // Overweight_Label
            // 
            this.Overweight_Label.AutoSize = true;
            this.Overweight_Label.BackColor = System.Drawing.Color.SandyBrown;
            this.Overweight_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overweight_Label.Location = new System.Drawing.Point(13, 368);
            this.Overweight_Label.Name = "Overweight_Label";
            this.Overweight_Label.Size = new System.Drawing.Size(276, 29);
            this.Overweight_Label.TabIndex = 16;
            this.Overweight_Label.Text = "Overweight   25.0 to 29.9";
            // 
            // Obese_Label
            // 
            this.Obese_Label.AutoSize = true;
            this.Obese_Label.BackColor = System.Drawing.Color.Tomato;
            this.Obese_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Obese_Label.Location = new System.Drawing.Point(14, 402);
            this.Obese_Label.Name = "Obese_Label";
            this.Obese_Label.Size = new System.Drawing.Size(276, 29);
            this.Obese_Label.TabIndex = 17;
            this.Obese_Label.Text = "Obese                     >    30";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.Obese_Label);
            this.Controls.Add(this.Overweight_Label);
            this.Controls.Add(this.Normal_Label);
            this.Controls.Add(this.Underweight_Label);
            this.Controls.Add(this.Condition_Label);
            this.Controls.Add(this.Condition_Text_Box);
            this.Controls.Add(this.BMI_Progress_Bar);
            this.Controls.Add(this.Result_Text_Box);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.BMITableLayoutPanel);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.ImperialButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.BMITableLayoutPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.TextBox Height_Text_Box;
        private System.Windows.Forms.TextBox Weight_Text_Box;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TableLayoutPanel BMITableLayoutPanel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.TextBox Result_Text_Box;
        private System.Windows.Forms.ProgressBar BMI_Progress_Bar;
        private System.Windows.Forms.TextBox Condition_Text_Box;
        private System.Windows.Forms.Label Condition_Label;
        private System.Windows.Forms.Label Underweight_Label;
        private System.Windows.Forms.Label Normal_Label;
        private System.Windows.Forms.Label Overweight_Label;
        private System.Windows.Forms.Label Obese_Label;
        private System.Windows.Forms.Label Weight_Value_Label;
        private System.Windows.Forms.Label Height_value_Label;
    }
}

