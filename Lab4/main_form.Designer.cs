namespace Lab5
{
    partial class main_form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.x_t = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Ekin_t = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Epot_t = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.E_t = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.x_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ekin_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epot_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase)).BeginInit();
            this.SuspendLayout();
            // 
            // x_t
            // 
            chartArea6.Name = "ChartArea1";
            this.x_t.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.x_t.Legends.Add(legend6);
            this.x_t.Location = new System.Drawing.Point(12, 25);
            this.x_t.Name = "x_t";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.x_t.Series.Add(series6);
            this.x_t.Size = new System.Drawing.Size(250, 250);
            this.x_t.TabIndex = 0;
            this.x_t.Text = "chart1";
            // 
            // Ekin_t
            // 
            chartArea7.Name = "ChartArea1";
            this.Ekin_t.ChartAreas.Add(chartArea7);
            legend7.Enabled = false;
            legend7.Name = "Legend1";
            this.Ekin_t.Legends.Add(legend7);
            this.Ekin_t.Location = new System.Drawing.Point(268, 25);
            this.Ekin_t.Name = "Ekin_t";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.Ekin_t.Series.Add(series7);
            this.Ekin_t.Size = new System.Drawing.Size(250, 250);
            this.Ekin_t.TabIndex = 1;
            this.Ekin_t.Text = "chart2";
            // 
            // Epot_t
            // 
            chartArea8.Name = "ChartArea1";
            this.Epot_t.ChartAreas.Add(chartArea8);
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.Epot_t.Legends.Add(legend8);
            this.Epot_t.Location = new System.Drawing.Point(12, 298);
            this.Epot_t.Name = "Epot_t";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.Epot_t.Series.Add(series8);
            this.Epot_t.Size = new System.Drawing.Size(250, 250);
            this.Epot_t.TabIndex = 2;
            this.Epot_t.Text = "chart3";
            // 
            // E_t
            // 
            chartArea9.Name = "ChartArea1";
            this.E_t.ChartAreas.Add(chartArea9);
            legend9.Enabled = false;
            legend9.Name = "Legend1";
            this.E_t.Legends.Add(legend9);
            this.E_t.Location = new System.Drawing.Point(268, 298);
            this.E_t.Name = "E_t";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.E_t.Series.Add(series9);
            this.E_t.Size = new System.Drawing.Size(250, 250);
            this.E_t.TabIndex = 3;
            this.E_t.Text = "chart4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "x(t)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eкін(t)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Eпот(t)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "E(t)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Фазовий портрет гармонічного осцилятора";
            // 
            // phase
            // 
            chartArea10.Name = "ChartArea1";
            this.phase.ChartAreas.Add(chartArea10);
            legend10.Enabled = false;
            legend10.Name = "Legend1";
            this.phase.Legends.Add(legend10);
            this.phase.Location = new System.Drawing.Point(524, 25);
            this.phase.Name = "phase";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.phase.Series.Add(series10);
            this.phase.Size = new System.Drawing.Size(500, 506);
            this.phase.TabIndex = 4;
            this.phase.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Далі";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phase);
            this.Controls.Add(this.E_t);
            this.Controls.Add(this.Epot_t);
            this.Controls.Add(this.Ekin_t);
            this.Controls.Add(this.x_t);
            this.Name = "main_form";
            this.Text = "Моделювання коливних процесів";
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.x_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ekin_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epot_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart x_t;
        private System.Windows.Forms.DataVisualization.Charting.Chart Ekin_t;
        private System.Windows.Forms.DataVisualization.Charting.Chart Epot_t;
        private System.Windows.Forms.DataVisualization.Charting.Chart E_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart phase;
        private System.Windows.Forms.Button button1;
    }
}

