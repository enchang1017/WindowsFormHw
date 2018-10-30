using Homework1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.View.PresentationModel
{
    public class MealButtonOption
    {
        /// <summary>
        /// 取得Y的變量
        /// </summary>
        /// <param name="index">i的序號</param>
        /// <returns></returns>
        public int GetVariable(int index)
        {
            if ((index / Constant.MAX_ROW_NUMBER) % Constant.MAX_ROW_NUMBER == 0)
            {
                return 0;
            }
            else if ((index / Constant.MAX_ROW_NUMBER) % Constant.MAX_ROW_NUMBER == 1)
            {
                return Constant.SPACING;
            }
            else
            {
                return Constant.SPACING + Constant.SPACING;
            }
        }

        /// <summary>
        /// 取得按鈕是否存在
        /// </summary>
        /// <param name="totalButtonNumber">按鈕總數</param>
        /// <param name="mealButtonIndex">按鈕序號</param>
        /// <param name="formData">ViewModel</param>
        /// <returns></returns>
        public bool GetButtonOption(int totalButtonNumber, int mealButtonIndex, FormData formData)
        {
            if (mealButtonIndex / Constant.MAX_MEAL_BUTTON_NUMBER == formData.NowPage - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
