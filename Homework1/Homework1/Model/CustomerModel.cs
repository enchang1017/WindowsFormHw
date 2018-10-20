using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Model;

namespace Homework1.View.PresentationModel
{
    public class CustomerModel
    {
        private Order _order = new Order();
        private FormData _formData = new FormData();
        private List<Meal> _mealList = new List<Meal>();

        /// <summary>
        /// 設定選取Meal
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public Meal SetSelectedMeal(Meal meal)
        {
            _order.selectedMeal = meal;
            return _order.selectedMeal;
        }

        /// <summary>
        /// 取的選取Meal
        /// </summary>
        /// <returns></returns>
        public Meal GetSelectedMeal()
        {
            return _order.selectedMeal;
        }

        /// <summary>
        /// 取得訂購單
        /// </summary>
        /// <returns></returns>
        public List<Meal> GetOrderList()
        {
            return _order.orderMealList;
        }

        /// <summary>
        /// 取得讀檔後的資料傳回前端 並且設定總頁數
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public List<Meal> ReadFile()
        {
            MealListFactory mealListFactory = new MealListFactory();
            _mealList = mealListFactory.ReadData();
            return _mealList;
        }

        /// <summary>
        /// 組合Meal Button Text
        /// </summary>
        /// <param name="mealButtonListIndex"></param>
        /// <returns></returns>
        public string CombineButtonText(int mealButtonListIndex)
        {
            return _mealList[mealButtonListIndex]._mealName + Constant.WRAP + Constant.MONEY_SYMBOL + _mealList[mealButtonListIndex]._mealPrice + Constant.DOLLARS;
        }

        /// <summary>
        /// 回傳FormData
        /// </summary>
        /// <returns></returns>
        public FormData GetFormDataInstance()
        {
            return _formData;
        }

        /// <summary>
        /// 設定頁數並記錄起來
        /// </summary>
        public void SetTotalPage()
        {
            _formData.totalPage = this.ReadFile().Count / Constant.MAX_MEAL_BUTTON_NUMBER + 1;
        }

        /// <summary>
        /// 設定總價格
        /// </summary>
        public void SetTotalPrice()
        {
            _formData.SetTotalOrderListPrice(_order.orderMealList);
        }
    }
}
