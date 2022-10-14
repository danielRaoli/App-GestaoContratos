using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Curso4.Entities.Enums;

namespace Curso4.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; private set; }
        public Department Department { get; set; }

        public List<HourContract> contracts { get; private set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double salary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = salary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            if (contracts.Contains(contract))
            {
                contracts.Remove(contract);
            }
        }

        public double Income(int month, int year)
        {
            double sum = BaseSalary;
            if (contracts != null)
            {
                foreach (HourContract contract in contracts)
                {
                    if (contract.Date.Year == year && contract.Date.Month == month)
                    {
                        sum += contract.TotalValue();
                    }
                }    
            }
            return sum;
        }


    }
}
