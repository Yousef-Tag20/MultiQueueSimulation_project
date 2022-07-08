using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    /// <summary>
    /// //
    /// </summary>
    public class PerformanceMeasures
    {
        public PerformanceMeasures()
        {
           
        }
        public decimal AverageWaitingTime { get; set; }
        public int MaxQueueLength { get; set; }
        public decimal WaitingProbability { get; set; }

        public void calc_Average_Waiting_Time(decimal totaltimeforcustomerwaited, int customers_num)
        {
            AverageWaitingTime = totaltimeforcustomerwaited / customers_num;
        }
        public void calc_waiting_propablity(decimal numofcustomerwaiting, int customer_num)
        {
            WaitingProbability = numofcustomerwaiting / customer_num;
        }
    }
}
