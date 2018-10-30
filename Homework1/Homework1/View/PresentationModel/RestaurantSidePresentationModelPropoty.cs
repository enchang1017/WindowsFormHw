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
        public string MealImagePath
        {
            get
            {
                return _mealImagePath;
            }
        }

        public string MealPriceTextBoxData
        {
            get
            {
                return _mealPriceTextBoxData.ToString();
            }
        }

        public string MealNameTextBoxData
        {
            get
            {
                return _mealNameTextBoxData;
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
