using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Obhod
    {
        public static void Straight(Uzel uzel)
        {

            if (uzel.left != null && uzel.left.used == false)
            {
                if (uzel.used == false)
                    Console.Write(uzel.value);
                uzel.used = true;
                if (uzel.left.right == null && uzel.left.left == null)
                {
                    Console.Write(uzel.left.value);
                    uzel.left.used = true;
                    Straight(uzel);
                }
                Straight(uzel.left);
            }
            if (uzel.right != null && uzel.right.used == false)
            {
                if (uzel.used == false)
                    Console.Write(uzel.value);
                uzel.used = true;
                if (uzel.right.right == null && uzel.right.left == null)
                {
                    Console.Write(uzel.right.value);
                    uzel.right.used = true;
                    Straight(uzel);
                }
                Straight(uzel.right);

            }
            if (uzel.parent != null) Straight(uzel.parent);

        }
        public static void Obrat(Uzel uzel)
        {
            if (uzel.left != null && uzel.left.used == false)
            {
                Obrat(uzel.left);
            }
            if (uzel.right != null && uzel.right.used == false)
            {
                Console.Write(uzel.right.value);
                uzel.used = true;
                Obrat(uzel.right);
            }
            if (uzel.right == null && uzel.left == null && uzel.parent.used == false)
            {
                Console.Write(uzel.value);
                uzel.used = true;
                Console.Write(uzel.parent.value);
                uzel.parent.used = true;
                Obrat(uzel.parent);
            }
            if (uzel.parent != null)
            {
                if (uzel.parent.used == false) Console.Write(uzel.parent.value);
                uzel.parent.used = true;
                uzel.used = true;
                Obrat(uzel.parent);
            }

        }
        public static void Konec(Uzel uzel)
        {
            if (uzel.left != null && uzel.left.used == false)
            {
                Konec(uzel.left);
            }
            if (uzel.right != null && uzel.right.used == false)
            {               
                Konec(uzel.right);
            }
            if (uzel.right == null && uzel.left == null)
            {
                Console.Write(uzel.value);
                uzel.used = true;             
                Konec(uzel.parent);
            }
            if (uzel.used == false)
            {
                Console.Write(uzel.value);
                uzel.used = true;
                if (uzel.parent != null)
                {

                    Konec(uzel.parent);
                }
            }
        }
    }
}
