using System;

namespace DEMO
{
    public class SummerShoe: Shoe
    {
        public SummerShoe()
        {

        }

        public SummerShoe(int size, string name, int price) : base(size, name, price)
        {
        }

        public override string GetName()
        {
            return "Summer Shoe: " + Name;
        }

        public override string GetSize()
        {
            return "This is Summer Shoe: " + Size;
        }

        public override string GetPrice()
        {
            return "Summer Shoe: " + Price;
        }


    }
}