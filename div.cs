using System;

namespace Aritmeticas
{
    public class ClaseDiv
    {
        public static long div(long a,long b) 
        {
            if(b!=0)return a / b;
            return 0;
        }
        public static double div(double a, double b)
        {
            if (b != 0) return a / b;
            return 0;
        }
    }
}
