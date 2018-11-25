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
    public partial class RestaurantSidePresentationModel : INotifyPropertyChanged
    {
        public string CategorySaveButtonText
        {
            get
            {
                return _categorySaveButtonText;
            }
            set
            {
                _categorySaveButtonText = value;
                Notify(Constant.NOTIFY_CATEGORY_SAVE);
            }
        }

        public string MealSaveButtonText
        {
            get
            {
                return _mealSaveButtonText;
            }
            set
            {
                _mealSaveButtonText = value;
                Notify(Constant.NOTIFY_MEAL_SAVE);
            }
        }

        public bool IsCategorySaveButtonEnable
        {
            get
            {
                if (_isCategoryButtonEnable)
                    return true;
                return false;
            }
        }

        public bool IsMealSaveButtonEnable
        {
            get
            {
                if (_isMealSaveButtonEnable)
                    return true;
                return false;
            }
        }

        //呼叫更改屬性
        private void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
