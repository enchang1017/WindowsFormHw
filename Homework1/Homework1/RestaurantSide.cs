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
    }
}
