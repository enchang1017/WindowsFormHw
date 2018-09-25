using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Model
{
    public class Order
    {
        const string INITIAL = "";
        /// <summary>
        /// 判斷是否現在有選擇的餐點
        /// </summary>
        /// <returns></returns>
        public bool GetOrderStatus(string mealName, int mealPrice)
        {
            if (mealName == INITIAL && mealPrice == 0)
            {
                return false;
            }
            return true;
        }
    }
}
