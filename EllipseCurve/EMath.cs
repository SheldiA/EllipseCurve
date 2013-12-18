using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllipseCurve
{
    public class EMath
    {
        public static int SquareRootMod(long a, long p)
        {
            Random rand = new Random();
            long ai, b, c, d, e, i, r, s = 0, t = p - 1;
            if (Jacobi(a, p) == -1) return 0;
            do
                do b = rand.Next() % p; while (b == 0);
            while (Jacobi(b, p) != -1);
            while ((t & 1) == 0)
            {
                s++; t >>= 1;
            }

            ai = Inverse(a, p);
            c = ExpMod(b, t, p);
            r = ExpMod(a, (t + 1) / 2, p);

            for (i = 1; i < s; i++)
            {
                e = ExpMod(2, s - i - 1, p);
                d = ExpMod((r * r % p) * ai % p, e, p);
                if (d == p - 1) r = r * c % p;
                c = c * c % p;
            }

            return (int)r;
        }

        private static int Jacobi(long a, long n)
        {
            int s = 0;
            long a1, b = a, e = 0, m, n1;

            if (a == 0) return 0;
            if (a == 1) return 1;

            while ((b & 1) == 0)
            {
                b >>= 1;
                e++;
            }
            a1 = b;
            m = n % 8;

            if ((e & 1) == 0) s = 1;
            else if (m == 1 || m == 7) s = +1;
            else if (m == 3 || m == 5) s = -1;
            if (n % 4 == 3 && a1 % 4 == 3) s = -s;
            if (a1 != 1) n1 = n % a1; else n1 = 1;

            return s * Jacobi(n1, a1);
        }

        private static void ExtendedEuclid(long a, long b, out long x, out long y, out long d)
        {
            long q, r, x1, x2, y1, y2;
            if (b == 0)
            {
                d = a;
                x = 1;
                y = 0;
                return;
            }

            x2 = 1;
            x1 = 0;
            y2 = 0;
            y1 = 1;

            while (b > 0)
            {
                q = a / b;
                r = a - q * b;
                x = x2 - q * x1;
                y = y2 - q * y1;
                a = b;
                b = r;
                x2 = x1;
                x1 = x;
                y2 = y1;
                y1 = y;
            }

            d = a;
            x = x2; y = y2;
        }

        private static long Inverse(long a, long b)
        {
            long d, x, y;
            ExtendedEuclid(a, b, out x, out y, out d);
            if (d == 1)
            {
                return x;
            }

            return 0;
        }

        private static long ExpMod(long x, long b, long n)
        {
            long a = 1, s = x;

            while (b != 0)
            {
                if ((b & 1) != 0) a = (a * s) % n;
                b >>= 1;
                if (b != 0) s = (s * s) % n;
            }

            return a;
        }
    }
}
