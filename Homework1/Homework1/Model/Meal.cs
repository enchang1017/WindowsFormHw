﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Model
{
    public class Meal
    {
        public Meal(string mealName , int mealPrice)
        {
            this._mealName = mealName;
            this._mealPrice = mealPrice;
        }
        /// <summary>
        /// 菜名
        /// </summary>
        public string _mealName
        {
            get;
            set;
        }

        /// <summary>
        /// 價格
        /// </summary>
        public int _mealPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 菜單簡介
        /// </summary>
        public string _mealDescription
        {
            get;
            set;
        }

        /// <summary>
        /// 判斷是否為初始化
        /// </summary>
        /// <param name="meal"></param>
        /// <returns></returns>
        public bool IsMealInitial(Meal meal)
        {
            if (meal._mealName == Constant.INITIAL && meal._mealPrice == 0)
            {
                return false;
            }
            return true;
        }
    }
}
