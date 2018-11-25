using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework1.Model;
using Homework1.View.PresentationModel;

namespace Homework1
{
    public partial class CustomerSide : Form
    {
        /// <summary>
        /// 切換上一頁按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickPreviousPageButton(object sender, EventArgs e)
        {
            _customerPresentationModel.UpdateNowPage(_previousPageButton.Name);
            SetMealButtonOption();
            _addButton.Enabled = false;
            _dataModel.SetSelectedMeal(Constant.SELECTED_MEAL_INITIAL);
            _mealDescriptionBox.Text = _dataModel.GetOrder.SelectedMeal.MealDescription;
        }

        /// <summary>
        /// 切換下一頁按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickNextPageButton(object sender, EventArgs e)
        {
            _customerPresentationModel.UpdateNowPage(_nextPageButton.Name);
            SetMealButtonOption();
            _dataModel.SetSelectedMeal(Constant.SELECTED_MEAL_INITIAL);
            _customerPresentationModel.GetAddButtonOption(false);
            _mealDescriptionBox.Text = _dataModel.GetOrder.SelectedMeal.MealDescription;
        }

        /// <summary>
        /// Meal Button 觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MealButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            _dataModel.SetSelectedMeal(Int32.Parse(button.Name));
            _mealDescriptionBox.Text = _dataModel.MealsList[Int32.Parse(button.Name)].MealDescription;
            _customerPresentationModel.GetAddButtonOption(true);
        }

        /// <summary>
        /// Add Button 觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            _dataModel.AddOrderList();
            _customerPresentationModel.GetAddButtonOption(false);
            _customerPresentationModel.SetTotalPrice();
        }

        /// <summary>
        /// DataGridView Delete Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] == _deleteColumns)
            {
                _dataModel.GetOrder.OrderMealList.RemoveAt(e.RowIndex);
                _customerPresentationModel.SetTotalPrice();
            }
        }

        /// <summary>
        /// TabControl 切換頁面事件
        /// </summary>
        private void ClickMealTabPage(object sender, EventArgs e)
        {  
            _dataModel.SetSelectedMeal(Constant.SELECTED_MEAL_INITIAL);
            _mealDescriptionBox.Text = _dataModel.GetOrder.SelectedMeal.MealDescription;
            _customerPresentationModel.GetAddButtonOption(false);
            _dataModel.FormData.NowPage = 1;
            TabControl tabControl = (TabControl)sender;
            RefreshTabPageButton(tabControl);
        }

        /// <summary>
        /// Qty被更改時 呼叫事件
        /// </summary>
        private void ChangeRowData(object sender, DataGridViewCellEventArgs e)
        {
            if (_orderDataGridView.Columns[e.ColumnIndex] == _quantityDataGridViewTextBoxColumn)
            {
                _dataModel.GetOrder.OrderMealList[e.RowIndex].Quantity = (int)(_orderDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
        }
    }
}
