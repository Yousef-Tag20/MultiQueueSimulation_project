using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    /// <summary>
    /// /
    /// </summary>
    public class Server
    {
        public Server()
        {
            this.TimeDistribution = new List<TimeDistribution>();
            this.Served = 0;
            this.IdleProbability = 0;
            this.TotalIdleTime = 0;
            this.Utilization = 0;
            this.TotalWorkingTime = 0;
            this.AverageServiceTime = 0;
            this.FinishTime = 0;
            this.Ranges = new List<KeyValuePair<int, int>>();
        }
        public int GetServiceTime(int Random)
        {
            
            foreach (TimeDistribution i in TimeDistribution)
            {
                if (i.MinRange <= Random && Random <= i.MaxRange)
                    return i.Time;
            }
            return 1;
        }
        
        public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; } 
        public decimal Utilization { get; set; }
        public List<KeyValuePair<int, int>> Ranges;
        public List<TimeDistribution> TimeDistribution;

        //optional if needed use them
        // when the server will be available
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }
        public int TotalIdleTime { get; set; }
        public int Served { get; set; }
    }
}
