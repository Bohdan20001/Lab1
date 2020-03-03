using System;
namespace my_project
{
    public class Program
    {
        static public double Example(double r, double h)
        {
           double pi = 3.14;
            double s = 2 * pi * r * h;
            Console.WriteLine("S = 2Пrh = 2*3,14*" + r.ToString() + " * " + h.ToString() + " = " +
            s.ToString());
            return s;
        }
        static public double Example1(double r, double h)
        {
            double pi = 3.14;         
            double v = pi * (r * r) * h;          
            Console.WriteLine("V = П(r*r)h =3,14*" + r.ToString() + " * " + h.ToString() + " = " +
           v.ToString());          
            return v;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть радіус циліндра");
            string S1 = Console.ReadLine();
            double r = double.Parse(S1);
            Console.WriteLine("Введiть висоту циліндра");
            string S2 = Console.ReadLine();
            double h = double.Parse(S2);
            Example(r, h);
            Example1(r, h);
            Console.ReadLine();            
        }
    }
}