using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationCase
    {
        public SimulationCase()
        {
            this.AssignedServer = null;
        }

        public int CustomerNumber { get; set; }
        public int RandomInterArrival { get; set; }
        public int InterArrival { get; set; }
        public int ArrivalTime { get; set; }
        public int RandomService { get; set; }
        
        /// ////////////////////////
        
        public Server AssignedServer { get; set; }
        public int StartTime { get; set; }
        public int ServiceTime { get; set; }
        public int EndTime { get; set; }
        public int TimeInQueue { get; set; }
    }
}
