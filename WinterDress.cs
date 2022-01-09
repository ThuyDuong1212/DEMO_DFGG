using System;

namespace DEMO
{
    public class WinterDress: Dress
    {
        public WinterDress()
        {

        }

        public WinterDress(string color, string name) : base(color, name)
        {
        }

        public override string GetName()
        {
            string name = "Winter Dress: " + Name;
            return name;
        }

        public override string GetColor()
        {
            string color = "This is Winter Dress: " + Color;
            return color;
        }
    }
}