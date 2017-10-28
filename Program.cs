using System;

namespace EnumTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MonthOfYearExtensibleEnums m1 = "Feb";
            MonthOfYearExtensibleEnums m2 = "February";
            Console.WriteLine(m1==m2);

            TaxAmountEnums t1 = 6.0;
            TaxAmountEnums t2 = 7.0;
            Console.WriteLine(t1==t2);

        }
    }
}
