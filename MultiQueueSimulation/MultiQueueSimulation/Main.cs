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
using System.IO;
namespace MultiQueueSimulation
{
    public partial class Main : Form
    {
    public static string passing_file_path="";    //passing to open result.cs to test//
        SimulationSystem Program;
        List<String> file = new List<string>();
        int j=0;
        static decimal commprob;
        public Main()
        {
            InitializeComponent();
            Program = new SimulationSystem();
        }
        static public TimeDistribution TimeDIS(string[] words)
        {

            TimeDistribution tmp = new TimeDistribution();
            tmp.Time = int.Parse(words[0]);
            tmp.Probability = decimal.Parse(words[1]);
            tmp.MinRange = decimal.ToInt32(commprob * 100 + 1);
            commprob += tmp.Probability;
            tmp.MaxRange = decimal.ToInt32(commprob * 100);
            tmp.CummProbability = commprob;
            return tmp;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            commprob = 0;
            for (int i = 13; true; i++)
            {
                if (file[i] == "")
                {
                    j = i + 2;
                    break;
                }
                string[] words = file[i].Split(',');
                Program.InterarrivalDistribution.Add(TimeDIS(words));
             }
            int Count = int.Parse(file[1]);
            Program.StoppingNumber = int.Parse(file[4]);
            if (int.Parse(file[7]) == 1)
            {
                Program.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            }
            else
            {
                Program.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;
            }
            if (int.Parse(file[10]) == 1)
            {
                Program.SelectionMethod = Enums.SelectionMethod.HighestPriority;
            }
            else if (int.Parse(file[10]) == 2)
            {
                Program.SelectionMethod = Enums.SelectionMethod.Random;
            }
            else
            {
                Program.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
            }
            Program.NumberOfServers = Count;
            for (int i = 1; i <= Program.NumberOfServers; i++)
            {
                Server tmps = new Server();
                commprob = 0;
                while (j != file.Count)
                {

                    if (file[j] == "")
                    {
                        j += 2;
                        break;
                    }
                    string[] wordss = file[j].Split(',');
                    tmps.ID = i;
                    tmps.TimeDistribution.Add(TimeDIS(wordss));
                    j++;
                }
                Program.Servers.Add(tmps);
            }
            Results form = new Results(ref Program);
            form.Show();
            Main form1 = new Main();
            form1.Close();
        }
        
        private void ClientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReadFile_Click(object sender, EventArgs e) // 1
        {
            
            String Path=null;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                textBox1.Text = openFileDialog1.FileName;//
                
                Path = textBox1.Text;

                passing_file_path = Path;
            }
            Console.WriteLine(result); // <-- For debugging use.
            FileStream fs = new FileStream(Path, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                file.Add(sr.ReadLine());
            }
            sr.Close();
            fs.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            ///
        }
    }
}
