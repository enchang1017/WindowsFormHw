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
        private Model model;
        public Form1(Model model)
        {
            InitializeComponent();

            #region Label init
            _totalLabel.ForeColor = Color.Red;
            _totalLabel.AutoSize = false;
            this.model = model;

            #endregion

            #region Button init

            _addButton.Text = "Add";
            _nextPageButton.Text = "Next Page";
            _previousPageButton.Text = "Previous Page";

            _addButton.Width = 120;
            _nextPageButton.Width = 120;
            _previousPageButton.Width = 120;


            #endregion

            #region GroupBox

            _mealGroupBox.Text = "Meal";

            #endregion
        }


    }
}
