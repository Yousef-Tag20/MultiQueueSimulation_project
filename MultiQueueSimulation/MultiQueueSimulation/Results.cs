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
    public partial class Results : Form
    {
        SimulationSystem Program;
        public Results(ref SimulationSystem Program)
        {
            InitializeComponent();
            this.Program = Program;
        }
    
        private void View()
        {
            Output.Rows.Add(Program.SimulationTable.Count);
            for(int i = 0; i < Program.SimulationTable.Count; i++)
            {
                Output.Rows[i].Cells[0].Value = Program.SimulationTable[i].CustomerNumber.ToString();
                Output.Rows[i].Cells[1].Value = Program.SimulationTable[i].RandomInterArrival.ToString();
                Output.Rows[i].Cells[2].Value = Program.SimulationTable[i].InterArrival.ToString();
                Output.Rows[i].Cells[3].Value = Program.SimulationTable[i].ArrivalTime.ToString();
                Output.Rows[i].Cells[4].Value = Program.SimulationTable[i].RandomService.ToString();
                Output.Rows[i].Cells[5].Value = Program.SimulationTable[i].AssignedServer.ID.ToString();
                Output.Rows[i].Cells[6].Value = Program.SimulationTable[i].StartTime.ToString();
                Output.Rows[i].Cells[7].Value = Program.SimulationTable[i].ServiceTime.ToString();
                Output.Rows[i].Cells[8].Value = Program.SimulationTable[i].EndTime.ToString();
                Output.Rows[i].Cells[9].Value = Program.SimulationTable[i].TimeInQueue.ToString();
            }
            for (int i = 0; i < Program.Servers.Count; i++) {
                ServerResults form = new ServerResults(i, Program);
                form.Show();
            }
            }
        private void Simulate_Click(object sender, EventArgs e)
        {
                Program.Run();
                View();
            String ppath = "";
            

            String check = Main.passing_file_path;
            
            
            
            if(Main.passing_file_path.Contains(Constants.FileNames.TestCase1)) { ppath = Constants.FileNames.TestCase1; }
                else if (Main.passing_file_path.Contains(Constants.FileNames.TestCase2)) { ppath = Constants.FileNames.TestCase2;  }
                else if(Main.passing_file_path.Contains(Constants.FileNames.TestCase3)) { ppath = Constants.FileNames.TestCase3; }

            string testingResult = TestingManager.Test(Program,ppath);
                MessageBox.Show(testingResult);
            
        }

        private void Output_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ///
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Program.PerformanceMeasures.AverageWaitingTime.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Program.PerformanceMeasures.MaxQueueLength.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = Program.PerformanceMeasures.WaitingProbability.ToString();
        }

        private void Results_Load(object sender, EventArgs e)
        {

        }
    }
}
