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
    public partial class Form1 : Form
    {
        const int INITIAL_X = 6;
        const int INITIAL_Y = 21;
        const int SPACING = 179;
        const int MAX_ROW_NUMBER = 3;
        const int BUTTON_SIZE = 145;
        const string NAME = "Name";
        const string UNIT_PRICE = "Unit Price";
        const string DOLLARS = "元";
        const string INITIAL = "";
        private Homework1.Model.FormData _formData = new Model.FormData();
        private List<Button> _mealButtonList = new List<Button>();
        private Homework1.Model.Model _model = new Model.Model();
        private Homework1.Model.Meal _meal = new Model.Meal(INITIAL, 0);
        private DataTable _dataTable = new DataTable();
        public Form1(Homework1.Model.FormData formData)
        {
            InitializeComponent();
            _model.ReadFile(_formData);
            this._formData = formData;
            #region Meal Button init
            #region Create Button List
            for (int i = 0; i < _model.ReadFile(_formData).Count; i++)
            {
                _mealButtonList.Add(new Button());
                _mealGroupBox.Controls.Add(_mealButtonList[i]);
                _mealButtonList[i].Text = _model.SetMealButtonText(i,_formData);
                _mealButtonList[i].Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
                _mealButtonList[i].Name = i.ToString();
                _mealButtonList[i].Click += new EventHandler(this.MealButtonClick);
            }
            Homework1.View.Tools.MealButtonOption mealButtonOption = new View.Tools.MealButtonOption();
            SetMealButtonLocation(_model.ReadFile(_formData));
            #endregion
            SetMealButtonOption();
            SetPageButtonEnable();
            SetPageButtonEnable();
            #endregion
            _pageLabel.Text = _model.SetPageLabelText(_formData);
            _totalLabel.Text = _model.SetTotalPriceLabel(_formData);
            SetDataGridViewInitial();
        }
        /// <summary>
        /// 設定頁面按鈕狀態
        /// </summary>
        public void SetPageButtonEnable()
        {
            _nextPageButton.Enabled = _model.SetNextPageButtonEnable(_formData);
            if (_formData.nowPage == 1)
            {
                _previousPageButton.Enabled = false;
            }
            else
            {
                _previousPageButton.Enabled = true;
            }
        }

        /// <summary>
        /// 設定MealButton位置
        /// </summary>
        public void SetMealButtonLocation(List<Homework1.Model.Meal> mealList)
        {
            Homework1.View.Tools.MealButtonOption mealButtonOption = new View.Tools.MealButtonOption();
            for (int i = 0; i < mealList.Count; i++)
            {
                if (i % MAX_ROW_NUMBER == 0)
                {
                    _mealButtonList[i].Location = new System.Drawing.Point(INITIAL_X, INITIAL_Y + mealButtonOption.GetVariable(i));
                }
                else if (i % MAX_ROW_NUMBER == 1)
                {
                    _mealButtonList[i].Location = new System.Drawing.Point(INITIAL_X + SPACING, INITIAL_Y + mealButtonOption.GetVariable(i));
                }
                else
                {
                    _mealButtonList[i].Location = new System.Drawing.Point(INITIAL_X + SPACING + SPACING, INITIAL_Y + mealButtonOption.GetVariable(i));
                }
            }
        }

        /// <summary>
        /// 設定按鈕顯示
        /// </summary>
        public void SetMealButtonOption()
        {
            Homework1.View.Tools.MealButtonOption mealButtonOption = new View.Tools.MealButtonOption();
            for (int i = 0; i < _mealButtonList.Count; i++)
            {
                if (mealButtonOption.GetButtonOption(_mealButtonList.Count, i, _formData))
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
            _model.UpdateNowPage(_formData, _previousPageButton.Name);
            SetMealButtonOption();
            SetPageButtonEnable();
            SetPageButtonEnable();
            _pageLabel.Text = _model.SetPageLabelText(_formData);
        }

        /// <summary>
        /// 切換下一頁按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickNextPageButton(object sender, EventArgs e)
        {
            _model.UpdateNowPage(_formData, _nextPageButton.Name);
            SetMealButtonOption();
            SetPageButtonEnable();
            SetPageButtonEnable();
            _pageLabel.Text = _model.SetPageLabelText(_formData);
        }

        /// <summary>
        /// Meal Button 觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MealButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            _meal = _model.ReadFile(_formData)[Int32.Parse(button.Name)];
        }

        /// <summary>
        /// Add Button 觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            if (_model.GetOrderStatus(_meal))
            {
                _model.SetTotalPrice(_formData, _meal);
                _totalLabel.Text = _model.SetTotalPriceLabel(_formData);
                _orderDataGridView.Rows.Add(_meal._mealName, _meal._mealPrice);
                _meal = new Model.Meal(INITIAL,0);
            }
        }

        /// <summary>
        /// 設定DataGridView初始化
        /// </summary>
        private void SetDataGridViewInitial()
        {
            _orderDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _orderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
    }
}
