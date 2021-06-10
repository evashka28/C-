using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Uzel root = new Uzel("a", null, false);
            Uzel b = new Uzel("b", root, false);
            Uzel c = new Uzel( "c", root, false);
            Uzel d = new Uzel( "d", b, false);
            Uzel e = new Uzel( "e", b, false);
            Uzel f = new Uzel( "f", c, false);
            root.left = b;
            root.right = c;
            b.left = d;
            b.right = e;
            c.right = f;*/

            Uzel root = new Uzel("/", null, false);
            Uzel b = new Uzel("*", root, false);
            Uzel c = new Uzel("3", root, false);
            Uzel d = new Uzel("+", b, false);
            Uzel e = new Uzel("-", b, false);
            Uzel f = new Uzel("2", d, false);
            Uzel g = new Uzel("3", d, false);
            Uzel h = new Uzel("7", e, false);
            Uzel i = new Uzel("4", e, false);
            

            root.left = b;
            root.right = c;
            b.left = d;
            b.right = e;
            d.right = g;
            d.left = f;
            e.left = h;
            e.right = i;
            //string[] m = new string[10];
            //var list = new List<string>();
            Kalk.Konec(root);
            //Console.WriteLine(Kalk.CalcTree(root));
            // Obhod.Straight(root);
            //Obhod.Obrat(root);
            // Obhod.Konec(root);
            //foreach (var k in list)
            //Console.Write(" {}", k);
            Console.Write(root.value);

        }
    }
}
