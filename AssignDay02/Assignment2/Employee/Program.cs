namespace Employee

/*    2. Create an array of Employee class objects
        Accept details for all Employees
        Display the Employee with highest Salary
        Accept EmpNo to be searched.Display all details for that employee.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee[] employees = new Employee[5];
            employees[0] =  new Employee(10, "Rajkumar", 15, 15545);
            employees[1] = new Employee(15, "Rajkumar", 15, 58495);
            employees[2] = new Employee(75, "Rajkumar", 15, 48552);
            employees[3] = new Employee(2, "Rajkumar", 15, 459562);
            employees[4] = new Employee(50, "Rajkumar", 15, 498545);
            foreach (Employee emp in employees) { Console.WriteLine(emp); }
            Array.Sort(employees);
            foreach (Employee emp in employees) { Console.WriteLine(emp); }
            

        }
    }
    internal class Employee : IComparable
    {
        int empId;
        public int EmpId
        {
            get { return empId; }
            set
            {
                if (value > 0) empId = value;
                else
                {
                    Console.WriteLine("Not a valid id");
                }
            }
        }
        string? name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value != "") name = value;
                else
                {
                    Console.WriteLine("name should not be blank");
                }
            }
        }
        int deptNo;
        public int DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid EmpNo");
            }
            get { return deptNo; }
        }
        int basic;
        public int Basic
        {
            set
            {
                if (value < 10000) Console.WriteLine("not a valid basic to pay");
                else basic = salaryCal(value);
            }
            get { return basic; }
        }
        public Employee() { }
        private static int salaryCal(int basic)
        {
            if (basic > 10000)
                return basic + 2500;
            else if (basic > 20000)
                return basic + 5000;
            else return basic + 10000;
        }

        public Employee(int empId = 1, string name = "emp_name***", int deptNo = 10, int basic = 10001)
        {
            EmpId = empId;
            Name = name;
            DeptNo = deptNo;
            Basic = basic;
        }

        

        public override string? ToString()
        {
            return "EmpId: " + empId + " Name: " + name + " DeptNo: " + deptNo + " Basic: " + basic;
        }

        public int CompareTo(object? obj)
        {
            {
                if (obj is Employee temp)
                {
                    if (this.basic > temp.basic)
                    {
                        return 1;
                    }
                    if (this.basic < temp.basic)
                    {
                        return -1;
                    }
                    return 0;
                }
                throw new ArgumentException("Parameter is not a Employee!");
            }
        }
    }

        
    }                       


