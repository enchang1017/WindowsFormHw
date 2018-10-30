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
            _mealDescriptionBox.Text = _dataModel.GetSelectedMeal().MealDescription;
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
            _mealDescriptionBox.Text = _dataModel.GetSelectedMeal().MealDescription;
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
            _mealDescriptionBox.Text = _dataModel.GetSelectedMeal().MealDescription;
            _customerPresentationModel.GetAddButtonOption(true);
        }

        /// <summary>
        /// Add Button 觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            _orderDataGridView.Rows.Add(Constant.DELETE, _dataModel.GetOrder.SelectedMeal.MealName, _dataModel.GetOrder.SelectedMeal.Category.CategoryName,
                _dataModel.GetOrder.SelectedMeal.MealPrice, _dataModel.GetOrder.SelectedMeal.Quantity,_dataModel.GetOrder.SelectedMeal.Subtotal);
            _dataModel.GetOrderList().Add(_dataModel.GetSelectedMeal());
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
            Console.WriteLine(e.RowIndex);
            Console.WriteLine(e.ColumnIndex);
            if (senderGrid.Columns[e.ColumnIndex] == _deleteButton)
            {
                _orderDataGridView.Rows.Remove(_orderDataGridView.Rows[e.RowIndex]);
                _dataModel.GetOrderList().RemoveAt(e.RowIndex);
                _customerPresentationModel.SetTotalPrice();
            }

            if (_orderDataGridView.Columns[e.ColumnIndex] == _quantity)
            {
                Console.WriteLine(e.RowIndex);
                Console.WriteLine(e.ColumnIndex);
            }
        }

        /// <summary>
        /// TabControl 切換頁面事件
        /// </summary>
        private void ClickMealTabPage(object sender, EventArgs e)
        {
            _dataModel.GetFormDataInstance().NowPage = 1;
            TabControl tabControl = (TabControl)sender;
            tabControl.TabPages[_tabPageIndex].Controls.Clear();
            GetTabPagesButton(tabControl.SelectedTab); 
            _tabPageIndex = tabControl.TabPages.IndexOf(tabControl.SelectedTab);
        }

        private void ChangeRowData(object sender, DataGridViewCellEventArgs e)
        {
            if (_orderDataGridView.Columns[e.ColumnIndex] == _quantity)
            {
                Console.WriteLine(e.RowIndex);
                Console.WriteLine(e.ColumnIndex);
            }
        }
    }
}
