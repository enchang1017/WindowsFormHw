using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Model;

namespace Homework1.Model
{
    public class DataModel
    {
        public event ModelChangedEventHandler ModelChanged;
        public delegate void ModelChangedEventHandler();
        private Order _order = new Order();
        private FormData _formData = new FormData();
        private BindingList<Meal> _mealList = new BindingList<Meal>();
        private BindingList<Category> _categories = new BindingList<Category>();

        MealListFactory _mealListFactory = new MealListFactory();

        public DataModel()
        {
            _mealListFactory.ReadCategory(_categories);
            ReadFile();
        }
        /// <summary>
        /// 設定選取Meal
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public void SetSelectedMeal(int ButtonIndex)
        {
            if (ButtonIndex == Constant.SELECTED_MEAL_INITIAL)
            {
                _order.SelectedMeal = new Meal();
            }
            else
            {
                _order.SelectedMeal = _mealList[ButtonIndex];
            }
        }

        /// <summary>
        /// 取的選取Meal
        /// </summary>
        /// <returns></returns>
        public Meal GetSelectedMeal()
        {
            return _order.SelectedMeal;
        }

        /// <summary>
        /// 取得訂購單
        /// </summary>
        /// <returns></returns>
        public List<Meal> GetOrderList()
        {
            return _order.OrderMealList;
        }

        /// <summary>
        /// 取得讀檔後的資料傳回前端 並且設定總頁數
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public void ReadFile()
        {
            _mealListFactory.ReadData(_mealList, _categories);
            SetMealImage();
        }

        /// <summary>
        /// 組合Meal Button Text
        /// </summary>
        /// <param name="mealButtonListIndex"></param>
        /// <returns></returns>
        public string CombineButtonText(int mealButtonListIndex)
        {
            return _mealList[mealButtonListIndex].MealName + Constant.WRAP + Constant.MONEY_SYMBOL + _mealList[mealButtonListIndex].MealPrice + Constant.DOLLARS;
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
        public void SetTotalPage(int buttonListNumber)
        {
            _formData.TotalPage = buttonListNumber / Constant.MAX_MEAL_BUTTON_NUMBER + 1;
        }

        /// <summary>
        /// 設定總價格
        /// </summary>
        public void SetTotalPrice()
        {
            _formData.SetTotalOrderListPrice(_order.OrderMealList);
        }

        /// <summary>
        /// 設定圖片路徑
        /// </summary>
        public void SetMealImage()
        {
            for (int i = 0; i < _mealList.Count; i++)
            {
                this._mealList[i].ImagePath = @"..\..\..\img\MealButtonImg\" + i + Constant.GET_PICTURE;
            }
        }

        /// <summary>
        /// 取得頁數正確
        /// </summary>
        public bool GetCurrentPage(string tabPageText, int number)
        {
            if (this._mealList[number].Category.CategoryName == tabPageText)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 檢查是否選擇的菜單已在訂單內
        /// </summary>
        public bool CheckMealInOrderList()
        {
            foreach (Meal meal in _order.OrderMealList)
            {
                if (meal == _order.SelectedMeal)
                    return false;
            }
            return true;
        }

        public BindingList<Meal> MealsList
        {
            get
            {
                return _mealList;
            }
        }

        public BindingList<Category> CategoriesList
        {
            get
            {
                return _categories;
            }
        }

        public Order GetOrder
        {
            get
            {
                return _order;
            }
        }
        //Oberserve
        private void NotifyObserver()
        {
            if (ModelChanged != null)
                ModelChanged();
        }
    }
}
