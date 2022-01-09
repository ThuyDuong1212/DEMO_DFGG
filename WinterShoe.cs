using System;

namespace DEMO
{
    public class WinterShoe: Shoe
    {
       public WinterShoe()
        {

        }

        public WinterShoe(int size, string name) : base(size, name)
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
    }
}