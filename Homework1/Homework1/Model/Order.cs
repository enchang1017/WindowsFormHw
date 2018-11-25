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
        private BindingList<Meal> _orderList = new BindingList<Meal>();
        public Meal SelectedMeal
        {
            get;
            set;
        }

        public BindingList<Meal> OrderMealList
        {
            get
            {
                return _orderList;
            }
            set
            {
                _orderList = value;
            }
        }

        /// <summary>
        /// 檢查是否選擇的菜單已在訂單內
        /// </summary>
        public bool CheckMealInOrderList()
        {
            foreach (Meal meal in OrderMealList)
            {
                if (meal == SelectedMeal)
                    return false;
            }
            return true;
        }
    }
}
