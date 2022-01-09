using System;

namespace DEMO
{
    public class SummerShoe: Shoe
    {
        public SummerShoe()
        {

        }

        public SummerShoe(int size, string name) : base(size, name)
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
    }
}