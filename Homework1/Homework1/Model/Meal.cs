using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Model
{
    public class Meal
    {
        public Meal(string mealName , int mealPrice)
        {
            this.MealName = mealName;
            this.MealPrice = mealPrice;
        }
        /// <summary>
        /// 菜名
        /// </summary>
        public string MealName
        {
            get;
            set;
        }

        /// <summary>
        /// 價格
        /// </summary>
        public int MealPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 菜單簡介
        /// </summary>
        public string MealDescription
        {
            get;
            set;
        }

        public string ImagePath
        {
            get;
            set;
        }
    }
}
