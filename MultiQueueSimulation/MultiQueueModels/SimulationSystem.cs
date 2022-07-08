using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    
    /// ///
    
    public class SimulationSystem
    {
        Random Generator;
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
            this.Generator = new Random();
        }
        public int GetInterarrivalTime(int Random)
        {
            foreach (TimeDistribution i in InterarrivalDistribution)
            {
                if (i.MinRange <= Random && Random <= i.MaxRange)
                    return i.Time;
            }
            return -1;
        }
        private int GetNextServingServer(int time)

        {
            if (SelectionMethod == Enums.SelectionMethod.HighestPriority)////Highest priority the first idle server
            {
                for (int i = 0; i < Servers.Count; i++)
                {
                    if (Servers[i].FinishTime <= time) return i;
                }
                int finish = Servers[0].FinishTime, ID = 0;
                for (int i = 1; i < Servers.Count; i++)
                {
                    if (finish > Servers[i].FinishTime)
                    {
                        finish = Servers[i].FinishTime;
                        ID = i;
                    }
                }
                return ID;
            }
            else if(SelectionMethod == Enums.SelectionMethod.Random)  ///random server collect idle server in list then chose randomly from the list
            {
                List<int> Active = new List<int>();
                int finish = Servers[0].FinishTime;
                for (int i = 0; i < Servers.Count; i++)
                {
                    if (Servers[i].FinishTime <= time) Active.Add(i);
                    finish = Math.Min(finish,Servers[i].FinishTime);
                }

                if (Active.Count == 0)
                {
                    for (int i = 0; i < Servers.Count; i++)
                        if (Servers[i].FinishTime == finish) Active.Add(i);
                }

                int idx = Generator.Next(0, Active.Count - 1);
                return Active[idx];
            }
            else //least utalization
            {
                List<int> Active = new List<int>();
                int finish = Servers[0].FinishTime;
                for (int i = 0; i < Servers.Count; i++) {
                    if (Servers[i].FinishTime <= time)
                        Active.Add(i);
                    finish = Math.Min(finish, Servers[i].FinishTime);
                }

                if (Active.Count == 0) {
                    for (int i = 0; i < Servers.Count; i++)
                        if (Servers[i].FinishTime == finish) Active.Add(i);
                }

                int id = Active[0], currtot = Servers[Active[0]].TotalWorkingTime;
                for (int i = 1; i < Active.Count; i++) {
                    int idx = Active[i];
                    if (Servers[idx].TotalWorkingTime < currtot) {
                        currtot = Servers[idx].TotalWorkingTime;
                        id = idx;
                    }
                }
                return id;
            }

        }
        private int CountWaiting(int time)
        {
            int ans = 0;
            foreach (SimulationCase Curr in SimulationTable)
            {
                if (Curr.ArrivalTime >= time) break;
                if (Curr.AssignedServer == null) ans++;
            }
            return ans;
        }
        private int GetMaxQueueTime()
        {
            int ans = 0;
            for (int i = 0; i < SimulationTable.Count; i++)
            {
                int c = 1;
                for (int j = i + 1; j < SimulationTable.Count; j++)
                {
                    if (SimulationTable[i].StartTime > SimulationTable[j].ArrivalTime)
                        c++;
                }
                ans = Math.Max(c, ans);
            }
            return ans;
        }
        private void Serve()
        {
            if (StoppingCriteria == Enums.StoppingCriteria.NumberOfCustomers)
            {
                int MaxQueue = 0, CustomersWaited = 0, TimeWaited = 0, MaxFinish = 0;
                foreach (SimulationCase Current in SimulationTable)
                {
                    int idx = GetNextServingServer(Current.ArrivalTime);
                    MaxQueue = Math.Max(MaxQueue, CountWaiting(Servers[idx].FinishTime));
                    Current.AssignedServer = Servers[idx];
                    Current.StartTime = Math.Max(Current.AssignedServer.FinishTime, Current.ArrivalTime);
                    Current.ServiceTime = Current.AssignedServer.GetServiceTime(Current.RandomService);
                    Current.EndTime = Current.StartTime + Current.ServiceTime;
                    Current.TimeInQueue = Current.StartTime - Current.ArrivalTime;
                    MaxFinish = Math.Max(Current.EndTime, MaxFinish);
                    
                    Servers[idx].FinishTime = Current.EndTime;
                    Servers[idx].TotalWorkingTime += Current.ServiceTime;
                    Servers[idx].Served++;
                    Servers[idx].Ranges.Add(new KeyValuePair<int, int>(Current.StartTime, Current.EndTime));

                    if (Current.TimeInQueue > 0)
                    {
                        TimeWaited += Current.TimeInQueue;
                        CustomersWaited++;
                    }
                }
                PerformanceMeasures.MaxQueueLength = MaxQueue;
                PerformanceMeasures.AverageWaitingTime = TimeWaited;
                PerformanceMeasures.AverageWaitingTime /= StoppingNumber;
                PerformanceMeasures.WaitingProbability = CustomersWaited;
                PerformanceMeasures.WaitingProbability /= StoppingNumber;

                foreach (Server i in Servers)
                {
                    i.TotalIdleTime = MaxFinish - i.TotalWorkingTime;
                    i.IdleProbability = i.TotalIdleTime;
                    i.IdleProbability /= MaxFinish;
                    i.AverageServiceTime = i.TotalWorkingTime;
                    i.AverageServiceTime /= Math.Max(i.Served, 1);
                    i.Utilization = i.TotalWorkingTime;
                    i.Utilization /= MaxFinish;
                }
            }
            else
            {
                List<SimulationCase> toberemoved = new List<SimulationCase>();
                int CustomersWaited = 0, TimeWaited = 0, MaxFinish = 0;
                foreach (SimulationCase Current in SimulationTable)
                {
                    int idx = GetNextServingServer(Current.ArrivalTime);
                    int start = Math.Max(Servers[idx].FinishTime, Current.ArrivalTime);
                    int service = Servers[idx].GetServiceTime(Current.RandomService);
                    int end = start + service;
                    if (end <= StoppingNumber)
                    {
                        Current.AssignedServer = Servers[idx];
                        Current.StartTime = Math.Max(Current.AssignedServer.FinishTime, Current.ArrivalTime);
                        Current.ServiceTime = Current.AssignedServer.GetServiceTime(Current.RandomService);
                        Current.EndTime = Current.StartTime + Current.ServiceTime;
                        Current.TimeInQueue = Current.StartTime - Current.ArrivalTime;
                        MaxFinish = Math.Max(Current.EndTime, MaxFinish);
                        
                        Servers[idx].FinishTime = Current.EndTime;
                        Servers[idx].TotalWorkingTime += Current.ServiceTime;
                        Servers[idx].Served++;
                        Servers[idx].Ranges.Add(new KeyValuePair<int, int>(Current.StartTime,Current.EndTime));

                        if (Current.TimeInQueue > 0)
                        {
                            TimeWaited += Current.TimeInQueue;
                            CustomersWaited++;
                        }

                    }
                    else
                        toberemoved.Add(Current);
                }

                foreach (SimulationCase i in toberemoved)
                    SimulationTable.Remove(i);

                PerformanceMeasures.MaxQueueLength = GetMaxQueueTime();
                PerformanceMeasures.AverageWaitingTime = TimeWaited;
                PerformanceMeasures.AverageWaitingTime /= SimulationTable.Count;
                PerformanceMeasures.WaitingProbability = CustomersWaited;
                PerformanceMeasures.WaitingProbability /= SimulationTable.Count;

                foreach (Server i in Servers)
                {
                    i.TotalIdleTime = MaxFinish - i.TotalWorkingTime;
                    i.IdleProbability = i.TotalIdleTime;
                    i.IdleProbability /= MaxFinish;
                    i.AverageServiceTime = i.TotalWorkingTime;
                    i.AverageServiceTime /= Math.Max(i.Served, 1);
                    i.Utilization = i.TotalWorkingTime;
                    i.Utilization /= MaxFinish;
                }
            }
        }
        public void Run()
        {
            int LastCustomer = 0;
            for (int CustomerID = 1; CustomerID <= this.StoppingNumber; CustomerID++)
            {
                SimulationCase CurrentCase = new SimulationCase();
                CurrentCase.CustomerNumber = CustomerID;
                if (CustomerID != 1)
                {
                    CurrentCase.RandomInterArrival = Generator.Next(1, 100);
                    CurrentCase.InterArrival = GetInterarrivalTime(CurrentCase.RandomInterArrival);
                }
                else
                {
                    CurrentCase.RandomInterArrival = 1;
                    CurrentCase.InterArrival = 0;
                }
                CurrentCase.ArrivalTime = LastCustomer + CurrentCase.InterArrival;
                LastCustomer = CurrentCase.ArrivalTime;
                CurrentCase.RandomService = Generator.Next(1, 100);
                SimulationTable.Add(CurrentCase);
            }
            Serve();
        }

        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; } //done
        public int StoppingNumber { get; set; } //done
        public List<Server> Servers { get; set; } //done
        public List<TimeDistribution> InterarrivalDistribution { get; set; } //done
        public Enums.StoppingCriteria StoppingCriteria { get; set; } //done
        public Enums.SelectionMethod SelectionMethod { get; set; } //done

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
    }
}
