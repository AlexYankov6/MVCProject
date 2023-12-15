using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zelenchukova_borsa_MVC.Model
{
    internal class GarderSale
    {
        private double vegetablePrice;
        private double fruitPrice;
        private int vegetableKg;
        private int fruitKg;

        public double VegetablePrice
        {
            get { return vegetablePrice; }
            set { vegetablePrice = value; }
        }

        public double FruitPrice
        {
            get { return fruitPrice; }
            set {  fruitPrice = value; }

        }

       
        public int VegetableKg
        {
            get { return vegetableKg; }
            set { vegetableKg = value; }
        }
        
        public int FruitKg
        {
            get { return fruitKg; }
            set { fruitKg = value; }
        }


        public GarderSale(double vegetablePrice, double fruitPrice, int vegetableKg,int fruitKg) 
        {
            VegetablePrice = vegetablePrice;
            FruitPrice = fruitPrice;
            VegetableKg = vegetableKg;
            FruitKg = fruitKg;

        }
        public GarderSale() : this(0,0,0,0) { }
       private double CulculateVegetable()
       {
            return VegetablePrice*VegetableKg;
       }
        private double CulculateFruit()
        {
            return FruitPrice * FruitKg;
        }
        private double GetSum()
        {
            return CulculateVegetable() + CulculateFruit();
        }
        public double SumEuro()
        {
            return GetSum() /1.94;
        }


    }
}
