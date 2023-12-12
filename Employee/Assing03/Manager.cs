using Assing03;
using System;

internal class Manager : Employee
{
    private string _designation;
    public string Designation { set { if (value != "" || value != null) _designation = value;
            else throw new Exception("BlankNameException");
        } get { return _designation; } }



    protected override decimal Basic { set; get; }

    public Manager(string name, short deptId, string designation, decimal basic) : base(name, deptId) 
    {
        Basic = basic;
        Designation = designation;
    }
    public Manager(string name, short deptId, string designation) : base(name, deptId)
    {
        Designation = designation;
    }
}
