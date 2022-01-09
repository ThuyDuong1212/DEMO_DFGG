using System;

namespace DEMO
{
    public class Store
    {
        private Dress dress;
        private Shoe shoe;

        private Fashion fashion;

        public Store()
        {
            fashion = new SummerFashion();
            dress = fashion.CreateDress("red", "vay dai");
            shoe = fashion.CreateShoe(24, "giay", 400);
        }

        public void GetName() 
        {
            Console.WriteLine(shoe.GetName());
            Console.WriteLine(dress.GetName());
        }

        public void GetSize() 
        {
            Console.WriteLine(shoe.GetSize());
        }

        public void GetColor()
        {
            Console.WriteLine(dress.GetColor());
        }

        public void GetPrice()
        {
            Console.WriteLine(shoe.GetPrice());
        }

        public void ChangeTheme(string theme)
        {
            if (theme == "Winter") fashion = new WinterFashion();
            else fashion = new SummerFashion();
            
            UpdateInteface();

        }

        private void UpdateInteface() {
            string nameD = dress.Name;
            string nameS = shoe.Name;
            string color = dress.Color;
            int size = shoe.Size;
            int price = shoe.Price;

            dress = fashion.CreateDress(color, nameD);
            shoe = fashion.CreateShoe(size, nameS, price);
            
            GetName();
            GetSize();

            GetColor();
            GetPrice();
        }

    }
}