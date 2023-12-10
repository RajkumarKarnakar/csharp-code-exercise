using Assing03;
using System;

internal class Manager:Employee
{
    private string _designation;
    public string Designation { set { if (value != "" || value != null) _designation = value;
            else throw new Exception("BlankNameException");
        } get { return _designation; } }



    protected override decimal Basic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override decimal GetNetSalary()
    {
        throw new NotImplementedException();
    }
}
