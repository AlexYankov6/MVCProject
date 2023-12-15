using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zelenchukova_borsa_MVC.View
{
    internal class GardenView
    {
        public double VegetablePrice {  get; set; }
        public double FruitPrice { get; set; }
        public int VegetableKg { get; set; }
        public int FruitKg { get;set; }
      
        public double SumEuro { get; set; }
        public GardenView()
        {
            VegetablePrice = 0;
            VegetableKg = 0;
            FruitPrice = 0;
            FruitKg = 0;
            SumEuro = 0;
        }

        public void Input()
        {
            Console.WriteLine("What is the Vegetable Price: ");
            VegetablePrice=double.Parse(Console.ReadLine());

            Console.WriteLine("What is the `Fruit Price: ");
            FruitPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the Kg : ");
            VegetableKg = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the fruitkg: ");
            FruitKg= int.Parse(Console.ReadLine());


        }
        public void Output()
        {
            Console.WriteLine(SumEuro);
        }
    }
}
