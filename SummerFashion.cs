using System;

namespace DEMO
{
    public class SummerFashion: Fashion
    {
        public override Shoe CreateShoe(int size, string name, int price)
        {
            return new SummerShoe(size, name, price);
        }

        public override Dress CreateDress(string color, string name)
        {
            return new SummerDress(color, name);
        }
    }
}
