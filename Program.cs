using System;
using del_exp.App;

namespace del_exp
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingDepartment md = new MarketingDepartment();
            md.ExecuteMareketingPlan(10000);
            Console.ReadLine();
        }
    }
}
