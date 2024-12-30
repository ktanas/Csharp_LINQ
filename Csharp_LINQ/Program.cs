using Csharp_LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();
            //List<Department> departmentList = Data.GetDepartments();
            List<Department> departmentList = Data.GetDepartments(employeeList);

            /*
            var results = employeelist.select(emp => new
            {
                fullname = emp.firstname + " " + emp.lastname,
                monthlysalary = emp.annualsalary / 12.0m
            }).where(emp => emp.monthlysalary > 5000.0m);

            foreach (var record in results)
            {
                console.writeline(record.fullname + " " + record.monthlysalary);
            }
            */

            /*
            var results = from emp in employeelist
                          where emp.annualsalary > 50000.0m
                          select new
                          {
                              fullname = emp.firstname + " " + emp.lastname,
                              annualsalary = emp.annualsalary
                          };

            employeelist.add(new employee
            {
                id = 5,
                firstname = "peter",
                lastname = "simpson",
                annualsalary = 95000.4m,
                ismanager = true,
                departmentid = 2
            });

            foreach (var record in results)
            {
                console.writeline(record.fullname + " " + record.annualsalary);
            }
            employeelist.add(new employee
            {
                id = 5,
                firstname = "peter",
                lastname = "simpson",
                annualsalary = 95000.4m,
                ismanager = true,
                departmentid = 2
            });
            */

            /*
            var results = from emp in employeelist.gethighsalariedemployees()
                          select new
                          {
                              fullname = emp.firstname + " " + emp.lastname,
                              annualsalary = emp.annualsalary
                          };
            foreach (var record in results)
            {
                console.writeline(record.fullname + " " + record.annualsalary);
            }

            employeelist.add(new employee
            {
                id = 5,
                firstname = "peter",
                lastname = "simpson",
                annualsalary = 95000.4m,
                ismanager = true,
                departmentid = 2
            });
            */

            /*
            var results = (from emp in employeelist.gethighsalariedemployees()
                           select new
                           {
                               fullname = emp.firstname + " " + emp.lastname,
                               annualsalary = emp.annualsalary
                           }).tolist();

            foreach (var record in results)
            {
                console.writeline(record.fullname + " " + record.annualsalary);
            }
            */
            /*
            var results = departmentlist.join(employeelist,
                    department => department.id,
                    employee => employee.departmentid,
                    (department, employee) => new
                    {
                        fullname = employee.firstname + " " + employee.lastname,
                        annualsalary = employee.annualsalary,
                        departmentname = department.longname
                    }
                );

            foreach (var record in results)
            {
                console.writeline(record.fullname + " " + record.annualsalary + " " + record.departmentname);
            }
            */
            /*
            var results = from dep in departmentlist
                          join emp in employeelist
                          on dep.id equals emp.departmentid
                          select new
                          {
                              fullname = emp.firstname + " " + emp.lastname,
                              annualsalary = emp.annualsalary,
                              departmentname = dep.longname
                          };

            foreach (var record in results)
            {
                console.writeline(record.fullname + " " + record.annualsalary + " " + record.departmentname);
            }
            */

            /*
            var results = departmentlist.groupjoin(employeelist,
                    dep => dep.id,
                    emp => emp.departmentid,
                    (dep, employeesgroup) => new
                    {
                        employees = employeesgroup,
                        departmentname = dep.longname
                    }
                );

            foreach (var dep in results)
            {
                console.writeline("department name:" + dep.departmentname);
                foreach (var emp in dep.employees)
                {
                    console.writeline(emp.firstname + " " + emp.lastname);
                }
            }
            */
            /*
            var results = from dep in departmentList
                          join emp in employeeList
                          on dep.Id equals emp.DepartmentId
                          into employeeGroup
                          select new
                          {
                              Employees = employeeGroup,
                              DepartmentName = dep.LongName
                          };

            foreach (var dep in results)
            {
                Console.WriteLine("Department name:" + dep.DepartmentName);
                foreach (var emp in dep.Employees)
                {
                    Console.WriteLine(emp.FirstName + " " + emp.LastName);
                }
            }

            Console.ReadLine();
            */

            /*
            var results = employeeList.Join(departmentList, emp => emp.DepartmentId, dep => dep.Id,
                (emp, dep) => new
                {
                    Id = emp.Id,
                    FirstName = emp.FirstName,
                    LastName = emp.LastName,
                    AnnualSalary = emp.AnnualSalary,
                    DepartmentId = emp.DepartmentId,
                    DepartmentName = dep.LongName
                }).OrderByDescending(order => order.DepartmentId);
            */

            /*
            var results = employeeList.Join(departmentList, emp => emp.DepartmentId, dep => dep.Id,
               (emp, dep) => new
               {
                   Id = emp.Id,
                   FirstName = emp.FirstName,
                   LastName = emp.LastName,
                   AnnualSalary = emp.AnnualSalary,
                   DepartmentId = emp.DepartmentId,
                   DepartmentName = dep.LongName
               }).OrderBy(order => order.DepartmentId).ThenByDescending(order => order.AnnualSalary);
            */
            /*
            var results = from emp in employeeList
                          join dep in departmentList
                          on emp.DepartmentId equals dep.Id
                          orderby emp.DepartmentId, emp.AnnualSalary
                          select new
                          {
                              Id = emp.Id,
                              FirstName = emp.FirstName,
                              LastName = emp.LastName,
                              AnnualSalary = emp.AnnualSalary,
                              DepartmentId = emp.DepartmentId,
                              DepartmentName = dep.LongName
                          };

            foreach (var record in results)
                Console.WriteLine("Id:" + record.Id
                                 + ",First name:" + record.FirstName
                                 + ",Last name:" + record.LastName
                                 + ",Annual salary:" + record.AnnualSalary
                                 + ",Department name:" + record.DepartmentName);
            */
            /*
            var groupResult = from emp in employeeList
                              orderby emp.DepartmentId
                              group emp by emp.DepartmentId;

            foreach (var empGroup in groupResult)
            {
                Console.WriteLine("Department Id:" + empGroup.Key);

                foreach (Employee emp in empGroup)
                {
                    Console.WriteLine("Employee's full name:" + emp.FirstName + " " + emp.LastName);
                }

            }
            */
            /*
            var groupResult = employeeList.OrderBy(ord => ord.DepartmentId).ToLookup(emp => emp.DepartmentId);

            foreach (var empGroup in groupResult)
            {
                Console.WriteLine("Department Id:" + empGroup.Key);

                foreach (Employee emp in empGroup)
                {
                    Console.WriteLine("Employee's full name:" + emp.FirstName + " " + emp.LastName);
                }

            }

            var annualSalaryCompare = 30000;

            bool isTrueAll = employeeList.All(emp => emp.AnnualSalary > annualSalaryCompare);

            if (isTrueAll)
            {
                Console.WriteLine("All employees earn more than " + annualSalaryCompare);
            }
            else
            {
                Console.WriteLine("There is at least one emploee who does not earn above " + annualSalaryCompare);
            }

            bool isTrueAny = employeeList.Any(emp => emp.AnnualSalary > annualSalaryCompare);

            if (isTrueAny)
            {
                Console.WriteLine("There exists an employee who earns more than " + annualSalaryCompare);
            }
            else
            {
                Console.WriteLine("There is no employee who earns more than " + annualSalaryCompare);
            }

            var searchEmployee = new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Roberts",
                AnnualSalary = 40000.2m,
                IsManager = false,
                DepartmentId = 2
            };

            bool containsEmployee = employeeList.Contains(searchEmployee, new EmployeeComparer());

            if (containsEmployee) Console.WriteLine("Employee with the specified data exists");
            else Console.WriteLine("Employee with the specified data does not exist");

            ArrayList mixedCollection = Data.GetHeterogeneousDataCollection();

            var stringResult = from s in mixedCollection.OfType<string>()
                               select s;

            foreach (var str in stringResult)
                Console.WriteLine(str);

            var floatResult = from f in mixedCollection.OfType<float>()
                              select f;

            foreach (var f in floatResult)
                Console.WriteLine(f);

            var employeeResult = from e in mixedCollection.OfType<Employee>()
                                 select e;

            foreach (var e in employeeResult)
                Console.WriteLine(e.Id + " " + e.FirstName + " " + e.LastName + " " + e.IsManager + " " + e.DepartmentId);

            var e = employeeList.ElementAt(0);
            Console.WriteLine(e.Id + " " + e.FirstName + " " + e.LastName + " " + e.IsManager + " " + e.DepartmentId);

            var e2 = employeeList.ElementAtOrDefault(9);

            if (e2 == null)
                Console.WriteLine("No employee at specified index exists in the employee list");
            else
                Console.WriteLine(e2.Id + " " + e2.FirstName + " " + e2.LastName + " " + e2.IsManager + " " + e2.DepartmentId);

            List<int> integerList = new List<int> { 15, 13, 9, 31, 7, 5, -16 };

            int result = integerList.First(number => number % 2 == 0);
            int result = integerList.FirstOrDefault(number => number % 2 == 0);
            int result = integerList.Last(number => number % 2 == 0);
            int result = integerList.LastOrDefault(number => number % 2 == 0);

            Console.WriteLine(result);

            var e = employeeList.Single();
            var e = employeeList.SingleOrDefault();
            var e = employeeList.Single(e => e.FirstName == "Sarah");
            */

            /*
            var e = employeeList.SingleOrDefault(e => e.IsManager == true);

            if (e == null)
                Console.WriteLine("The employee list contains either zero or more than one matching element");
            else
                Console.WriteLine(e.Id + " " + e.FirstName + " " + e.LastName + " " + e.IsManager + " " + e.DepartmentId);

            Console.ReadLine();
            */

            /*
            var integerList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var integerList2 = new List<int> { 1, 2, 3, 4, 6, 5 };

            var boolSequenceEqual = integerList1.SequenceEqual(integerList2);

            Console.WriteLine(boolSequenceEqual);
            */

            /*
            var employeeListCompare = Data.GetEmployees();
            //var boolSequenceEqual = employeeList.SequenceEqual(employeeListCompare);
            var boolSequenceEqual = employeeList.SequenceEqual(employeeListCompare, new EmployeeComparer());

            Console.WriteLine(boolSequenceEqual);

            var integerList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            var integerList2 = new List<int> { 7, 8, 9, 10 };

            IEnumerable<int> integerListConcat = integerList1.Concat(integerList2);

            foreach (var i in integerListConcat)
                Console.WriteLine(i);

            List<Employee> employeeList2 = new List<Employee> { new Employee {
                                                                Id = 5,
                                                                FirstName = "John",
                                                                LastName = "Williams",
                                                                AnnualSalary = 133000.1m,
                                                                IsManager = true,
                                                                DepartmentId = 3
                                                              }, new Employee {
                                                                Id = 6,
                                                                FirstName = "Adam",
                                                                LastName = "Paulson",
                                                                AnnualSalary = 79990.9m,
                                                                IsManager = true,
                                                                DepartmentId = 2
                                                              } };

            IEnumerable<Employee> results = employeeList.Concat(employeeList2);

            foreach (var record in results)
                Console.WriteLine(record.Id
                          + " " + record.FirstName
                          + " " + record.LastName
                          + " " + record.AnnualSalary
                          + " " + record.IsManager
                          + " " + record.DepartmentId);

            decimal totalAnnualSalary = employeeList.Aggregate<Employee, decimal>(0, (totalAnnualSalary, empl) =>
            {
                var bonus = (empl.IsManager == true) ? 0.04m : 0.02m;

                totalAnnualSalary = (empl.AnnualSalary + (empl.AnnualSalary * bonus)) + totalAnnualSalary;

                return totalAnnualSalary;
            });

            Console.WriteLine("Total annual salary of all employees, including bonus:" + totalAnnualSalary);

            string data = employeeList.Aggregate<Employee, string, string>("Employee Annual Salaries (including bonus):",
                (str, emp) =>
                {
                    var bonus = (emp.IsManager == true) ? 0.04m : 0.02m;

                    str += $"{emp.FirstName}{emp.LastName} - {emp.AnnualSalary + (emp.AnnualSalary * bonus)}, ";
                    return str;
                }, str => str.Substring(0, str.Length - 2)
                );

            Console.WriteLine(data);

            decimal averageSalary = employeeList.Average(e => e.AnnualSalary);
            decimal averageSalaryOfTechnologyDepartment = employeeList.Where(e => e.DepartmentId == 3).Average(e => e.AnnualSalary);

            Console.WriteLine("Average annual salary of all employees:" + averageSalary);
            Console.WriteLine("Average annual salary in the technology department:" + averageSalaryOfTechnologyDepartment);

            int employeeCount = employeeList.Count();
            int employeeCountInTechnologyDepartment = employeeList.Count(emp => emp.DepartmentId == 3);

            Console.WriteLine("Number of employees:" + employeeCount);
            Console.WriteLine("Number of employees in technology department: " + employeeCountInTechnologyDepartment);

            decimal totalSalary = employeeList.Sum(emp => emp.AnnualSalary);
            Console.WriteLine("Total annual salary of all employees:" + totalSalary);

            var highestSalary = employeeList.Max(e => e.AnnualSalary);
            var lowestSalary = employeeList.Min(e => e.AnnualSalary);
            Console.WriteLine("Highest salary in our company:" + highestSalary);
            Console.WriteLine("Lowest salary in our company:" + lowestSalary);
            */

            /*
            List<int> intList = new List<int>();
            var newList = intList.DefaultIfEmpty(675765);

            Console.WriteLine(newList.ElementAt(0));
            */

            /*
            List<Employee> employees = new List<Employee>();
            var newList = employees.DefaultIfEmpty(new Employee { Id = 0 });

            var result = newList.ElementAt(0);

            if (result.Id == 0) Console.WriteLine("The list is empty");
            else Console.WriteLine("The list is not empty");

            //IEnumerable<Employee> emptyEmployeeList = Enumerable.Empty<Employee>();
            List<Employee> emptyEmployeeList = Enumerable.Empty<Employee>().ToList();

            emptyEmployeeList.Add(new Employee
            {
                Id = 7,
                FirstName = "Joanne",
                LastName = "Atkins",
                AnnualSalary = 40000.5m,
                IsManager = false,
                DepartmentId = 1
            });

            foreach (var item in emptyEmployeeList)
                Console.WriteLine(item.FirstName + " " + item.LastName);

            var intCollection = Enumerable.Range(25, 20);

            foreach (var i in intCollection)
                Console.WriteLine(i);

            var strCollection = Enumerable.Repeat<string>("Abrakadabra", 5);
            foreach (var i in strCollection)
                Console.WriteLine(i);

            List<int> list = new List<int> { 1, 2, 1, 4, 6, 2, 6 };
            var results = list.Distinct();
            foreach (var i in results)
                Console.WriteLine(i);

            IEnumerable<int> collection1 = new List<int> { 1, 2, 3, 4 };
            IEnumerable<int> collection2 = new List<int> { 3, 4, 5, 6 };

            var resultList = collection1.Except(collection2);

            foreach (var i in resultList)
                Console.WriteLine(i);
            */


            List<Employee> employeeList2 = new List<Employee>();

            employeeList2.Add(new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                AnnualSalary = 60000.3m,
                IsManager = true,
                DepartmentId = 2
            }
            );

            employeeList2.Add(new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Roberts",
                AnnualSalary = 40000.2m,
                IsManager = false,
                DepartmentId = 1
            }
            );

            employeeList2.Add(new Employee
            {
                Id = 5,
                FirstName = "Peter",
                LastName = "Smith",
                AnnualSalary = 61500.0m,
                IsManager = false,
                DepartmentId = 2
            }
            );

            employeeList2.Add(new Employee
            {
                Id = 6,
                FirstName = "Anne",
                LastName = "Jackson",
                AnnualSalary = 200000.0m,
                IsManager = true,
                DepartmentId = 2
            }
            );

            employeeList2.Add(new Employee
            {
                Id = 7,
                FirstName = "Anne",
                LastName = "Smith",
                AnnualSalary = 49000.7m,
                IsManager = false,
                DepartmentId = 3
            }
            );


            //var resultList = employeeList.Except(employeeList2); // WRONG!
            /*
            var resultList = employeeList.Except(employeeList2, new EmployeeComparer());

            foreach (var emp in resultList)
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            */
            /*
            var resultList = employeeList.Intersect(employeeList2, new EmployeeComparer());

            foreach (var emp in resultList)
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            */
            /*
            var resultList = employeeList.Union(employeeList2, new EmployeeComparer());
            var resultList = employeeList.Union(employeeList2); // will show duplicate employee records

            foreach (var emp in resultList)
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            */
            /*
            var resultList = employeeList.Skip(2);
            var resultList = employeeList.SkipWhile(emp => emp.AnnualSalary > 70000.0m);
            var resultList = employeeList.Take(2);
            var resultList = employeeList.TakeWhile(emp => emp.DepartmentId != 3);

            foreach (var emp in resultList)
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            */
            /*
            List<Employee> resultList = (from emp in employeeList
                                         where emp.AnnualSalary > 50000.0m
                                         select emp).ToList();

            foreach (var emp in resultList)
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            */

            /*
            Dictionary<int, Employee> dict = (from emp in employeeList
                                              where emp.AnnualSalary > 50000.0m
                                              select emp).ToDictionary<Employee, int>(emp => emp.Id);

            foreach (var key in dict.Keys)
                Console.WriteLine("Key:" + key + ",value:" + dict[key].FirstName + " " + dict[key].LastName);

            Employee[] resultArray = (from emp in employeeList
                                      where emp.AnnualSalary > 50000.0m
                                      select emp).ToArray();

            foreach (var emp in resultArray)
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);

            var results = from emp in employeeList
                          let Initials = emp.FirstName.Substring(0, 1).ToUpper() + emp.LastName.Substring(0, 1).ToUpper()
                          let AnnualSalaryWithBonus = (emp.IsManager) ? emp.AnnualSalary * 1.04m : emp.AnnualSalary * 1.02m
                          where Initials == "JS" || Initials == "SJ" && AnnualSalaryWithBonus > 50000.0m
                          select new
                          {
                              Initials = Initials,
                              FullName = emp.FirstName + " " + emp.LastName,
                              AnnualSalaryWithBonus = AnnualSalaryWithBonus
                          };

            foreach (var record in results)
                Console.WriteLine(record.Initials + " " + record.FullName + " " + record.AnnualSalaryWithBonus);
            */

            /*
            var results = from emp in employeeList
                          where emp.AnnualSalary > 50000.0m
                          select emp
                          into HighEarners
                          where HighEarners.IsManager == true
                          select HighEarners;

            foreach (var emp in results)
                Console.WriteLine(emp.Id + " " + emp.FirstName + " " + emp.LastName);
            */
            /*
            var results = departmentList.Select(dep => dep.Employees);

            foreach (var departments in results)
                foreach (var employee in departments)
                    Console.WriteLine(employee.Id + " " + employee.FirstName + " " + employee.LastName);
            */

            var results = departmentList.SelectMany(dep => dep.Employees).OrderBy(ord => ord.Id);

            foreach (var record in results)
                Console.WriteLine(record.Id + " " + record.FirstName + " " + record.LastName);


            Console.ReadLine();

        }
    }


}

