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
        //刪除類別
        public void DeleteCategory(int selectedIndex)
        {
            for (int i = _mealList.Count - 1; i >= 0 ; i--)
            {
                if (_mealList[i].Category.ToString() == _categories[selectedIndex].CategoryName)
                {
                    _mealList.RemoveAt(i);
                }
            }
            _categories.RemoveAt(selectedIndex);
            NotifyCategoryChange();
        }

        //取得刪除類別按鈕狀態
        public bool GetCategoryDeleteButtonStatus(int selectedIndex)
        {
            foreach (Meal meal in _order.OrderMealList)
            {
                if (meal.Category.ToString() == _categories[selectedIndex].CategoryName)
                {
                    return false;
                }
            }
            return true;
        }

        //修改MealList的Category
        private void SetMealListCategory(int selectIndex, Category category)
        {
            for (int i = 0; i < _mealList.Count; i++)
            {
                if (_mealList[i].Category.ToString() == _categories[selectIndex].CategoryName)
                {
                    _mealList[i].Category = category;
                }
            }
        }

        //取得SelectedIndex
        public int GetComboBoxIndex(int number)
        {
            for (int i = 0; i < CategoriesList.Count; i++)
            {
                if (MealsList[number].Category.ToString() == CategoriesList[i].CategoryName)
                {
                    return i;
                }
            }
            return 0;
        }

        //刪除餐點
        public void DeleteMeal(int number)
        {
            _mealList.RemoveAt(number);
            NotifyObserver();
        }

        //判斷是否選取的餐點在Order List裡面
        public bool IsMealInOrderList(int number)
        {
            foreach (Meal meal in _order.OrderMealList)
            {
                if (_mealList[number] == meal)
                {
                    return false;
                }
            }
            return true;
        }
    
        /// <summary>
        /// 開檔讀檔 並寫入mealList
        /// </summary>
        /// <returns></returns>
        public void ReadData(BindingList<Meal> mealList, BindingList<Category> categories)
        {
            StreamReader streamReader = new StreamReader(@"..\..\..\Data\MealData.txt");
            while (!streamReader.EndOfStream)
            {
                Meal meal = new Meal();
                meal._modelChanged += UpdateSubtotal;
                string Access = streamReader.ReadLine();
                string[] splitAccess = Access.Split(Constant.SPLIT_CONDITION);
                meal.MealName = splitAccess[0];
                meal.MealPrice = Int32.Parse(splitAccess[1]);
                for (int i = 0; i < categories.Count; i++)
                {
                    if (categories[i].CategoryName.Equals(splitAccess[Constant.MAX_SPLIT_NUMBER]))
                        meal.Category = categories[i];
                }
                mealList.Add(meal);
            }
            streamReader.Close();
        }

        public FormData FormData
        {
            get
            {
                return _formData;
            }
        }

        public BindingList<string> CategoryUsingList
        {
            get
            {
                return _categoryUsingList;
            }
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
            set
            {
                _order = value;
            }
        }

        //類別被更改
        private void NotifyCategoryChange()
        {
            if (_categoryChanged != null)
            {
                _categoryChanged();
            }
        }

        //Oberserve
        private void NotifyObserver()
        {
            if (_modelChanged != null)
                _modelChanged();
        }

        //呼叫更新Category
        private void NotifyCategory()
        {
            if (_orderListAdd != null)
                _orderListAdd();
        }
    }
}
