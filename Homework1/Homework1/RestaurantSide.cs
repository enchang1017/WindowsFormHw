using Homework1.Model;
using Homework1.View.PresentationModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private int _nowSelectedIndex;
        public RestaurantSide(DataModel dataModel)
        {
            InitializeComponent();
            _dataModel = dataModel;
            _dataModel._orderListAdd += UpdateCategoryDelete;
            _restaurantSidePresentationModel = new RestaurantSidePresentationModel(_dataModel);
            _mealListBox.DataSource = _dataModel.MealsList;
            _mealCategoryComboBox.DataSource = _dataModel.CategoriesList;
            _mealCategoryComboBox.DisplayMember = Constant.CATEGORY_NAME;
            GetMealGroupBoxData();
            _categoryListBox.DataSource = _dataModel.CategoriesList;
            _categoryListBox.DisplayMember = Constant.CATEGORY_NAME;
            GetCategoryGroupData();
            _usingCategoryListBox.DataSource = _dataModel.CategoryUsingList;
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            _openFileDialog.InitialDirectory = projectPath;
            _openFileDialog.Multiselect = false;
            _openFileDialog.Filter = @"Image|*.png;*.jpg;*.jpeg";
            _mealCategoryComboBox.SelectedIndex = _dataModel.GetComboBoxIndex(_mealListBox.SelectedIndex);
            _mealSaveButton.DataBindings.Add(Constant.ITEM_ENABLE,_restaurantSidePresentationModel,Constant.NOTIFY_SAVE_BUTTON_ENABLE);
            _categorySaveButton.DataBindings.Add(Constant.ITEM_ENABLE,_restaurantSidePresentationModel,Constant.NOTIFY_SAVE_CATEGORY);
            _mealSaveButton.DataBindings.Add(Constant.ITEM_TEXT, _restaurantSidePresentationModel, Constant.NOTIFY_MEAL_SAVE);
            _categorySaveButton.DataBindings.Add(Constant.ITEM_TEXT,_restaurantSidePresentationModel, Constant.NOTIFY_CATEGORY_SAVE);
            this._mealListBox.SelectedIndexChanged += new System.EventHandler(this.SelectChangedEventMealListBox);
            this._categoryListBox.SelectedIndexChanged += new EventHandler(this.SelectChangedEventCategory);
            this._mealNameTextBox.TextChanged += new EventHandler(this.ChangeMealManagerTextBoxText);
            this._mealPriceTextBox.TextChanged += new EventHandler(this.ChangeMealManagerTextBoxText);
            this._mealPathTextBox.TextChanged += new EventHandler(this.ChangeMealManagerTextBoxText);
            this._descriptionRichTextBox.TextChanged += new EventHandler(this.ChangeDescriptionText);
            this._categoryNameTextBox.TextChanged += new EventHandler(this.ChangeCategoryName);
            _deleteMealButton.Enabled = _dataModel.IsMealInOrderList(_mealListBox.SelectedIndex);
        }

        //判斷CategoeyDeleteButton
        public bool IsCategoryDeleteButtonEnable()
        {
            if (_dataModel.GetCategoryNameInList(_categoryListBox.SelectedIndex).Count != 0)
                return false;
            return true;
        }

        //取得using darasource
        public bool GetCategoryUsingList()
        {
            _usingCategoryListBox.DataSource = _dataModel.GetCategoryNameInList(_categoryListBox.SelectedIndex);
            return IsCategoryDeleteButtonEnable();
        }

        //讀取類別名稱
        public void GetCategoryGroupData()
        {
            _categoryNameTextBox.Text = _dataModel.CategoriesList[_categoryListBox.SelectedIndex].CategoryName;
        }

        /// <summary>
        /// 取得MealGroupBox資料
        /// </summary>
        public void GetMealGroupBoxData()
        {
            if (_mealListBox.SelectedIndex != -1)
            {
                _mealNameTextBox.Text = _dataModel.MealsList[_mealListBox.SelectedIndex].MealName;
                _mealPriceTextBox.Text = _dataModel.MealsList[_mealListBox.SelectedIndex].MealPrice.ToString();
                _mealPathTextBox.Text = _dataModel.MealsList[_mealListBox.SelectedIndex].ImagePath;
                _descriptionRichTextBox.Text = _dataModel.MealsList[_mealListBox.SelectedIndex].MealDescription;
                _mealCategoryComboBox.SelectedIndex = _dataModel.GetComboBoxIndex(_mealListBox.SelectedIndex);
            }
        }

        //清除MealGroupBox
        private void ClearMealGroupBox()
        {
            _mealNameTextBox.Clear();
            _mealPriceTextBox.Clear();
            _mealPathTextBox.Clear();
            _descriptionRichTextBox.Clear();
        }

        private BindingManagerBase BindingManagerBase
        {
            get
            {
                return BindingContext[_dataModel.MealsList];
            }
        }

        private BindingManagerBase BindingManagerBaseCategory
        {
            get
            {
                return BindingContext[_dataModel.CategoriesList];
            }
        }

        //更新CategoryDelete按鈕
        private void UpdateCategoryDelete()
        {
            _deleteCategoryButton.Enabled = _dataModel.GetCategoryDeleteButtonStatus(_categoryListBox.SelectedIndex);
        }
    }
}
