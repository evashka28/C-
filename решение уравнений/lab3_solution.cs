using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class solution
    {
        public static void Gaus(double[,] A, double[] B, int row)
        {
            double d, s;
            double[] x= new double[row]; 
            for (int k = 0; k < row; k++)
            {
                for (int j = k + 1; j < row; j++)
                {
                    d = A[j, k] / A[k, k];
                    for (int i = k; i < row; i++)
                    {
                        A[j, i] = A[j, i] - d * A[k, i];
                    }
                    B[j] = B[j] - d * B[k];
                }
            }

            for (int k = row - 1; k >= 0; k--)
            {
                d = 0;
                for (int j = k; j < row; j++)
                {
                    s = A[k, j] * x[j];
                    d += s;
                }
                x[k] = (B[k] - d) / A[k, k];
            }
            Console.WriteLine("После прямого хода:");
            Print_matrix(A, B, row);
            Console.WriteLine("Ответ:");
            Print_answer(x, row);
        }

        public static void Progonka(double[,] A, double[] B, int row) 
        {
            double[] x = new double[row];
            double[] a = new double[row];
            double y = A[0, 0];
            a[0] = -A[0, 1] / y;
            B[0] = B[0] / y;
            for (int i = 1; i < row - 1; i++)
            {
                y = A[i, i] + A[i, i - 1] * a[i - 1];
                a[i] = -A[i, i + 1] / y;
                B[i] = (B[i] - A[i, i - 1] * B[i - 1]) / y;
            }
        
            x[row - 1] = (B[row - 1] - A[row - 1, row - 2] * B[row - 2]) / (A[row - 1, row - 1] + A[row - 1, row - 2] * a[row - 2]);

            for (int i = row - 2; i >= 0; i--)
            {
                x[i] = a[i] * x[i + 1] + B[i];
            }
            Console.WriteLine("Ответ:");
            Print_answer(x, row);
        }

        public static void Print_matrix (double[,] A, double[] B, int row)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write($"{Math.Round(A[i, j], 2)} \t");
                }
                Console.Write($"|{Math.Round(B[i], 2)} \t");
                Console.WriteLine();
            }
        }
        static void Print_answer(double[] x, int row)
        {
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("x[{0}]={1}", i + 1, x[i]);
            }
        }

    }
}
