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
        //敘述欄位輸入事件
        private void ChangeDescriptionText(object sender, EventArgs e)
        {
            _restaurantSidePresentationModel.ChangeDescription();
        }

        /// <summary>
        /// MealListBox 選取變更
        /// </summary>
        private void SelectChangedEventMealListBox(object sender, EventArgs e)
        {
            if (_mealListBox.SelectedIndex != -1)
            {
                GetMealGroupBoxData();
                _nowSelectedIndex = _mealListBox.SelectedIndex;
                _deleteMealButton.Enabled = _dataModel.IsMealInOrderList(_mealListBox.SelectedIndex);
                _restaurantSidePresentationModel.MealSaveButtonText = Constant.SAVE;
                _mealSaveButton.Enabled = false;
                _editMealGroupBox.Text = Constant.EDIT_MEAL;
            }
        }

        /// <summary>
        /// 類別表單切換
        /// </summary>
        private void SelectChangedEventCategory(object sender, EventArgs e)
        {
            if (_categoryListBox.SelectedIndex != -1)
            {
                GetCategoryGroupData();
                _categorySaveButton.Enabled = false;
            }
        }

        /// <summary>
        /// 類別名稱TextChanged事件
        /// </summary>
        private void ChangeCategoryName(object sender, EventArgs e)
        {
            _restaurantSidePresentationModel.ChangeCategoryTextBoxText(_categoryNameTextBox.Text);
        }

        /// <summary>
        /// TextBox更改Text
        /// </summary>
        private void ChangeMealManagerTextBoxText(object sender, EventArgs e)
        {
            string[] text = { _mealNameTextBox.Text, _mealPriceTextBox.Text, _mealPathTextBox.Text, _mealCategoryComboBox.Text };
            _restaurantSidePresentationModel.ChangeTextBoxText(text);
        }

        /// <summary>
        /// CategoryListBox 選取變更
        /// </summary>
        private void SelectChangedEventCategoryListBox(object sender, EventArgs e)
        {
            if (_categoryListBox.SelectedIndex != -1)
            {
                _restaurantSidePresentationModel.GetCategoryManagerGroupBox();
                _deleteCategoryButton.Enabled = GetCategoryUsingList();
                _restaurantSidePresentationModel.CategorySaveButtonText = Constant.SAVE;
                _categorySaveButton.Enabled = false;
                _deleteCategoryButton.Enabled = _dataModel.GetCategoryDeleteButtonStatus(_categoryListBox.SelectedIndex);
                _editCategoryGroupBox.Text = Constant.EDIT_CATEGORY;
            }
            else
            {
                _dataModel.CategoryUsingList.Clear();
            }
        }

        //SaveButton 事件
        private void ClickMealSaveButton(object sender, EventArgs e)
        {
            _mealSaveButton.Enabled = false;
            if (_mealListBox.SelectedIndex == -1)
            {
                string[] text = { _mealNameTextBox.Text, _mealPriceTextBox.Text, _mealPathTextBox.Text, _mealCategoryComboBox.Text, _descriptionRichTextBox.Text };
                _dataModel.AddNewMeal(text);
            }
            else
            {
                _dataModel.MealsList[_nowSelectedIndex].MealName = _mealNameTextBox.Text;
                _dataModel.MealsList[_nowSelectedIndex].MealPrice = Int32.Parse(_mealPriceTextBox.Text);
                _dataModel.MealsList[_nowSelectedIndex].ImagePath = _mealPathTextBox.Text;
                _dataModel.MealsList[_nowSelectedIndex].MealDescription = _descriptionRichTextBox.Text;
                _dataModel.MealsList[_nowSelectedIndex].Category = _mealCategoryComboBox.SelectedItem;
            }
            _dataModel.GetCategoryNameInList(_categoryListBox.SelectedIndex);
        }

        //瀏覽檔案路徑
        private void BrowseImageFile(object sender, EventArgs e)
        {
            DialogResult result = _openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _mealPathTextBox.Text = _openFileDialog.FileName.Replace(Application.StartupPath.Replace(Constant.REPLACE_PATH, Constant.INITIAL), Constant.INITIAL);
            }
        }

        //新增Meal按鈕是件
        private void ClickAddNewMealButton(object sender, EventArgs e)
        {
            ClearMealGroupBox(); 
            _mealListBox.SelectedIndex = -1;
            _deleteMealButton.Enabled = false;
            _restaurantSidePresentationModel.MealSaveButtonText = Constant.ADD;
            _mealSaveButton.Enabled = false;
            _editMealGroupBox.Text = Constant.ADD_MEAL;
        }

        //刪除餐點觸發是件
        private void ClickDeleteMealButton(object sender, EventArgs e)
        {
            _dataModel.DeleteMeal(_mealListBox.SelectedIndex);
            GetMealGroupBoxData();
        }

        //新增類別事件
        private void ClickAddCategoryButton(object sender, EventArgs e)
        {
            _restaurantSidePresentationModel.CategorySaveButtonText = Constant.ADD;
            _categoryListBox.SelectedIndex = -1;
            _categoryNameTextBox.Clear();
            _categorySaveButton.Enabled = false;
            _editCategoryGroupBox.Text = Constant.ADD_CATEGORY;
        }

        //刪除類別事件
        private void ClickDeleteCategoryButton(object sender, EventArgs e)
        {
            _dataModel.DeleteCategory(_categoryListBox.SelectedIndex);
            _restaurantSidePresentationModel.GetCategoryManagerGroupBox();
        }

        //類別Save
        private void ClickCategorySaveButton(object sender, EventArgs e)
        {
            if (_restaurantSidePresentationModel.CategorySaveButtonText == Constant.SAVE)
            {
                _dataModel.ChangeCategoryName(_categoryNameTextBox.Text, _categoryListBox.SelectedIndex);
            }
            else
            {
                _dataModel.AddCategory(_categoryNameTextBox.Text);
                _restaurantSidePresentationModel.CategorySaveButtonText = Constant.SAVE;
            }
        }

        /// <summary>
        /// 判斷Price Text Box是否輸入為數字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PressKeyPriceTextBox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }
}
