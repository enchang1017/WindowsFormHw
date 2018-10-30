using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Model
{
    public class Meal
    {
        private int _subtotal;
        public Meal()
        {
            this.Quantity = 1;
        }
        /// <summary>
        /// 菜名
        /// </summary>
        public string MealName
        {
            get;
            set;
        }

        /// <summary>
        /// 價格
        /// </summary>
        public int MealPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 菜單簡介
        /// </summary>
        public string MealDescription
        {
            get;
            set;
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
        public Category Category
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public int Subtotal
        {
            get
            {
                _subtotal = this.Quantity * this.MealPrice;
                return _subtotal;
            }
        }

    }
}
