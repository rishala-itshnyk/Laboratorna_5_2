using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            double xp, xk, x, dx, eps, s = 0;
            int n = 0;
            Console.Write("xp = ");
            xp = double.Parse(Console.ReadLine());
            Console.Write("xk = ");
            xk = double.Parse(Console.ReadLine());
            Console.Write("dx = ");
            dx = double.Parse(Console.ReadLine());
            Console.Write("eps = ");
            eps = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("|" + " x " + "|" + " log((1.0 + x)/(1.0-x)) " + "|" + " S " + "|" + " n " + "|");
            Console.WriteLine("-------------------------------------------------");
            x = xp;
            while (x <= xk)
            {
                s = S(x, eps, ref n, s);
                Console.WriteLine("|" + x.ToString("F2") + " |" + Math.Log((1.0 + x) / (1.0 - x)).ToString("F5") + " |" + s
                    .ToString("F5") + " |" + n.ToString("F2") + " |");
                x += dx;
            }

            Console.WriteLine("-------------------------------------------------");
        }

        public static double S(double x, double eps, ref int n, double s)
        {
            n = 0;
            double a = x;
            s = a;
            do
            {
                n++;
                a = A(x, n, a);
                s += a;
            } while (Math.Abs(a) >= eps);

            return s;
        }

        static double A(double x, int n, double a)
        {
            double R = 2.0 * (x * x) * ((2 * n - 1.0) / (2 * n + 1.0));
            a *= R;
            return a;
        }
    }
}