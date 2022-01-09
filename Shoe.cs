using System;

namespace DEMO
{
    public abstract class Shoe
    {
        public string Name
        {
            get;
            set;
        }
        public int Size
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }

        public Shoe()
        {
            Size = 30;
            Name = "Unknown name";
            Price = 400;
        }

        public Shoe(int size, string name, int price)
        {
            Size = size;
            Name = name;
            Price = price;
        }
        public abstract string GetName();

        public abstract string GetSize();

        public abstract string GetPrice();
    }
}