using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class dif
    {
        double f(double x, double y) { return x - y; }

        void Rungekutta(double x, double y, double h, int m)
        {
            double k1, k2, k3, k4;
            double[] X = new double[m];
            double[] Y = new double[m];
            X[0] = x; Y[0] = y;
            int i = 1;
            do
            {
                k1 = h * f(X[i - 1], Y[i - 1]);
                k2 = h * f(X[i - 1] + h / 2, Y[i - 1] + k1 / 2);
                k3 = h * f(X[i - 1] + h / 2, Y[i - 1] + k2 / 2);
                k4 = h * f(X[i - 1] + h, Y[i - 1] + k3);
                Y[i] = Y[i - 1] + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                X[i] = X[i - 1] + h;
                i = i + 1;
            } while (i <= m);
            for (int j = 0; j <= m; j++)
            {
                Console.WriteLine($"x[ { j } ] =   { X[j]}   y[ { j } ] =  { Y[j]} \n");
            }
        }

        void Prognoz(double x, double y, double h, int m)
        {
            double[] X = new double[m];
            double[] Y = new double[m];
            if (m > 3)
            {
                Rungekutta(x, y, h, 3);
                for (int i = 4; i <= m; i++)
                {
                    Y[i] = Y[i - 1] + h * (55 * f(X[i - 1], Y[i - 1])
                        - 59 * f(X[i - 2], Y[i - 2]) + 37 * f(X[i - 3], Y[i - 3])
                        - 9 * f(X[i - 4], Y[i - 4])) / 24;
                    for (int j=4; j<=m; j++)
                        Y[i]=Y[i-1]+ h*(9*f(X[i], Y[i])+ 19*f(X[i-1],Y[i-1])-5*f(X[i - 2], Y[i - 2]) + f(X[i - 3], Y[i - 3])) /24;
                }
            }
            else Rungekutta(x, y, h, m);
            for (int i = 0; i <= m; i++)
            {
                Console.WriteLine($"x[ { i } ] =   { X[i]}   y[ { i } ] =  { Y[i]} \n");
            }
        }

        void Adams(double x, double y, double h, int m)
        {
            double[] X = new double[m];
            double[] Y = new double[m];
            
            if (m > 3)
            {
                Rungekutta(x, y, h, 3);
                for (int i = 4; i <= m; i++)
                {
                    double d1 = f(X[i - 1], Y[i - 1]) - f(X[i - 2], Y[i - 2]);
                    double d2 = f(X[i - 1], Y[i - 1]) - 2 * f(X[i - 2], Y[i - 2])
                        + f(X[i - 3], Y[i - 3]);
                    double delta3 = f(X[i - 1], Y[i - 1]) - 3 * f(X[i - 2], Y[i - 2])
                        + 3 * f(X[i - 3], Y[i - 3]) - f(X[i - 4], Y[i - 4]);
                    Y[i] = Y[i - 1] + h * f(Y[i - 1], X[i-1]) + Math.Pow(h, 2) / 2 * d1
                        + 5 / 12 * Math.Pow(h, 3) * d2 + 3 / 8 * Math.Pow(h, 4) * delta3;
                    
                }
            }
            else Rungekutta(x, y, h, m);
            for (int i = 0; i <= m; i++)
            {
                Console.WriteLine($"x[ { i } ] =   { X[i]}   y[ { i } ] =  { Y[i]} \n");
            }
        }

        double accuracy(double h) { return Math.Pow(h, 5); }

        double integral (double x, double y)
        { return y * x * Math.Sin(x); }

        void priblizh(double x, double y, double h, int m)
        {
            double[] X = new double[m];
            double[] Y = new double[m];
            X[0] = x; Y[0] = y;
            for (int i=0; i<m-1; i++)
            {
                Y[i + 1] = y + integral(X[i], Y[i]);
                X[i + 1] = X[i] + h;
            }
        }


        double  approximation(int k, double x, double y)
        {
            double result = 0;
            double [] c = new double[k + 1];
            double [] с2 = new double[k + 1];
            int n = 1;
            for (int i = 0; i <= k + 1; i++) { c[i] = 0; с2[i] = 0; };
            c[0] = 1;
            for (int j = 1; j <= k + 1; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    c[i] *= -1;
                    if (i == 1) c[i] += 1;
                    с2[i + 1] = c[i] / (i + 1);
                }
                с2[0] = 1;
                n++;
                for (int i = 0; i <= k + 1; i++) { c[i] = с2[i]; }
            }
            for (int i = 0; i <= k + 1; i++)
            {
                result += с2[i] * Math.Pow(x, i);
            }
            return result;
        }
        void  get_approximation(int k, double x, double y)
        {
            double [] c = new double[k + 1];
            double []с2 = new double[k + 1];
            int n = 1;
            for (int i = 0; i <= k + 1; i++) { c[i] = 0; с2[i] = 0; };
            c[0] = 1;
            for (int j = 1; j <= k + 1; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    c[i] *= -1;
                    if (i == 1) c[i] += 1;
                    с2[i + 1] = c[i] / (i + 1);
                }
                с2[0] = 1;
                n++;
                for (int i = 0; i <= k + 1; i++) { c[i] = с2[i]; }
            }
            Console.WriteLine ( "y = ");
            for (int i = 0; i <= k + 1; i++)
            {
                Console.WriteLine( $"( {с2[i]}*x^ { i} )");
                if (i != k + 1) Console.WriteLine(" + ");
            }
        }
        void solve_approximation(double x, double y)
        {
            int i = 1;
            while (Math.Abs(approximation(i, x, y) - approximation(i - 1, x, y)) > Math.Pow(10, -10))
            {
                i++;
            };
            get_approximation(i, x, y);

        }
    }
}
