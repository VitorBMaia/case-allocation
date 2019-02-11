using System;
using projeto_locacao.Entities;
using Xunit;

namespace projeto_locacao.Test
{
    public class AllocationTest
    {
        [Fact(DisplayName = "Must return allocation's number of days")]
        public void MustReturnAllocationsNumberOfDays()
        {
            var project = new Project();
            var employee = new Employee();
            var allocation = new Allocation(project, employee);
            allocation.StartDate = new DateTime(2019, 2, 11);
            allocation.EndDate = new DateTime(2019, 2, 18);

            var expectedValue = 6;
            var actualValue = allocation.TotalDays();

            Assert.Equal(expectedValue, actualValue);
        }

        [Fact(DisplayName = "Must return allocation's total cost")]
        public void MustReturnAllocationsTotalCost()
        {
            var employee = new Employee();
            var project = new Project();
            var allocation = new Allocation(project, employee);
            employee.WorkHourlyCost = 16;
            allocation.DailyWorkLoad = 8;
            allocation.StartDate = new DateTime(2019, 2, 11);
            allocation.EndDate = new DateTime(2019, 2, 18);

            var expectedValue = 768; // allocation.TotalDays() * employee.WorkHourlyCost * (decimal) allocation.DailyWorkLoad;
            var actualValue = allocation.AllocationTotalCost();

            Assert.Equal(expectedValue, actualValue);
        }
    }
}
