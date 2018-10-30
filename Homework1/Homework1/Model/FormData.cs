using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Model
{
    public class FormData
    {
        const int MAX_BUTTON_NUMBER = 9;
        public FormData()
        {
            this.NowPage = 1;
            this.TotalPrice = 0;
        }
        /// <summary>
        /// 總頁數
        /// </summary>
        public int TotalPage
        {
            get;
            set;
        }
        /// <summary>
        /// 目前頁數
        /// </summary>
        public int NowPage
        {
            get;
            set;
        }
        /// <summary>
        /// 總價格
        /// </summary>
        public int TotalPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 設定下一頁按鈕是否Enable
        /// </summary>
        /// <returns></returns>
        public bool SetNextPageButtonEnable()
        {
            if (this.NowPage == this.TotalPage)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 計算總價
        /// </summary>
        /// <param name="formData"></param>
        public int SetTotalOrderListPrice(List<Meal> orderMeal)
        {
            TotalPrice = 0;
            foreach (Meal meal in orderMeal)
            {
                TotalPrice += meal.MealPrice;
            }
            return TotalPrice;
        }

        /// <summary>
        /// 取得PageLabelText
        /// </summary>
        /// <returns></returns>
        public string GetPageLabelText()
        {
            return Constant.PAGE_LABEL_TEXT_PAGE + this.NowPage + Constant.SLASH + this.TotalPage;
        }
    }
}
