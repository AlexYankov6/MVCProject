using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zelenchukova_borsa_MVC.Model;
using zelenchukova_borsa_MVC.View;

namespace zelenchukova_borsa_MVC.Controler
{
    internal class Tipcontroler
    {
        private GardenView display;
        private GarderSale garderSale;
        

        public Tipcontroler() 
        {

            display=new GardenView();
            display.Input();
            garderSale=new GarderSale(display.VegetablePrice,display.FruitPrice,
                display.VegetableKg,display.FruitKg);
           display.SumEuro= garderSale.SumEuro();
            display.Output();


        }
        

    }
}
