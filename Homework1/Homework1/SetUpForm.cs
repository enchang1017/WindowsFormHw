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
    public partial class SetUpForm : Form
    {
        public SetUpForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 開啟FrontEnd 視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCustomerSideButton(object sender, EventArgs e)
        {
            Form form = new CustomerSide(new Model.FormData());
            _customerSideButton.Enabled = false;
            DialogResult dialogResult = form.ShowDialog(); 
            if (dialogResult == DialogResult.Cancel)
            {
                _customerSideButton.Enabled = true;
            }
        }

        /// <summary>
        /// 開啟BackEnd 視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickRestaurantSideButton(object sender, EventArgs e)
        {
            Form form = new RestaurantSide();
            _restaurantSideButton.Enabled = false;
            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
            {
                _restaurantSideButton.Enabled = true;
            }

        }

        /// <summary>
        /// 關閉程式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickExitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 設定Restaurant Button 狀態
        /// </summary>
        public void SetRestaurantSideButtonStatus()
        {
            _restaurantSideButton.Enabled = true;
        }

        /// <summary>
        /// 設定前端的按鈕狀態
        /// </summary>
        public void SetCustomerSideButtonStatus()
        {
            _customerSideButton.Enabled = true;
        }
    }
}
