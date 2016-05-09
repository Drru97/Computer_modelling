namespace Lab5
{
    partial class additional_form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.E_t = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Epot_t = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Ekin_t = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.x_t = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epot_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ekin_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_t)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Фазовий портрет гармонічного осцилятора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "E(t)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Eпот(t)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Eкін(t)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "x(t)";
            // 
            // phase
            // 
            chartArea1.Name = "ChartArea1";
            this.phase.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.phase.Legends.Add(legend1);
            this.phase.Location = new System.Drawing.Point(524, 24);
            this.phase.Name = "phase";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.phase.Series.Add(series1);
            this.phase.Size = new System.Drawing.Size(500, 517);
            this.phase.TabIndex = 15;
            this.phase.Text = "chart1";
            // 
            // E_t
            // 
            chartArea2.Name = "ChartArea1";
            this.E_t.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.E_t.Legends.Add(legend2);
            this.E_t.Location = new System.Drawing.Point(268, 297);
            this.E_t.Name = "E_t";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.E_t.Series.Add(series2);
            this.E_t.Size = new System.Drawing.Size(250, 250);
            this.E_t.TabIndex = 14;
            this.E_t.Text = "chart4";
            // 
            // Epot_t
            // 
            chartArea3.Name = "ChartArea1";
            this.Epot_t.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.Epot_t.Legends.Add(legend3);
            this.Epot_t.Location = new System.Drawing.Point(12, 297);
            this.Epot_t.Name = "Epot_t";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Epot_t.Series.Add(series3);
            this.Epot_t.Size = new System.Drawing.Size(250, 250);
            this.Epot_t.TabIndex = 13;
            this.Epot_t.Text = "chart3";
            // 
            // Ekin_t
            // 
            chartArea4.Name = "ChartArea1";
            this.Ekin_t.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.Ekin_t.Legends.Add(legend4);
            this.Ekin_t.Location = new System.Drawing.Point(268, 24);
            this.Ekin_t.Name = "Ekin_t";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.Ekin_t.Series.Add(series4);
            this.Ekin_t.Size = new System.Drawing.Size(250, 250);
            this.Ekin_t.TabIndex = 12;
            this.Ekin_t.Text = "chart2";
            // 
            // x_t
            // 
            chartArea5.Name = "ChartArea1";
            this.x_t.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.x_t.Legends.Add(legend5);
            this.x_t.Location = new System.Drawing.Point(12, 24);
            this.x_t.Name = "x_t";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.x_t.Series.Add(series5);
            this.x_t.Size = new System.Drawing.Size(250, 250);
            this.x_t.TabIndex = 11;
            this.x_t.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "label6";
            // 
            // additional_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 563);
            this.Controls.Add(this.label6);
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
            this.Name = "additional_form";
            this.Text = "Моделювання коливних процесів";
            this.Load += new System.EventHandler(this.additional_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Epot_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ekin_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_t)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart phase;
        private System.Windows.Forms.DataVisualization.Charting.Chart E_t;
        private System.Windows.Forms.DataVisualization.Charting.Chart Epot_t;
        private System.Windows.Forms.DataVisualization.Charting.Chart Ekin_t;
        private System.Windows.Forms.DataVisualization.Charting.Chart x_t;
        private System.Windows.Forms.Label label6;
    }
}