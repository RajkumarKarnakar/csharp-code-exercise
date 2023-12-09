using System.Runtime.CompilerServices;

namespace EmpMangement
{
    internal class Employee
    {
        int empId;
        public int EmpId { 
            get { return empId; } 
            set { if (value > 0) empId = value;
                    else { Console.WriteLine("Not a valid id"); 
                    }
                }
            }
        string? name;
        public string Name { 
            get { return name; } 
            set { if (value != "") name = value;
                else{
                    Console.WriteLine("name should not be blank");
                    }
                }  
            }
        int deptNo;
        public int DeptNo { set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid EmpNo");
            } get { return deptNo; } }
        int basic;
        public int Basic {  set { if (value < 10000) Console.WriteLine("not a valid basic to pay") ; 
                else basic = salaryCal(value); }get { return basic; } } 
        public Employee() { }
        private static int salaryCal(int basic) {
            if (basic > 10000)
                return basic + 2500;
            else if (basic > 20000)
                return basic + 5000;
            else return basic + 10000;
        }

        public Employee(int empId=1, string name="emp_name***", int deptNo=10, int basic=10001)
        {
            EmpId = empId;
            Name = name;
            DeptNo = deptNo;
            Basic = basic;
        }

        public override string? ToString()
        {
            return "EmpId: "+ empId+ " Name: "+ name+ " DeptNo: "+ deptNo+ " Basic: "+basic;
        }
    }
    internal class ProgramTester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee emp = new Employee(1, "Rajkumar", 15,25000);
            Employee emp2 = new Employee(10, "Rajkumar", 15);
            Employee emp3 = new Employee(1,"Rajkumar");
            Employee emp4 = new Employee(1);
            Console.WriteLine(emp);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);
            Console.WriteLine(emp4);
            Employee emp5 = new Employee();
            Console.WriteLine();

        }
    }
}
