using System;
using System.Collections.Generic;
using projeto_locacao.Entities;
namespace projeto_locacao.Entities
{
    public class Allocation
    {
        public Project Project { get; set; }
        public Employee Employee { get; set; }
        public bool IsLeader { get; set; }
        public DateTime StartDate { get; set; }    
        public DateTime EndDate { get; set; }
        public double DailyWorkLoad { get; set; }

        public Allocation(Project project, Employee employee)
        {
            this.Employee = employee;
            this.Project = project;
            this.Project.Allocations.Add(this);
        }

        public int TotalDays()
        {
            var contador = 0;

            for (DateTime i = StartDate.Date; i <= EndDate.Date; i = i.AddDays(1))
            {
                if(i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
                contador++;
            }

            return contador;
        }

        public decimal AllocationTotalCost()
        {
        return TotalDays() * (decimal) this.DailyWorkLoad * this.Employee.WorkHourlyCost;
        }
    }

}