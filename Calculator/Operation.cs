using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     static class Operation
    {
      static  int firts_num;
      static   int Second_num;
        static char oper;

        public static int Firts_num { get => firts_num; set => firts_num = value; }
        public static int Second_num1 { get => Second_num; set => Second_num = value; }
        public static char Oper { get => oper; set => oper = value; }

        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static int sub(int x, int y)
        {
            return x - y;
        }
        public static int mul(int x, int y)
        {
            return x * y;
        }
        public static int div(int x, int y)
        {
            return x / y;
        }

    }
}
