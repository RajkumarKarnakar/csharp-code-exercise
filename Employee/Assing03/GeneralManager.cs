using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assing03
{
    internal class GeneralManager : Manager
    {
        private string perks;
        public string Perks
        {
            set
            {
                if (value != "" || value != null) perks = value;
                else throw new Exception("BlankNameException");
            }
            get { return perks; }
        }



        protected override decimal Basic { set; get; }

        public GeneralManager(string name, short deptId, string designation, decimal basic, string perks) : base(name, deptId, designation)
        {
            Basic = basic;
            Perks = perks;
        }


        public override decimal GetNetSalary()
        {
            return Basic * 12;
        }

        public override string? ToString()
        {
            return base.ToString() + " Perks "+perks;
        }
    }
}