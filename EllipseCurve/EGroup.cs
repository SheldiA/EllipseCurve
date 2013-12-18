using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllipseCurve
{
    class EGroup
    {
        private List<EPoint> container;
        private int M;
        private int a;
        private int b;

        public EGroup(int M, int a, int b)
        {
            InitGroup(M, a, b);
        }

        public EGroup(int M)
        {
            Random random = new Random();
            int a = 0;
            int b = 0;

            do
            {
                a = random.Next(1, M - 1);
                b = random.Next(1, M - 1);
            }
            while ((4 * a * a * a + 27 * b * b) % M == 0);

            InitGroup(M, a, b);
        }

        private void InitGroup(int M, int a, int b)
        {
            this.M = M;
            this.a = a;
            this.b = b;
            container = new List<EPoint>();

            for (int x = 0; x < M; x++)
            {
                int temp = x * x * x + a * x + b % M;                                                                                                                                                                                                                                                                       //temp = x * x * x + a * x + b;
                int y = EMath.SquareRootMod(temp, M);
                if (y > 0)
                {
                    EPoint first = new EPoint(x, y, M, a, b);
                    EPoint second = -first;
                    container.Add(first);
                    if (second != first)
                    {
                        container.Add(second);
                    }
                }
            }
        }

        public EPoint FindPoint(string coords)
        {
            return container.Find(p => p.ToString() == coords);
        }

        public EPoint GetGeneratingPoint()
        {
            foreach (EPoint point in container)
            {
                if (IsPrimeNumber(point.Degree()))
                {
                    return point;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return "Ellipse group E" + M + "(" + a + ", " + b + ")";
        }

        private bool IsPrimeNumber(int num)
        {
            if (num == 1)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if ((num % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}


















//using (SHA1Managed sha1 = new SHA1Managed())
//{
//    do
//    {
//        Random random = new Random();
//        EPoint G = GetGeneratingPoint(list);
//        int n = G.Degree();
//        int d = 7;
//        byte[] hash = sha1.ComputeHash(Encoding.Default.GetBytes("y65ytdtdyugu45w54de64e6re6e646ygugggjyghujkjiljilhygikuu"));
//        BigInteger e = BigInteger.Abs(new BigInteger(hash));
//        int k = random.Next(1, n - 1);
//        EPoint temp = G * k;
//        int r = temp.X % n;
//        if (r == 0)
//        {
//            continue;
//        }
//        int z = Int32.Parse(ModInverse(k, n).ToString());
//        int s = Int32.Parse(((z * (e + d * r)) % n).ToString());
//        if (s == 0)
//        {
//            continue;
//        }
//        break;
//    }
//    while (true);
//}



//EPoint PA = list[111] * 1;
//EPoint PB = list[111] * 2322;
//EPoint P = PA * 2322;
//EPoint D = PB * 1;