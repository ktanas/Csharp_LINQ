using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_LINQ
{
    public static class EnumerableCollectionExtensionMethods
    {
        public static IEnumerable<Employee> GetHighSalariedEmployees(this IEnumerable<Employee> employees)
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine("Accessing employee:" + emp.FirstName + " " + emp.LastName);
                if (emp.AnnualSalary > 50000.0m)
                    yield return emp;
            }
        }
    }

}
