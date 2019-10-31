using System;

namespace task3
{
    public class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }

        public override int GetHashCode()
        {
            int hash = 10;
            hash = hash * 25 + x^y.GetHashCode();
            return hash;
        }
    }
}