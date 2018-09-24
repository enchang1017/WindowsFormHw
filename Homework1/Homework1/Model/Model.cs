using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Model
{
    public class Model
    {
        const string PAGE_LABEL_TEXT_PAGE = "Page:";
        const string SLASH = "/";
        const int MAX_MEAL_BUTTON_NUMBER = 9;
        const string TOTAL_PRICE = "Total : ";
        const string DOLLARS = "元";
        const string NEXT_BUTTON = "_nextPageButton";
        const string WRAP = "\n";
        const string MONEY_SYMBOL = "$";
        const string INITIAL = "";
        /// <summary>
        /// 建立菜單
        /// </summary>
        /// <returns></returns>
        public List<Meal> CreateMeal(Homework1.Model.FormData formData)
        {
            MealListFactory mealListFactory = new MealListFactory();
            formData.totalPage = mealListFactory.ReadData().Count / MAX_MEAL_BUTTON_NUMBER + 1;
            return mealListFactory.ReadData();
        }

        /// <summary>
        /// 觸發按鈕更新現在頁數
        /// </summary>
        /// <param name="formData"></param>
        public void UpdateNowPage(Homework1.Model.FormData formData, string buttonName)
        {
            if (buttonName == NEXT_BUTTON)
            {
                formData.nowPage += 1;
            }
            else
            {
                formData.nowPage -= 1;
            }
        }

        /// <summary>
        /// 設定下一頁按鈕是否Enable
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public bool SetNextPageButtonEnable(Homework1.Model.FormData formData)
        {
            if (formData.nowPage == formData.totalPage)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 設定上一頁按鈕是否Enable
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public bool SetPreviousPageButtonEnable(Homework1.Model.FormData formData)
        {
            if (formData.nowPage == 1)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 設定page label 的 Text
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public string SetPageLabelText(Homework1.Model.FormData formData)
        {
            return PAGE_LABEL_TEXT_PAGE + formData.nowPage + SLASH + formData.totalPage;
        }

        /// <summary>
        /// 設定total price Label Text
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public string SetTotalPriceLabel(Homework1.Model.FormData formData)
        {
            return TOTAL_PRICE + formData.totalPrice + DOLLARS;
        }

        /// <summary>
        /// 計算Total Price
        /// </summary>
        /// <param name="formData"></param>
        /// <param name="meal"></param>
        /// <returns></returns>
        public int SetTotalPrice(Homework1.Model.FormData formData, Homework1.Model.Meal meal)
        {
            return formData.totalPrice += meal._mealPrice;
        }

        /// <summary>
        /// 設定Meal Button的文字內容
        /// </summary>
        /// <param name="mealButtonListIndex"></param>
        /// <param name="formData"></param>
        /// <returns></returns>
        public string SetMealButtonText(int mealButtonListIndex, Homework1.Model.FormData formData)
        {
            return CreateMeal(formData)[mealButtonListIndex]._mealName + WRAP + MONEY_SYMBOL + CreateMeal(formData)[mealButtonListIndex]._mealPrice + DOLLARS;
        }

        /// <summary>
        /// 取得讀檔後的資料傳回前端 並且設定總頁數
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public List<Meal> ReadFile(Homework1.Model.FormData formData)
        {
            MealListFactory mealListFactory = new MealListFactory();
            formData.totalPage = mealListFactory.ReadData().Count / MAX_MEAL_BUTTON_NUMBER + 1;
            return mealListFactory.ReadData();
        }

        /// <summary>
        /// 判斷是否現在有選擇的餐點
        /// </summary>
        /// <returns></returns>
        public bool GetOrderStatus(Homework1.Model.Meal meal)
        {
            if (meal._mealName == INITIAL && meal._mealPrice == 0)
            {
                return false;
            }
            return true;
        }
    }
}
