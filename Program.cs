using System;

namespace Complex
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //define first complex number.
            Console.WriteLine("Write the real and imaginary numbers for complex number");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            NewDouble re =new NewDouble(x);
            NewDouble im = new NewDouble(y);
            ComplexNumbers obj1 = new ComplexNumbers(re,im);
            //define second complex number.
            Console.WriteLine("Write the real and imaginary numbers for the second complex number");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            re = new NewDouble(x);
            im = new NewDouble(y);
            ComplexNumbers obj2 = new ComplexNumbers(re, im);
            //test all operators and methods written for complex numbers 
            Console.Write("The ADDITION of 2 complex Numbers: ");
            (obj1 + obj2).Printf();
            Console.Write("The SUBTUCTION of 2 complex Numbers: ");
            (obj1 - obj2).Printf();
            Console.Write("The MULTIPLICATION of 2 complex Numbers: ");
            (obj1 * obj2).Printf();
            Console.Write("The DIVISION of 2 complex Numbers: ");
            (obj1 / obj2).Printf();
            Console.Write("The ABSOLUTE value of FIRST Complex number: ");
            (obj1.Absolute()).Printn();
            Console.Write("The ABSOLUTE value of SECOND Complex number: ");
            (obj2.Absolute()).Printn();
            Console.Write("The ARGUMENT value of FIRST Complex number: ");
            (obj1.Arg()).Printn();
            Console.Write("The ARGUMENT value of SECOND Complex number: ");
            (obj2.Arg()).Printn();
            Console.ReadLine();
        }
    }
}
