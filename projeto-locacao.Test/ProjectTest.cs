using System;
using projeto_locacao.Entities;
using Xunit;

namespace projeto_locacao.Test
{
    public class ProjectTest
    {
        [Fact(DisplayName = "Must return project's total cost")]
        public void MustReturnProjectsTotalCost()
        {
            var project = new Project();
            var employee1 = new Employee();
            employee1.WorkHourlyCost = 17;
            var allocation1 = new Allocation(project, employee1);
            allocation1.DailyWorkLoad = 8;
            allocation1.StartDate = new DateTime(2019, 02, 11);
            allocation1.EndDate = new DateTime(2019, 02, 18);
            var employee2 = new Employee();
            employee2.WorkHourlyCost = 17;
            var allocation2 = new Allocation(project, employee2);
            allocation2.DailyWorkLoad = 8;
            allocation2.StartDate = new DateTime(2019, 02, 11);
            allocation2.EndDate = new DateTime(2019, 02, 18);
            

            var expectedValue = 1632;
            var actualValue = project.TotalCost();

            Assert.Equal(expectedValue, actualValue);
            
        }
    
    }
}