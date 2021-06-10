using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Kalk
    {
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
                 
                 uzel.used = true;                 
                 Konec(uzel.parent);
             }
             if (uzel.used == false)
             {
                 uzel.value = CalcTree(uzel.left.value, uzel.right.value, uzel.value);
                 uzel.used = true;
                 
                 if (uzel.parent != null)
                 {
                     Konec(uzel.parent);
                 }
             }
         }
        

        public static string CalcTree(string l1, string l2, string k)
        {
            int num1, num2;
            num1 = int.Parse(l1);
            num2 = int.Parse(l2);
            switch (k)
            {
                case "+": return (num1 + num2).ToString();
                case "-": return (num1 - num2).ToString();
                case "*": return (num1 * num2).ToString();
                case "/": return (num1 / num2).ToString();
            }
            return "0";
        }
    }




}
