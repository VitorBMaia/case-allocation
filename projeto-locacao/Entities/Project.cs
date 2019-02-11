using System;
using System.Collections.Generic;

namespace projeto_locacao.Entities
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; set; }
        public Client Client { get; set; }
        public List<Allocation> Allocations { get; set; }
        
        public Project()
        {
            this.Allocations = new List<Allocation>();
        }

        public decimal TotalCost()
        {
            decimal total = 0;

            foreach(Allocation a in Allocations)
            {
                total += a.AllocationTotalCost();
            }

            return total;
        }


    }
}