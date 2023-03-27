using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class PizzaBuilder : IBuilder
    {
        public List<string> ingredians;
        
        public PizzaBuilder()
        {
            ingredians = new() { "cotton"};

        }

        public void SetChese()
        {
            ingredians.Add("Chess");
            Console.WriteLine("you have add cheese");
        }

        public void SetExotic()
        {
            ingredians.Add("Exotic");
            Console.WriteLine("you have add exotic");
        }

        public void SetHerbs()
        {
            ingredians.Add("Herbs");
            Console.WriteLine("you have add herbs");
        }

        public void SetMeats()
        {
            ingredians.Add("Meats");
            Console.WriteLine("you have add meat");
        }

        public void SetNuts()
        {
            ingredians.Add("Nuts");
            Console.WriteLine("you have add nuts");
        }

        public void SetSeaFood()
        {
            ingredians.Add("SeaFood");
            Console.WriteLine("you have add seafood");
        }

        public void SetSouce()
        {
            ingredians.Add("Souce");
            Console.WriteLine("you have add souce");
        }

        public void SetSpices()
        {
            ingredians.Add("Spices");
            Console.WriteLine("you have add spices");
        }

        public void SetVegetables()
        {
            ingredians.Add("Vegetables");
            Console.WriteLine("you have add vegetables");
        }
        public string GetProduct()
        {
            string combinedString = string.Join( ",", this.ingredians);
            return combinedString;
        }
    }
}
