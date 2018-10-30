using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Model;

namespace Homework1.View.PresentationModel
{
    public partial class CustomerPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private DataModel _dataModel = new DataModel();
        private MealButtonOption _mealButtonOption = new MealButtonOption();

        public CustomerPresentationModel(DataModel dataModel)
        {
            _dataModel = dataModel;
        }
        /// <summary>
        /// 觸發按鈕更新現在頁數
        /// </summary>
        /// <param name="formData"></param>
        public void UpdateNowPage(string buttonName)
        {
            if (buttonName == Constant.NEXT_BUTTON)
            {
                _dataModel.GetFormDataInstance().NowPage += 1;
            }
            else
            {
                _dataModel.GetFormDataInstance().NowPage -= 1;
            }
            Notify(Constant.NOTIFY_PAGE_LABEL);
            Notify(Constant.NOTIFY_PAGE_LABEL);
            Notify(Constant.NOTIFY_PREVIOUS_PAGE);
        }

        /// <summary>
        /// 設定上一頁按鈕是否Enable
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public bool SetPreviousPageButtonEnable(FormData formData)
        {
            if (formData.NowPage == 1)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 計算Total Price
        /// </summary>
        /// <param name="formData"></param>
        /// <param name="meal"></param>
        /// <returns></returns>
        public int SetTotalPrice(Homework1.Model.FormData formData, Homework1.Model.Meal meal)
        {
            return formData.TotalPrice += meal.MealPrice;
        }

        /// <summary>
        /// 設定Meal Button的文字內容
        /// </summary>
        /// <param name="mealButtonListIndex"></param>
        /// <param name="formData"></param>
        /// <returns></returns>
        public string SetMealButtonText(int mealButtonListIndex)
        {
            return _dataModel.CombineButtonText(mealButtonListIndex);
        }

        /// <summary>
        /// 設定總頁數
        /// </summary>
        /// <param name="formData"></param>
        public void SetTotalPage(int buttonListNumber)
        {
            _dataModel.SetTotalPage(buttonListNumber);
            Notify(Constant.NOTIFY_PAGE_LABEL);
        }

        /// <summary>
        /// 取得按鈕選項狀態
        /// </summary>
        /// <param name="totalButtonNumber"></param>
        /// <param name="mealButtonIndex"></param>
        /// <returns></returns>
        public bool GetButtonOption(int totalButtonNumber, int mealButtonIndex)
        {
            return _mealButtonOption.GetButtonOption(totalButtonNumber, mealButtonIndex, _dataModel.GetFormDataInstance());
        }
        
        /// <summary>
        /// 設定總價格
        /// </summary>
        public void SetTotalPrice()
        {
            _dataModel.SetTotalPrice();
            Notify(Constant.NOTIFY_TOTAL_PRICE);
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

        /// <summary>
        /// 設定Add Button Enable
        /// </summary>
        public void GetAddButtonOption(bool addButtonOption)
        {
            if (!addButtonOption)
            {
                _isAddButtonEnabled = false;
                Notify(Constant.NOTIFY_ADD_BUTTON);
            }
            else
            {
                _isAddButtonEnabled = _dataModel.CheckMealInOrderList();
                Notify(Constant.NOTIFY_ADD_BUTTON);
            }
        }
    }
}
