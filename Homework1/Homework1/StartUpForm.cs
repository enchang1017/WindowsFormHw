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
    public partial class StartUpForm : Form
    {
        private Form _customerSide = new CustomerSide();
        private Form _restaurantSide = new RestaurantSide();
        public StartUpForm()
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
            
            _customerSideButton.Enabled = false;
            _customerSide.Show();
            _customerSide.FormClosing += OverrideCustomerFormClosing;
        }

        /// <summary>
        /// 開啟BackEnd 視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickRestaurantSideButton(object sender, EventArgs e)
        {

            _restaurantSide.Show();
            _restaurantSideButton.Enabled = false;
            _restaurantSide.FormClosing += OverrideRestaurantFormClosing;
        }

        /// <summary>
        /// 關閉程式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickExitButton(object sender, EventArgs e)
        {
            _customerSide.Close();
            _restaurantSide.Close();
            this.Close();
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

        /// <summary>
        /// 設定CustomerSide Form 關閉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OverrideCustomerFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _customerSide.Hide();
            SetCustomerSideButtonStatus();
        }

        /// <summary>
        /// 設定Restaurant side form 關閉事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OverrideRestaurantFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            _restaurantSide.Hide();
            SetRestaurantSideButtonStatus();
        }
    }
}
