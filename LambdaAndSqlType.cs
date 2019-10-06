using System;
using System.Collections.Generic;
using System.Linq;

namespace TestJoin
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int DeptId { get; set; }
    }

    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }        
    }

    public class DispResult
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string EmpName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> eObj = new List<Employee>();
            eObj.Add(new Employee { EmpId = 101, EmpName = "sudhakar", DeptId = 1 });
            eObj.Add(new Employee { EmpId = 102, EmpName = "ravi", DeptId = 2 });
            eObj.Add(new Employee { EmpId = 103, EmpName = "salim", DeptId = 3 });
            eObj.Add(new Employee { EmpId = 104, EmpName = "shiv", DeptId = 1 });
            eObj.Add(new Employee { EmpId = 105, EmpName = "sashi", DeptId = 1 });
            eObj.Add(new Employee { EmpId = 106, EmpName = "suresh", DeptId = 4 });
            eObj.Add(new Employee { EmpId = 108, EmpName = "Sundar", DeptId = 1 });


            List<Department> dobj = new List<Department>();
            dobj.Add(new Department { DeptId = 1, DeptName = "HR" });
            dobj.Add(new Department { DeptId = 2, DeptName = "PAYROLL" });
            dobj.Add(new Department { DeptId = 13, DeptName = "SALES" });
            dobj.Add(new Department { DeptId = 14, DeptName = "DELIVERY" });

            //LAMBDA TYPE
            var finalResult = eObj.Join(dobj,
                                        emp => emp.DeptId,  // ON
                                        dept => dept.DeptId,// ON 
                                        (Emp, Dept) => new { Emp.EmpName, Dept.DeptName, Dept.DeptId }
                                        );

            //SQL TYPE
            //var finalResult =    from e in eObj
            //                     join d in dobj on e.DeptId equals d.DeptId
            //                     select new {e.EmpName,d.DeptName,d.DeptId };

            DispResult dr = new DispResult();
            List<DispResult> lstfinal = new List<DispResult>();

            foreach (var j in finalResult)
            {             
                lstfinal.Add(new DispResult { DeptName=j.DeptName ,EmpName=j.EmpName,DeptId=j.DeptId });
            }   
                         
            foreach (var i in lstfinal)
            {
                Console.WriteLine($"DeptID {i.DeptId} DeptName {i.DeptName} EmployeeName {i.EmpName}");
            }            
            Console.ReadLine();

        }


    }
}

