using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Model;

namespace Homework1.Model
{
    public class Order
    {
        private List<Meal> _orderList = new List<Meal>();
        public Meal SelectedMeal
        {
            get;
            set;
        }

        public List<Meal> OrderMealList
        {
            get
            {
                return _orderList;
            }
        }
    }
}
