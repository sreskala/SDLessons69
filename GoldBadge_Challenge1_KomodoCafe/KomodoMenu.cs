using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_Challenge1_KomodoCafe
{
    public class KomodoMenu
    {
        //Meal number field
        private int _mealNumber;

        //Meal number
        public int MealNumber
        {
            get { return _mealNumber; }
            set { _mealNumber = value; }
        }

        //Meal name
        public string Name { get; set; }

        //Meal description
        public string Description { get; set; }

        //List of ingredients
        public List<string> Ingredients { get; set; }

        //Price
        public float Price { get; set; }

        //Constructor
        public KomodoMenu(int number, string name)
        {
            MealNumber = number;
            Name = name;
        }
    }
}
