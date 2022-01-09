using System;


namespace DEMO
{
    public abstract class Fashion
    {
        public abstract Shoe CreateShoe(int size ,string name, int price);

        public abstract Dress CreateDress(string color, string name);

    }
}