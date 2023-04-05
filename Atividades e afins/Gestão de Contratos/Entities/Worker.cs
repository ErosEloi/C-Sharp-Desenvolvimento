using GestaoDeContratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeContratos.Entities
{
    internal class Worker
    {

        public String Name { get; private set; }
        public WorkerLevel Level { get; private set; }
        public double BaseSalaray { get; private set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Department Department { get;  set; }



        public Worker(string name, WorkerLevel level, double baseSalaray, Department department)
        {
            Name = name;
            Level = level;
            BaseSalaray = baseSalaray;
            Department = department;
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalaray;

            foreach(HourContract contracts in Contracts)
            {
                if (contracts.Date.Year == year && contracts.Date.Month == month)
                {
                    sum += contracts.totalValue();
                }
            }

            return sum;
        }


    }
}
