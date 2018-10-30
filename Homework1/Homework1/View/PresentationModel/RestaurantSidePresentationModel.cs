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
        public event PropertyChangedEventHandler PropertyChanged;
        private DataModel _dataModel = new DataModel();
        private BindingList<string> _mealListData = new BindingList<string>();
        private string _mealNameTextBoxData;
        private int _mealPriceTextBoxData;
        private string _mealImagePath;

        public RestaurantSidePresentationModel(DataModel dataModel)
        {
            _dataModel = dataModel;
        }

        public void GetMealManagerGroupBoxData(int number)
        {
            _mealNameTextBoxData = _dataModel.MealsList[number].MealName;
            _mealPriceTextBoxData = _dataModel.MealsList[number].MealPrice;
            _mealImagePath = _dataModel.MealsList[number].ImagePath;
            NotifyMealManagerGroupBox();
        }

        public void NotifyMealManagerGroupBox()
        {
            Notify(Constant.NOTIFY_MEAL_NAME_TEXT_BOX_DATA);
            Notify(Constant.NOTIFY_MEAL_PRICE_TEXT_BOX_DATA);
            Notify(Constant.NOTIFY_MEAL_IMAGE_PATH);
        }

        
    }
}
