using System;
using ExercicioEnumsDateTimeETC.Entities.Enums;


namespace ExercicioEnumsDateTimeETC.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double salary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = salary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            
            
        }

    }
}