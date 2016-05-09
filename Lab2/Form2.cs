using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2(List<double> Temp, List<double> ExperimentalTemp, List<double> Time, List<double> Accuracy)
        {
            InitializeComponent();
            for (int i = 0; i < Temp.Count; i++)
                dataGridView1.Rows.Add(Time[i], Math.Round(Temp[i], 5), Math.Round(ExperimentalTemp[i], 5), Math.Round(Accuracy[i], 5));
        }
    }
}
