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
        private int _tabPageIndex = 0;
        public CustomerSide(DataModel dataModel)
        { 
            InitializeComponent();
            _dataModel = dataModel;
            _dataModel.ModelChanged += UpdateView;
            _customerPresentationModel = new CustomerPresentationModel(_dataModel);
            GetTablePage();
            GetTabPagesButton(_categoryTabControl.SelectedTab);
            _totalLabel.DataBindings.Add(Constant.ITEM_TEXT, _customerPresentationModel, Constant.NOTIFY_TOTAL_PRICE);
            _pageLabel.DataBindings.Add(Constant.ITEM_TEXT, _customerPresentationModel, Constant.NOTIFY_PAGE_LABEL);
            _nextPageButton.DataBindings.Add(Constant.ITEM_ENABLE,_customerPresentationModel,Constant.NOTIFY_NEXT_PAGE);
            _previousPageButton.DataBindings.Add(Constant.ITEM_ENABLE,_customerPresentationModel,Constant.NOTIFY_PREVIOUS_PAGE);
            _addButton.DataBindings.Add(Constant.ITEM_ENABLE,_customerPresentationModel,Constant.NOTIFY_ADD_BUTTON);
        }

        /// <summary>
        /// 設定MealButton位置
        /// </summary>
        public void SetMealButtonLocation(int ButtonListCount)
        {
            for (int i = 0; i < ButtonListCount; i++)
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
        /// 取得TabPage頁面按鈕
        /// </summary>
        public void GetTabPagesButton(TabPage tabPage)
        {
            _mealButtonList.Clear();
            for (int i = 0; i < _dataModel.MealsList.Count; i++)
            {
                if (_dataModel.GetCurrentPage(tabPage.Text, i))
                {
                    SetMealButtonInitial(tabPage, i, new Button());
                }
            }
            SetMealButtonLocation(_mealButtonList.Count);
            SetMealButtonOption();
            _customerPresentationModel.SetTotalPage(_mealButtonList.Count);
        }

        /// <summary>
        /// 設定按鈕初始化
        /// </summary>
        public void SetMealButtonInitial(TabPage tabPage, int index, Button button)
        {
            button.Text = _customerPresentationModel.SetMealButtonText(index);
            button.Size = new Size(Constant.BUTTON_SIZE, Constant.BUTTON_SIZE);
            button.Name = index.ToString();
            button.Click += new EventHandler(this.MealButtonClick);
            button.Image = Image.FromFile(_dataModel.MealsList[index].ImagePath);
            button.TextAlign = ContentAlignment.BottomLeft;
            button.ForeColor = Color.White;
            _mealButtonList.Add(button);
            tabPage.Controls.Add(button);
        }

        /// <summary>
        /// 設定TabControl TabPages
        /// </summary>
        public void GetTablePage()
        {
            for (int i = 0; i < _dataModel.CategoriesList.Count; i++)
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = _dataModel.CategoriesList[i].CategoryName; 
                _categoryTabControl.TabPages.Add(tabPage);
            }
        }

        //更新頁面
        private void UpdateView()
        {
        }
    }
}
