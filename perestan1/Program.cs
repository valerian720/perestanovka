using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perestan1
{
    class Program
    {

        /*
         идёт рекурсия через ф-цию F
         причём рекурсия идёт в форме дерева 

            т.е. 
            -1
              2
                3
              3
                2
            -2
              1
                3
              3
                1
            -3
              1
                2
              2
                1

            /////////////////////////////////////
            100
            010
            001
             */

        static void f(int n, ref bool[] m, string ret) 
        {
          if (n==0) Console.WriteLine(ret);

            for (int i = 0; i < m.Length; i++) {
                int curNum = i + 1;

                if (!m[i]) {
                    addBool(ref m, true, i);
                    f(n - 1, ref m, ret + curNum);
                    addBool(ref m, false, i);
                }

            }


        }

        static void addBool( ref bool[] arr, bool b, int pos) {
            arr[pos] = b;
        }

        //=====================
        static void outp(bool[] m) {
            foreach (bool bol in m)
                Console.Write(bol?"1":"0");

            Console.WriteLine();
        }

        
        //=====================

        static void Main(string[] args)
        {
            int inp = 3; // input

            bool[] m = new bool[inp];

            

            // f
            f(inp,ref  m, "");

            Console.ReadLine();
        }
    }
}
