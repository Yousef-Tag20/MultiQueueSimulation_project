using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Enums
    {
        public enum SelectionMethod
        {
            HighestPriority = 1,
            Random = 2,
            LeastUtilization = 3
        }
        /// <summary>
        /// /
        /// </summary>
        public enum StoppingCriteria
        {
            NumberOfCustomers = 1,
            SimulationEndTime = 2
        }
    }
}
