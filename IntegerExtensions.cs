using System;
using System.Threading;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            if (a == 0 && b == 0) throw new ArgumentException();
            if (a == 0 || b == 0) return Math.Max(a,b);
            while (true)
            {
                var rem = Math.Max(a, b) - Math.Min(a, b);
                if (rem == 0) return a;
                if (Math.Min(a, b) % rem == 0) return rem;
                a = Math.Min(a, b);
                b = rem;
            }
        }
    }
}