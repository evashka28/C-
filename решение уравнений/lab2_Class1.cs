using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Difur
    {
        public static double ODE_RungeKutta4(Function f, double x0, double y0, double h, double x)
        {
            double xnew, ynew, k1, k2, k3, k4, result = double.NaN;
            if (x == x0)
                result = y0;
            else if (x > x0)
            {
                do
                {
                    if (h > x - x0) h = x - x0;
                    k1 = h * f(x0, y0);
                    k2 = h * f(x0 + 0.5 * h, y0 + 0.5 * k1);
                    k3 = h * f(x0 + 0.5 * h, y0 + 0.5 * k2);
                    k4 = h * f(x0 + h, y0 + k3);
                    ynew = y0 + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                    xnew = x0 + h;
                    x0 = xnew;
                    y0 = ynew;
                } while (x0 < x);
                result = ynew;
            }
            return result;
        }
        public static double Adams (int h,)
        {
          x1[0]=x00;
          y1[0]=y00;
          float ftemp;
          for (i = 0; i< 3; i++)
          {
             x1[i + 1]=x1[i]+h;
             y2[i + 1]=y1[i]+h* f(x1[i], y1[i]);
             ftemp=f(x1[i + 1], y2[i + 1]);
             y1[i + 1]=y1[i]+h* (f(x1[i], y1[i])+ftemp)/2;
          }
          for(i = 3; i<n; i++)
          {
             x1[i + 1]=x1[i]+h;
            dy[i + 1]=float (y1[i]+((h/24)* (55* f(x1[i], y1[i])-59* f(x1[i - 1], y1[i - 1])+37* f(x1[i - 2], y1[i - 2])-9* f(x1[i - 3], y1[i - 3]))));
            y3[i + 1]=y1[i]+((h/24)* (9* f(x1[i + 1], dy[i + 1])+19* f(x1[i], y1[i])-5* f(x1[i - 1], y1[i - 1])+f(x1[i - 2], y1[i - 2])));
            cout< < x1[i] < < "      ";
            cout< < y3[i + 1] < < endl;

          }
    }
}
