using Homework1.Model;
using Homework1.View.PresentationModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class RestaurantSide : Form
    {
        private RestaurantSidePresentationModel _restaurantSidePresentationModel;
        private DataModel _dataModel;
        public RestaurantSide(DataModel dataModel)
        {
            InitializeComponent();
            _dataModel = dataModel;
            _restaurantSidePresentationModel = new RestaurantSidePresentationModel(_dataModel);
            
            _mealListBox.DataSource = _dataModel.MealsList;
            _mealListBox.DisplayMember = Constant.MEAL_NAME;
            _mealNeamTextBox.DataBindings.Add(Constant.ITEM_TEXT,_restaurantSidePresentationModel,Constant.NOTIFY_MEAL_NAME_TEXT_BOX_DATA);
            _mealPriceTextBox.DataBindings.Add(Constant.ITEM_TEXT,_restaurantSidePresentationModel,Constant.NOTIFY_MEAL_PRICE_TEXT_BOX_DATA);
            _mealPathTextBox.DataBindings.Add(Constant.ITEM_TEXT,_restaurantSidePresentationModel,Constant.NOTIFY_MEAL_IMAGE_PATH);
        }

        private void SelectedChangedEventMealListBox(object sender, EventArgs e)
        {
            _restaurantSidePresentationModel.GetMealManagerGroupBoxData(_mealListBox.SelectedIndex);
        }

        

        private BindingManagerBase BindingManagerBase
        {
            get
            {
                return BindingContext[_dataModel.MealsList];
            }
        }
    }
}
