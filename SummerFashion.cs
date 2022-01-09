using System;

namespace DEMO
{
    public class SummerFashion: Fashion
    {
        public override Shoe CreateShoe(int size, string name)
        {
            return new SummerShoe(size, name);
        }

        public override Dress CreateDress(string color, string name)
        {
            return new SummerDress(color, name);
        }
    }
}
