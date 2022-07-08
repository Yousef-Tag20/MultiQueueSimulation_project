using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    public partial class ServerResults : Form
    {
        public ServerResults(int i, SimulationSystem Program)
        {
            InitializeComponent();
            ResultsGraph.Series.Add("Server " + Program.Servers[i].ID.ToString());
            ResultsGraph.ChartAreas[0].AxisX.Minimum = 1;
            ResultsGraph.ChartAreas[0].AxisX.Maximum = Program.Servers[i].FinishTime;
            ResultsGraph.ChartAreas[0].AxisX.Interval = 1;
            ResultsGraph.ChartAreas[0].AxisY.Interval = 1;
            foreach (KeyValuePair<int, int> j in Program.Servers[i].Ranges) {
                for (int k = j.Key; k <= j.Value; k++) {
                    ResultsGraph.Series[0].Points.AddXY(k, 1);
                }
            }
        }

        private void ResultsGraph_Click(object sender, EventArgs e)
        {

        }

        private void ServerResults_Load(object sender, EventArgs e)
        {

        }
    }
}
