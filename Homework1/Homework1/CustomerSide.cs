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
        private List<Button> _mealButtonList = new List<Button>();
        private CustomerPresentationModel _customerPresentationModel;
        private DataModel _dataModel = new DataModel();
        public CustomerSide(DataModel dataModel)
        {
            
            InitializeComponent();
            _dataModel = dataModel;
            _customerPresentationModel = new CustomerPresentationModel(_dataModel);
            _dataModel = _customerPresentationModel.GetDataModelInstance(); 
            _customerPresentationModel.GetMealList();
            _customerPresentationModel.SetTotalPage();
            #region Meal Button init
            #region Create Button List
            for (int i = 0; i < _customerPresentationModel.GetMealList().Count; i++)
            {
                _mealButtonList.Add(new Button());
                _mealGroupBox.Controls.Add(_mealButtonList[i]);
                _mealButtonList[i].Text = _customerPresentationModel.SetMealButtonText(i);
                _mealButtonList[i].Size = new Size(Constant.BUTTON_SIZE, Constant.BUTTON_SIZE);
                _mealButtonList[i].Name = i.ToString();
                _mealButtonList[i].Click += new EventHandler(this.MealButtonClick);
                _mealButtonList[i].Image = Image.FromFile(_dataModel.ReadFile()[i].ImagePath);
                _mealButtonList[i].TextAlign = ContentAlignment.BottomLeft;
                _mealButtonList[i].ForeColor = Color.White;
            }
            MealButtonOption mealButtonOption = new MealButtonOption();
            SetMealButtonLocation(_customerPresentationModel.GetMealList());
            #endregion
            SetMealButtonOption();
            SetPageButtonEnable();
            SetPageButtonEnable();
            #endregion
            _pageLabel.Text = _customerPresentationModel.GetPageLabelText();
            this._orderDataGridView.AllowUserToAddRows = false;
            _addButton.Enabled = false;
            _totalLabel.DataBindings.Add(Constant.ITEM_TEXT, _customerPresentationModel, Constant.NOTIFY_TOTAL_PRICE);
        }
        /// <summary>
        /// 設定頁面按鈕狀態
        /// </summary>
        public void SetPageButtonEnable()
        {
            _nextPageButton.Enabled = _customerPresentationModel.IsNextPageButtonEnable();
            _previousPageButton.Enabled = _customerPresentationModel.SetPreviousPageButtonStatus();
        }

        /// <summary>
        /// 設定MealButton位置
        /// </summary>
        public void SetMealButtonLocation(List<Homework1.Model.Meal> mealList)
        {
            for (int i = 0; i < mealList.Count; i++)
            {
                _mealButtonList[i].Location = _customerPresentationModel.SetMealButtonLocation(i);
            }
        }

        /// <summary>
        /// 設定按鈕顯示
        /// </summary>
        public void SetMealButtonOption()
        {
            for (int i = 0; i < _mealButtonList.Count; i++)
            {
                if (_customerPresentationModel.GetButtonOption(_mealButtonList.Count, i))
                {
                    _mealButtonList[i].Visible = true;
                    _mealButtonList[i].Enabled = true;
                }
                else
                {
                    _mealButtonList[i].Visible = false;
                    _mealButtonList[i].Enabled = false;
                }
            }
        }

        /// <summary>
        /// 切換上一頁按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickPreviousPageButton(object sender, EventArgs e)
        {
            _customerPresentationModel.UpdateNowPage(_previousPageButton.Name);
            SetMealButtonOption();
            SetPageButtonEnable();
            _pageLabel.Text = _customerPresentationModel.GetPageLabelText();
            _addButton.Enabled = false;
            _dataModel.SetSelectedMeal(new Meal(Constant.INITIAL, 0));
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
            SetPageButtonEnable();
            _pageLabel.Text = _customerPresentationModel.GetPageLabelText();
            _dataModel.SetSelectedMeal(new Meal(Constant.INITIAL, 0));
            _addButton.Enabled = false;
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
            _dataModel.SetSelectedMeal(_customerPresentationModel.GetMealList()[Int32.Parse(button.Name)]);
            _mealDescriptionBox.Text = _dataModel.GetSelectedMeal().MealDescription;
            _addButton.Enabled = true;
        }

        /// <summary>
        /// Add Button 觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            _orderDataGridView.Rows.Add(Constant.DELETE, _dataModel.GetSelectedMeal().MealName, _dataModel.GetSelectedMeal().MealPrice);
            _dataModel.GetOrderList().Add(_dataModel.GetSelectedMeal());
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

            if (senderGrid.Columns[e.ColumnIndex] == _deleteButton)
            {
                _orderDataGridView.Rows.Remove(_orderDataGridView.Rows[e.RowIndex]);
                _dataModel.GetOrderList().RemoveAt(e.RowIndex);
                _customerPresentationModel.SetTotalPrice();
            }
        }

    }
}
