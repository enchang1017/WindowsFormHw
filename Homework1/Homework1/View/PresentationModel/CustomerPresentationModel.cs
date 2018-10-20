using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Model;

namespace Homework1.View.PresentationModel
{
    public partial class CustomerPresentationModel
    {
        private CustomerModel _customerModel = new CustomerModel();
        private MealButtonOption _mealButtonOption = new MealButtonOption();
        public CustomerPresentationModel(CustomerModel customerModel)
        {
            _customerModel = customerModel;
        }
        /// <summary>
        /// 觸發按鈕更新現在頁數
        /// </summary>
        /// <param name="formData"></param>
        public void UpdateNowPage(string buttonName)
        {
            if (buttonName == Constant.NEXT_BUTTON)
            {
                _customerModel.GetFormDataInstance().nowPage += 1;
            }
            else
            {
                _customerModel.GetFormDataInstance().nowPage -= 1;
            }
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
        public string GetPageLabelText()
        {
            return _customerModel.GetFormDataInstance().GetPageLabelText();
        }

        /// <summary>
        /// 設定total price Label Text
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public string GetTotalPriceLabel()
        {
            return Constant.TOTAL_PRICE + _customerModel.GetFormDataInstance().totalPrice + Constant.DOLLARS;
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
        public string SetMealButtonText(int mealButtonListIndex)
        {
            return _customerModel.CombineButtonText(mealButtonListIndex);
        }

        /// <summary>
        /// 取得Meal List
        /// </summary>
        /// <returns></returns>
        public List<Meal> GetMealList()
        {
            return _customerModel.ReadFile();
        }

        /// <summary>
        /// 設定總頁數
        /// </summary>
        /// <param name="formData"></param>
        public void SetTotalPage()
        {
            _customerModel.SetTotalPage();
        }

        /// <summary>
        /// 取的CustomerModel
        /// </summary>
        /// <returns></returns>
        public CustomerModel GetCustomerModelInstance()
        {
            return _customerModel;
        }

        /// <summary>
        /// 設定上一頁按鈕狀態
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public bool SetPreviousPageButtonStatus()
        {
            if (_customerModel.GetFormDataInstance().nowPage == 1)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 設定下一頁按鈕狀態
        /// </summary>
        /// <returns></returns>
        public bool IsNextPageButtonEnable()
        {
            return _customerModel.GetFormDataInstance().SetNextPageButtonEnable();
        }

        /// <summary>
        /// 取得按鈕選項狀態
        /// </summary>
        /// <param name="totalButtonNumber"></param>
        /// <param name="mealButtonIndex"></param>
        /// <returns></returns>
        public bool GetButtonOption(int totalButtonNumber, int mealButtonIndex)
        {
            return _mealButtonOption.GetButtonOption(totalButtonNumber, mealButtonIndex, _customerModel.GetFormDataInstance());
        }
        
        /// <summary>
        /// 設定總價格
        /// </summary>
        public void SetTotalPrice()
        {
            _customerModel.SetTotalPrice();
        }

        //設定MealButton Location
        public Point SetMealButtonLocation(int buttonIndex)
        {
            MealButtonOption mealButtonOption = new MealButtonOption();
            if (buttonIndex % Constant.MAX_ROW_NUMBER == 0)
            {
                return new Point(Constant.INITIAL_X, Constant.INITIAL_Y + mealButtonOption.GetVariable(buttonIndex));
            }
            else if (buttonIndex % Constant.MAX_ROW_NUMBER == 1)
            {
                return new Point(Constant.INITIAL_X + Constant.SPACING, Constant.INITIAL_Y + mealButtonOption.GetVariable(buttonIndex));
            }
            else
            {
                return new Point(Constant.INITIAL_X + Constant.SPACING + Constant.SPACING, Constant.INITIAL_Y + mealButtonOption.GetVariable(buttonIndex));
            }
        }
    }
}
