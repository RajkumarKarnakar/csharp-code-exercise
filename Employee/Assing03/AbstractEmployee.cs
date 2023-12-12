using System;
namespace Assing03
{
	public abstract class Employee
{
	private static int _idGenerator;
	private readonly int _empId;
	public int EmpId {  get { return _empId; } }
	private  string _name;
	public string Name { get { return _name; } 
		set { if (value != "" || value !=null) _name = value;
			else throw new Exception("BlankNameException");
		} }
	protected decimal basic;
	protected abstract decimal Basic { get; set; }
	private short deptNo;
	public short DeptNo
	{
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Value must be positive number");
			}
			deptNo = value;
		}
        get { return deptNo; }
    }



//static constructor 
 static Employee()
	{
		_idGenerator = 1;
    }

		protected Employee(string name , decimal basic, short deptNo )
        {
            Name = name;
            Basic = basic;
            DeptNo = deptNo;
        }
		protected Employee(string name,short deptId)
		{
            Name=name;
            DeptNo=deptId;

        }
		public abstract decimal GetNetSalary();

        public override string? ToString()
        {
            return "Emp ID: "+ EmpId + " Name: "+ Name + " Department: "+ DeptNo;
        }
    }

}
