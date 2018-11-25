using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Model
{
    public class Meal : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();
        private int _subtotal;
        private Category _category = new Category();
        private int _quantity;
        private string _mealName;
        private int _mealPrice;
        private string _description;
        public Meal()
        {
            this._quantity = 1;
            this._subtotal = MealPrice * _quantity;
        }
        public string Delete
        {
            get
            {
                return Constant.DELETE;
            }
        }
        /// <summary>
        /// 菜名
        /// </summary>
        public string MealName
        {
            get
            {
                return _mealName;
            }
            set
            {
                if (value != _mealName)
                {
                    _mealName = value;
                    NotifyObserver();
                    NotifyPropertyChanged(nameof(MealName));
                }
            }
        }

        /// <summary>
        /// 價格
        /// </summary>
        public int MealPrice
        {
            get
            {
                return _mealPrice;
            }
            set
            {
                if (value != _mealPrice)
                {
                    _mealPrice = value;
                    SetSubtotal();
                    NotifyObserver();
                }
            }
        }

        /// <summary>
        /// 菜單簡介
        /// </summary>
        public string MealDescription
        {
            get
            {
                return _description;
            }
            set
            {
                if (value != _description)
                {
                    _description = value;
                    NotifyObserver();
                }
            }
        }

        /// <summary>
        /// 圖片路徑
        /// </summary>
        public string ImagePath
        {
            get;
            set;
        }

        /// <summary>
        /// 餐點類別
        /// </summary>
        public object Category
        {
            get
            {
                return _category.CategoryName;
            }
            set
            {
                if (value != _category)
                {
                    _category = (Category)value;
                    NotifyObserver();
                    NotifyPropertyChanged(nameof(Category));
                }
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value != _quantity)
                {
                    _quantity = value;
                    SetSubtotal();
                }
            }
        }

        public int Subtotal
        {
            get
            {
                return _subtotal;
            }
            set
            {
                if (value != _subtotal)
                {
                    _subtotal = value;
                    NotifyObserver();
                }
            }
        }

        //Oberserve
        private void NotifyObserver()
        {
            if (_modelChanged != null)
                _modelChanged();
        }

        /// <summary>
        /// 計算Subtotal
        /// </summary>
        private void SetSubtotal()
        {
            this.Subtotal = _quantity * this.MealPrice;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
