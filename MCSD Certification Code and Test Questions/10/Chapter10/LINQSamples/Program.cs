using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml;
using System.Xml.Linq;

namespace LINQSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        #region Query Expressions

        static void RetrieveEvenNumberV1()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evenNumbers = new int[5];
            int evenIndex = 0;

            foreach (int i in myArray)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[evenIndex] = i;
                    evenIndex++;
                }
            }

            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }
        }

        static void RetrieveEvenNumberV2()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from i in myArray
                            where i % 2 == 0
                            select i;

            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }

            myArray[1] = 12;

            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }
        }

        static void AggregateFunctions()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int count = (from i in myArray
            //                    where i % 2 == 0
            //                    select i).Count();

            var evenNumbers = from i in myArray
                                where i % 2 == 0
                            select i;

            int count = evenNumbers.Count();

            double average = (from i in myArray
                                where i % 2 == 0
                            select i).Average();

            int sum = (from i in myArray
                        where i % 2 == 0
                        select i).Sum();

            int first = (from i in myArray
                        where i % 2 == 0
                        select i).First();

            int last = (from i in myArray
                        where i % 2 == 0
                        select i).Last();

            int min = (from i in myArray
                        where i % 2 == 0
                        select i).Min();

            int max = (from i in myArray
                        where i % 2 == 0
                        select i).Max();

        }

        static void RetrieveEvenNumberGT5V1()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from i in myArray
                                where i % 2 == 0 && i > 5
                                select i;

            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }
        }

        static void RetrieveEvenNumberGT5V2()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from i in myArray
                                where i % 2 == 0 
                                where i > 5
                                select i;

            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }
        }

        static void RetrieveEvenNumberGT5V3()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from i in myArray
                                where IsEvenAndGT5(i)
                                select i;

            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }
        }

        static bool IsEvenAndGT5(int i)
        {
            return (i % 2 == 0 && i > 5);                        
        }

        static void OrderEvenNumbers()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = from i in myArray
                                where i % 2 == 0                              
                                orderby i descending
                                select i;

            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }
        }

        static void OrderByStateThenCity()
        {
            List<Hometown> hometowns = new List<Hometown>() 
            {
                new Hometown() { City = "Philadelphia", State = "PA" },
                new Hometown() { City = "Ewing", State = "NJ" },
                new Hometown() { City = "Havertown", State = "PA" },
                new Hometown() { City = "Fort Washington", State = "PA" },                
                new Hometown() { City = "Trenton", State = "NJ" }
            };

            var orderedHometowns = from h in hometowns
                            orderby h.State ascending, h.City ascending
                            select h;

            foreach (Hometown hometown in orderedHometowns)
            {
                Debug.WriteLine(hometown.City + ", " + hometown.State);
            }

        }

        static void ProjectionV1()
        {
            List<Person> people = new List<Person>()
            {
                new Person() { FirstName = "John", LastName = "Smith", Address1 = "First St", City = "Havertown", State = "PA", Zip = "19084" },
                new Person() { FirstName = "Jane", LastName = "Doe", Address1 = "Second St", City = "Ewing", State = "NJ", Zip = "08560" },
                new Person() { FirstName = "Jack", LastName = "Jones", Address1 = "Third St", City = "Ft Washington", State = "PA", Zip = "19034" }
            };

            var lastNames = from p in people
                            select p.LastName;

            foreach (string lastName in lastNames)
            {
                Debug.WriteLine(lastName);
            }
        }

        static void ProjectionV2()
        {
            List<Person> people = new List<Person>()
            {
                new Person() { FirstName = "John", LastName = "Smith", Address1 = "First St", City = "Havertown", State = "PA", Zip = "19084" },
                new Person() { FirstName = "Jane", LastName = "Doe", Address1 = "Second St", City = "Ewing", State = "NJ", Zip = "08560" },
                new Person() { FirstName = "Jack", LastName = "Jones", Address1 = "Third St", City = "Ft Washington", State = "PA", Zip = "19034" }
            };

            var names = from p in people
                        select new { p.FirstName, p.LastName };

            foreach (var name in names)
            {
                Debug.WriteLine(name.FirstName + ", " + name.LastName);
            }
        }

        static void ProjectionV3()
        {
            List<Person> people = new List<Person>()
            {
                new Person() { FirstName = "John", LastName = "Smith", Address1 = "First St", City = "Havertown", State = "PA", Zip = "19084" },
                new Person() { FirstName = "Jane", LastName = "Doe", Address1 = "Second St", City = "Ewing", State = "NJ", Zip = "08560" },
                new Person() { FirstName = "Jack", LastName = "Jones", Address1 = "Third St", City = "Ft Washington", State = "PA", Zip = "19034" }
            };

            var names = from p in people
                        select new { First = p.FirstName, Last = p.LastName };

            foreach (var name in names)
            {
                Debug.WriteLine(name.First + ", " + name.Last);
            }
        }

        static void Join()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    StateId = 1 
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    StateId = 2 
                },
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    StateId = 1 
                }
            };

            List<State> states = new List<State>()
            {
                new State()
                {
                    StateId = 1,
                    StateName = "PA"
                },
                new State()
                {
                    StateId = 2,
                    StateName = "NJ"
                }
            };

            var employeeByState = from e in employees
                                    join s in states
                                    on e.StateId equals s.StateId
                                select new { e.LastName, s.StateName };

            foreach (var employee in employeeByState)
            {
                Debug.WriteLine(employee.LastName + ", " + employee.StateName);
            }
        }

        static void OuterJoin()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    StateId = 1 
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    StateId = 2 
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones", 
                    StateId = 1 
                },
                new Employee() 
                { 
                    FirstName = "Sue", 
                    LastName = "Smith", 
                    StateId = 3 
                }
            };

            List<State> states = new List<State>()
            {
                new State()
                {
                    StateId = 1,
                    StateName = "PA"
                },
                new State()
                {
                    StateId = 2,
                    StateName = "NJ"
                }
            };

            var employeeByState = from e in employees
                                  join s in states
                                    on e.StateId equals s.StateId into employeeGroup
                                  from item in employeeGroup.DefaultIfEmpty(new State { StateId = 0, StateName = "" })
                                select new { e.LastName, item.StateName };

            foreach (var employee in employeeByState)
            {
                Debug.WriteLine(employee.LastName + ", " + employee.StateName);
            }
        }

        static void CompositeKey()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    City = "Havertown",
                    State = "PA"
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    City = "Ewing",
                    State = "NJ"
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones", 
                    City = "Fort Washington",
                    State = "PA"
                }
            };

            List<Hometown> hometowns = new List<Hometown>()
            {
                new Hometown()
                {
                    City = "Havertown",
                    State = "PA",
                    CityCode = "1234"
                },
                new Hometown()
                {
                    City = "Ewing",
                    State = "NJ",
                    CityCode = "5678"
                },
                new Hometown()
                {
                    City = "Fort Washington",
                    State = "PA",
                    CityCode = "9012"
                }
            };

            var employeeByState = from e in employees
                                    join h in hometowns
                                    on new { City = e.City, State = e.State } equals new { City = h.City, State = h.State }                                   
                                    select new { e.LastName, h.CityCode };

            foreach (var employee in employeeByState)
            {
                Debug.WriteLine(employee.LastName + ", " + employee.CityCode);
            }
        }

        static void GroupV1()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    City = "Havertown",
                    State = "PA"
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    City = "Ewing",
                    State = "NJ"
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones", 
                    City = "Fort Washington",
                    State = "PA"
                }
            };

            var employeesByState = from e in employees
                                    group e by e.State;

            foreach (var employeeGroup in employeesByState) 
            {
                Debug.WriteLine(employeeGroup.Key + ": " + employeeGroup.Count());

                foreach (var employee in employeeGroup)
                {
                    Debug.WriteLine(employee.LastName + ", " + employee.State);
                }
            }
        }

        static void GroupV2()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var groupedNumbers = from i in myArray
                                    group i by (i % 2 == 0 ? "Even" : "Odd");

            foreach (var groupNumber in groupedNumbers)
            {
                Debug.WriteLine(groupNumber.Key + ": " + groupNumber.Sum());
                foreach(var number in groupNumber)
                {
                    Debug.WriteLine(number);
                }
            }
        }

        static void GroupV3()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            var groupedNumbers = from i in myArray
                                    group i by (i % 2 == 0 ? "Even" : "Odd") into g
                                    select new { Key = g.Key, SumOfNumbers = g.Sum() };

            foreach (var groupNumber in groupedNumbers)
            {
                Debug.WriteLine(groupNumber.Key + ": " + groupNumber.SumOfNumbers);                
            }
        }

        #endregion Query Expressions

        #region Method Based Queries

        static void MethodBasedSelect()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = myArray.Where(i => i % 2 == 0);
                              
            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }
        }

        static void MethodBasedAggregateFunctions()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int count = myArray.Where(i => i % 2 == 0).Count();

            double average = myArray.Where(i => i % 2 == 0).Average();

            int sum = myArray.Where(i => i % 2 == 0).Sum();

            int first = myArray.Where(i => i % 2 == 0).First();

            int last = myArray.Where(i => i % 2 == 0).Last();

            int min = myArray.Where(i => i % 2 == 0).Min();

            int max = myArray.Where(i => i % 2 == 0).Max();
        }

        static void MethodBasedRetrieveEvenNumberGT5V1()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = myArray.Where(i => i % 2 == 0 && i > 5);
                              
            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }
        }

        static void MethodBasedRetrieveEvenNumberGT5V2()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = myArray.Where(i => i % 2 == 0).Where(i => i > 5);
                              
            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }
        }

        static void MethodBasedRetrieveEvenNumberGT5V3()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = myArray.Where(i => IsEvenAndGT5(i));
                              
            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }
        }

        static void MethodBasedOrderEvenNumbers()
        {
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = myArray.Where(i => i % 2 == 0).OrderByDescending(i => i);
                              
            foreach (int i in evenNumbers)
            {
                Debug.WriteLine(i);
            }
        }

        static void MethodBasedOrderByStateThenCity()
        {
            List<Hometown> hometowns = new List<Hometown>() 
            {
                new Hometown() { City = "Philadelphia", State = "PA" },
                new Hometown() { City = "Ewing", State = "NJ" },
                new Hometown() { City = "Havertown", State = "PA" },
                new Hometown() { City = "Fort Washington", State = "PA" },                
                new Hometown() { City = "Trenton", State = "NJ" }
            };

            var orderedHometowns = hometowns.OrderBy(h => h.State).ThenBy(h => h.City);
                                   
            foreach (Hometown hometown in orderedHometowns)
            {
                Debug.WriteLine(hometown.City + ", " + hometown.State);
            }

}

        static void MethodBasedProjectionV1()
        {
            List<Person> people = new List<Person>()
            {
                new Person() { FirstName = "John", LastName = "Smith", Address1 = "First St", City = "Havertown", State = "PA", Zip = "19084" },
                new Person() { FirstName = "Jane", LastName = "Doe", Address1 = "Second St", City = "Ewing", State = "NJ", Zip = "08560" },
                new Person() { FirstName = "Jack", LastName = "Jones", Address1 = "Third St", City = "Ft Washington", State = "PA", Zip = "19034" }
            };

            var lastNames = people.Select(p => p.LastName);
                            
            foreach (string lastName in lastNames)
            {
                Debug.WriteLine(lastName);
            }
        }

        static void MethodBasedProjectionV2()
        {
            List<Person> people = new List<Person>()
            {
                new Person() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    Address1 = "First St", 
                    City = "Havertown", 
                    State = "PA", 
                    Zip = "19084" 
                },
                new Person() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    Address1 = "Second St", 
                    City = "Ewing", 
                    State = "NJ", 
                    Zip = "08560" 
                },
                new Person() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones", 
                    Address1 = "Third St", 
                    City = "Ft Washington", 
                    State = "PA", 
                    Zip = "19034" 
                }
            };

            var names = people.Select(p => new { p.FirstName, p.LastName });

            foreach (var name in names)
            {
                Debug.WriteLine(name.FirstName + ", " + name.LastName);
            }
        }

        static void MethodBasedProjectionV3()
        {
            List<Person> people = new List<Person>()
            {
                new Person() { FirstName = "John", LastName = "Smith", Address1 = "First St", City = "Havertown", State = "PA", Zip = "19084" },
                new Person() { FirstName = "Jane", LastName = "Doe", Address1 = "Second St", City = "Ewing", State = "NJ", Zip = "08560" },
                new Person() { FirstName = "Jack", LastName = "Jones", Address1 = "Third St", City = "Ft Washington", State = "PA", Zip = "19034" }
            };

            var names = people.Select(p => new { First = p.FirstName, Last = p.LastName });

            foreach (var name in names)
            {
                Debug.WriteLine(name.First + ", " + name.Last);
            }
        }

        static void MethodBasedProjectionV4()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    StateId = 1 
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    StateId = 2 
                },
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    StateId = 1 
                }
            };

            List<State> states = new List<State>()
            {
                new State()
                {
                    StateId = 1,
                    StateName = "PA"
                },
                new State()
                {
                    StateId = 2,
                    StateName = "NJ"
                }
            };

            var employeeByState = employees.SelectMany(e => states.Where(s => e.StateId == s.StateId).Select(s => new { e.LastName, s.StateName }));

            foreach (var employee in employeeByState)
            {
                Debug.WriteLine(employee.LastName + ", " + employee.StateName);
            }
        }

        static void MethodBasedJoin()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    StateId = 1 
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    StateId = 2 
                },
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    StateId = 1 
                }
            };

            List<State> states = new List<State>()
            {
                new State()
                {
                    StateId = 1,
                    StateName = "PA"
                },
                new State()
                {
                    StateId = 2,
                    StateName = "NJ"
                }
            };

            var employeeByState = employees.Join(states, 
                                                 e => e.StateId, 
                                                 s => s.StateId, 
                                                 (e, s) => new { e.LastName, s.StateName });

            foreach (var employee in employeeByState)
            {
                Debug.WriteLine(employee.LastName + ", " + employee.StateName);
            }
        }

        static void MethodBasedOuterJoin()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    StateId = 1 
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    StateId = 2 
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones", 
                    StateId = 1 
                },
                new Employee() 
                { 
                    FirstName = "Sue", 
                    LastName = "Smith", 
                    StateId = 3 
                }
            };

            List<State> states = new List<State>()
            {
                new State()
                {
                    StateId = 1,
                    StateName = "PA"
                },
                new State()
                {
                    StateId = 2,
                    StateName = "NJ"
                }
            };

            var employeeByState = employees.GroupJoin(states,
                                                        e => e.StateId,
                                                        s => s.StateId,
                                                        (e, employeeGroup) => employeeGroup.Select(s => new { LastName = e.LastName, StateName = s.StateName }).DefaultIfEmpty(new { LastName = e.LastName, StateName = "" })).SelectMany(e => e);

            foreach (var employee in employeeByState)
            {
                Debug.WriteLine(employee.LastName + ", " + employee.StateName);
            }
        }

        static void MethodBasedCompositeKey()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    City = "Havertown",
                    State = "PA"
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    City = "Ewing",
                    State = "NJ"
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones", 
                    City = "Fort Washington",
                    State = "PA"
                }
            };

            List<Hometown> hometowns = new List<Hometown>()
            {
                new Hometown()
                {
                    City = "Havertown",
                    State = "PA",
                    CityCode = "1234"
                },
                new Hometown()
                {
                    City = "Ewing",
                    State = "NJ",
                    CityCode = "5678"
                },
                new Hometown()
                {
                    City = "Fort Washington",
                    State = "PA",
                    CityCode = "9012"
                }
            };

            var employeeByState = employees.Join(hometowns,
                                                    e => new { City = e.City, State = e.State },
                                                    h => new { City = h.City, State = h.State },
                                                    (e, h) => new { e.LastName, h.CityCode });

            foreach (var employee in employeeByState)
            {
                Debug.WriteLine(employee.LastName + ", " + employee.CityCode);
            }
        }

        static void MethodBasedGroupV1()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    City = "Havertown",
                    State = "PA"
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    City = "Ewing",
                    State = "NJ"
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones", 
                    City = "Fort Washington",
                    State = "PA"
                }
            };

            var employeesByState = employees.GroupBy(e => e.State);
                                   
            foreach (var employeeGroup in employeesByState)
            {
                Debug.WriteLine(employeeGroup.Key + ": " + employeeGroup.Count());

                foreach (var employee in employeeGroup)
                {
                    Debug.WriteLine(employee.LastName + ", " + employee.State);
                }
            }
        }

        static void MethodBasedGroupV2()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    City = "Havertown",
                    State = "PA"
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    City = "Ewing",
                    State = "NJ"
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones", 
                    City = "Fort Washington",
                    State = "PA"
                }
            };

            var employeesByState = employees.GroupBy(e => new { e.City, e.State });

            foreach (var employeeGroup in employeesByState)
            {
                Debug.WriteLine(employeeGroup.Key + ": " + employeeGroup.Count());

                foreach (var employee in employeeGroup)
                {
                    Debug.WriteLine(employee.LastName + ", " + employee.State);
                }
            }
        }

        static void Concat()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith"                    
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe"                    
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones"                    
                }
            };

            List<Employee> employees2 = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "Bill", 
                    LastName = "Peters"                    
                },
                new Employee() 
                { 
                    FirstName = "Bob", 
                    LastName = "Donalds"                    
                },
                new Employee() 
                { 
                    FirstName = "Chris", 
                    LastName = "Jacobs"                    
                }
            };

            var combinedEmployees = employees.Concat(employees2);

            foreach (var employee in combinedEmployees)
            {
                Debug.WriteLine(employee.LastName);
            }            
        }

        static void ConcatV2()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith"                    
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe"                    
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones"                    
                }
            };

            List<Person> people = new List<Person>()
            {
                new Person() 
                { 
                    FirstName = "Bill", 
                    LastName = "Peters"                    
                },
                new Person() 
                { 
                    FirstName = "Bob", 
                    LastName = "Donalds"                    
                },
                new Person() 
                { 
                    FirstName = "Chris", 
                    LastName = "Jacobs"                    
                }
            };

            var combinedEmployees = employees.Select(e => new { Name = e.LastName }).Concat(people.Select(p => new { Name = p.LastName }));

            foreach (var employee in combinedEmployees)
            {
                Debug.WriteLine(employee.Name);
            }            
        }

        static void Skip()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith"                    
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe"                    
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones"                    
                }
            };

            var newEmployees = employees.Skip(1);

            foreach (var employee in newEmployees)
            {
                Debug.WriteLine(employee.LastName);
            }
        }

        static void Take()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith"                    
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe"                    
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones"                    
                }
            };

            var newEmployees = employees.Take(2);

            foreach (var employee in newEmployees)
            {
                Debug.WriteLine(employee.LastName);
            }
        }

        static void Distinct()
        {
            int[] myArray = new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 };

            var distinctArray = myArray.Distinct();

            foreach (int i in distinctArray)
            {
                Debug.WriteLine(i);
            }
        }

        static void DistinctCodeLab()
        {
            List<State> states = new List<State>()
            {
                new State(){ StateId = 1, StateName = "PA"},
                new State() { StateId = 2, StateName = "NJ"},
                new State() { StateId = 1, StateName = "PA" },
                new State() { StateId = 3, StateName = "NY"}
            };

            var distintStates = states.Distinct();

            foreach (State state in distintStates)
            {
                Debug.WriteLine(state.StateName);
            }
        }

        #endregion Method Based Queries

        #region LINQ to XML

        static void LINQToXML()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    StateId = 1 
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    StateId = 2 
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones", 
                    StateId = 1 
                }
            };
                        
            var xmlEmployees = new XElement("Root", from e in employees                                                                                   
                                                    select new XElement("Employee", new XElement("FirstName", e.FirstName),
                                                                                    new XElement("LastName", e.LastName)));

            Debug.WriteLine(xmlEmployees);            
        }

        static void LINQToXMLV2()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() 
                { 
                    FirstName = "John", 
                    LastName = "Smith", 
                    StateId = 1 
                },
                new Employee() 
                { 
                    FirstName = "Jane", 
                    LastName = "Doe", 
                    StateId = 2 
                },
                new Employee() 
                { 
                    FirstName = "Jack", 
                    LastName = "Jones", 
                    StateId = 1 
                }
            };

            IEnumerable<XElement> xmlEmployees = (IEnumerable<XElement>)(from e in employees
                                                 select e);

            Debug.WriteLine(xmlEmployees);
        }

        #endregion LINQ to XML
    }

    class Hometown
    {
        public string City { get; set; }
        public string State { get; set; }
        public string CityCode { get; set; }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    //class Employee
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int StateId { get; set; }     
    //}

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
        
    class State : IEquatable<State>
    {
        public int StateId { get; set; }
        public string StateName { get; set; }

        public bool Equals(State other)
        {
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            else
            {
                if (StateId == other.StateId && StateName == StateName)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override int GetHashCode()
        {
            return StateId.GetHashCode() ^ StateName.GetHashCode();
        }
    }      

}
