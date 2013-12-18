using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EllipseCurve
{
    public class EPoint
    {
        private int x;
        private int y;
        private int m;
        private int a;
        private int b;
        private bool isZero;

        public EPoint(int x, int y, int M, int a, int b)
        {
            this.x = x;
            this.y = y;
            this.m = M;
            this.a = a;
            this.b = b;
            isZero = false;
        }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public int M
        {
            get
            {
                return m;
            }
        }

        public static EPoint operator +(EPoint val1, EPoint val2)
        {
            if (val2.IsZero)
            {
                return val1;
            }

            if (val1.IsZero)
            {
                return val2;
            }

            if (val1 == -val2)
            {
                return EPoint.Zero;
            }

            int M = val1.M;

            int lambda = 0;

            if (val1 == val2)
            {
                lambda = Int32.Parse(((BigInteger.Pow((2 * val1.y), M - 2) % M) * ((3 * val1.x * val1.x + val1.a) % M) % M).ToString());
            }
            else
            {
                lambda = Int32.Parse(((BigInteger.Pow((val1.x - val2.x), M - 2) % M) * ((val1.y - val2.y) % M) % M).ToString());
            }
            int newX = (lambda * lambda - val1.x - val2.x + M * 666) % M;
            int newY = (-val1.y + lambda * (val1.x - newX) + M * 666) % M;

            return new EPoint(newX, newY, M, val1.a, val1.b);
        }

        public static EPoint operator *(EPoint val1, int val2)
        {
            if (val2 == 0)
            {
                return EPoint.Zero;
            }
            if (val1.IsZero)
            {
                return val1;
            }

            EPoint result = new EPoint(val1.x, val1.y, val1.m, val1.a, val1.b);
            for (int i = 1; i < val2; i++)
            {
                result += val1;
            }

            return result;
        }

        public static EPoint operator -(EPoint value)
        {
            if (value.IsZero)
            {
                return value;
            }
            return new EPoint(value.x, (value.M - value.y) % value.M, value.M, value.a, value.b);
        }

        public static bool operator ==(EPoint val1, EPoint val2)
        {
            if (val1 as Object == null)
            {
                return false;
            }
            return val1.Equals(val2);
        }

        public static bool operator !=(EPoint val1, EPoint val2)
        {
            return !val1.Equals(val2);
        }
        
        public override string ToString()
        {
            if (!IsZero)
            {
                return "(" + x + "," + y + ")";
            }
            else
            {
                return "Zero";
            }
        }

        public int Degree()
        {
            int result = 1;
            while (true)
            {
                if ((this * result).IsZero)
                {
                    return result;
                }
                result++;
            }
        }

        public override bool Equals(object obj)
        {
            return obj != null && this.GetHashCode() == obj.GetHashCode() && obj is EPoint;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public bool IsZero
        {
            get
            {
                return isZero;
            }
        }



        public static EPoint Zero
        {
            get
            {
                EPoint result = new EPoint(0, 0, 0, 0, 0);
                result.isZero = true;
                return result;
            }
        }
    }
}
