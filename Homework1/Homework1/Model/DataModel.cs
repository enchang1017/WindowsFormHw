using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Model;

namespace Homework1.Model
{
    public partial class DataModel
    {
        public event ModelChangedEventHandler _modelChanged;
        public event ModelChangedEventHandler _categoryChanged;
        public event ModelChangedEventHandler _orderListAdd;
        public delegate void ModelChangedEventHandler();
        private Order _order = new Order();
        private FormData _formData = new FormData();
        private BindingList<Meal> _mealList = new BindingList<Meal>();
        private BindingList<Category> _categories = new BindingList<Category>();
        private BindingList<string> _categoryUsingList = new BindingList<string>();
        private List<int> _usingListIndex = new List<int>();
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
        public void SetSelectedMeal(int buttonIndex)
        {
            if (buttonIndex == Constant.SELECTED_MEAL_INITIAL)
            {
                _order.SelectedMeal = new Meal();
            }
            else
            {
                _order.SelectedMeal = _mealList[buttonIndex];
            }
        }

        /// <summary>
        /// 當OrderList新增 並綁訂事件
        /// </summary>
        public void AddOrderList()
        {
            Meal meal = _order.SelectedMeal;
            meal._modelChanged += UpdateSubtotal;
            _order.OrderMealList.Add(meal);
            NotifyCategory();
        }

        /// <summary>
        /// 取得讀檔後的資料傳回前端 並且設定總頁數
        /// </summary>
        /// <param name="formData"></param>
        /// <returns></returns>
        public void ReadFile()
        {
            ReadData(_mealList, _categories);
            _mealListFactory.SetMealDescription(_mealList);
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
        private void SetMealImage()
        {
            for (int i = 0; i < _mealList.Count; i++)
            {
                this._mealList[i].ImagePath = @"..\..\..\img\MealButtonImg\" + i + Constant.GET_PICTURE;
            }
        }

        //呼叫前端更新總價格
        public void UpdateSubtotal()
        {
            NotifyObserver();
        }

        /// <summary>
        /// 取得頁數正確
        /// </summary>
        public bool GetCurrentPage(string tabPageText, int number)
        {
            if (_mealList[number].Category.ToString() == tabPageText)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 檢查是否選擇的菜單已在訂單內
        /// </summary>
        public bool IsMealInOrderList()
        {
            return _order.CheckMealInOrderList();
        }

        //取得使用的菜單
        public BindingList<string> GetCategoryNameInList(int selectedItem)
        {
            _usingListIndex.Clear();
            _categoryUsingList.Clear();
            for (int i = 0; i < _mealList.Count; i++)
            {
                if (_mealList[i].Category.ToString() == _categories[selectedItem].CategoryName)
                {
                    _categoryUsingList.Add(_mealList[i].MealName);
                    _usingListIndex.Add(i);
                }
            }
            return _categoryUsingList;
        }

        //新增餐點
        public void AddNewMeal(string[] mealInformation)
        {
            Meal meal = new Meal();
            meal._modelChanged += UpdateSubtotal;
            meal.MealName = mealInformation[0];
            meal.MealPrice = Int32.Parse(mealInformation[Constant.MEAL_PRICE]);
            meal.ImagePath = mealInformation[Constant.MEAL_PATH];
            foreach (Category categoryName in _categories)
            {
                if (categoryName.CategoryName == mealInformation[Constant.MEAL_CATEGORY])
                    meal.Category = categoryName;
            }
            meal.MealDescription = mealInformation[Constant.MEAL_DESCRIPTION];
            _mealList.Add(meal);
            NotifyObserver();
        }

        //更改類別名稱
        public void ChangeCategoryName(string newCategoryName, int selectedIndex)
        {
            Category category = new Category();
            category.CategoryName = newCategoryName;
            SetMealListCategory(selectedIndex, category);
            _categories[selectedIndex] = category;
            NotifyCategoryChange();
        }

        //新增類別
        public void AddCategory(string newCategoryName)
        {
            Category category = new Category();
            category.CategoryName = newCategoryName;
            _categories.Add(category);
            NotifyCategoryChange();
        }

    }
}
