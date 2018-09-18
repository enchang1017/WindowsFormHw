using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Model
    {
        private MealListFactory _mealListFactory;

        List<Meal> mealsList = new List<Meal>();
        
        public string CreateMeal()
        {

            mealsList = _mealListFactory.CreateMealList();
            return "";
        }

    }
}
