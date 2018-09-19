using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class MealListFactory
    {
        private List<Meal> _mealsList;

        const string MACKERELSUSHIROAST = "烤鯖魚押壽司";
        const int LOWERPRICE = 40;

        /// <summary>
        /// 菜單生成
        /// </summary>
        /// <returns></returns>
        public List<Meal> CreateMealList()
        {
            Meal mackerelSushiRoast = new Meal(MACKERELSUSHIROAST, LOWERPRICE);

            return _mealsList;
        }
    }
}
