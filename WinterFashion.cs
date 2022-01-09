using System;

namespace DEMO
{
    public class WinterFashion: Fashion
    {
        public override Shoe CreateShoe(int size, string name, int price)
        {
            return new WinterShoe(size, name, price);
        }

        public override Dress CreateDress(string color, string name)
        {
            return new WinterDress(color, name);
        }
    }
}