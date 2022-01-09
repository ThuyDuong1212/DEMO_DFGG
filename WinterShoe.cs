using System;

namespace DEMO
{
    public class WinterShoe: Shoe
    {
       public WinterShoe()
        {

        }

        public WinterShoe(int size, string name, int price) : base(size, name, price)
        {
        }

        public override string GetName()
        {
            return "Winter Shoe: " + Name;
        }

        public override string GetSize()
        {
            return "This is Winter Shoe: " + Size;
        }

        public override string GetPrice()
        {
            return "This is Winter Shoe: " + Price;
        }
    }
}