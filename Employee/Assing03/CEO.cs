using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assing03
{
    internal class CEO : Employee
    {
        protected override decimal Basic{ get; set; }
        public CEO(string name, decimal basic, short deptNo) : base(name, basic, deptNo)
        {
            Basic = basic;
        }

        public override decimal GetNetSalary()
        {
            return Basic*9;
        }
        public override string ToString()
        {
            return base.ToString()+" salary "+GetNetSalary();
        }
    }

}
