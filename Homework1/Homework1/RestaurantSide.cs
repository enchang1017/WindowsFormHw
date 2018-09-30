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
        private SetUpForm _setUpForm = new SetUpForm(); 
        public RestaurantSide(SetUpForm setUpForm)
        {
            InitializeComponent();
            _setUpForm = setUpForm;
        }

        /// <summary>
        /// 按下OK按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCheckButton(object sender, EventArgs e)
        {
            _setUpForm.SetRestaurantSideButtonStatus();
            this.Close();
        }

        /// <summary>
        /// 複寫右上角X按鈕，開啟SetUpForm按鈕狀態
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            _setUpForm.SetRestaurantSideButtonStatus();
        }
    }
}
