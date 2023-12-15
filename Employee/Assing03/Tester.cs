namespace Assing03
{
    internal class Tester
    {
        static void Main(string[] args)
        {

            Employee emp = new Manager("Raj",12,"senior", 10000);
            Employee emp2 = new CEO("rk", 50000, 10);
            Employee emp3=new GeneralManager("lk",100,"project manager",50000,"free lunch");
            Console.WriteLine(emp);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);

        }
    }
}
