using System;
using System.Collections.Generic;
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
            this.nowPage = 1;
            this.totalPrice = 0;
        }
        /// <summary>
        /// 總頁數
        /// </summary>
        public int totalPage
        {
            get;
            set;
        }
        /// <summary>
        /// 目前頁數
        /// </summary>
        public int nowPage
        {
            get;
            set;
        }
        /// <summary>
        /// 總價格
        /// </summary>
        public int totalPrice
        {
            get;
            set;
        }

    }
}
