using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestProject1
{
    /// <summary>
    /// POSGUITest 的摘要說明
    /// </summary>
    [CodedUITest]
    public class POSGUITest
    {
        const string FILE_PATH = @"../../../Homework1/bin/Debug/Homework1.exe";
        private const string CALCULATOR_TITLE = "SetUpForm";
        private const string RESULT_CONTROL_NAME = "Monitor";

        public POSGUITest()
        {
        }

        /// <summary>
        /// Launches the Calculator
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, CALCULATOR_TITLE);
        }

        /// <summary>
        /// Closes the launched program
        /// </summary>
        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        [TestMethod]
        public void TestAdd()
        {
            RunCustomer();
        }

        [TestMethod]
        public void TestExit()
        {
            Robot.ClickButton("Exit");
        }

        [TestMethod]
        public void TestCloseCustomerForm()
        {
            Robot.ClickButton("Customer");
            Robot.SetWindow("POS-Customer Side");
            Robot.CloseWindow("CustomerSide", "POS-Customer Side");
        }

        [TestMethod]
        public void TestCloseRestaurantForm()
        {
            Robot.ClickButton("Restaurant");
            Robot.SetWindow("RestaurantSide");
            Robot.CloseWindow("RestaurantSide", "RestaurantSide");
        }

        [TestMethod]
        public void ClickTabPage()
        {
            Robot.ClickButton("Customer");
            Robot.SetWindow("POS-Customer Side");
            Robot.ClickTabControl("飲料");
            Robot.ClickButton("16");
            Robot.AssertEdit("descriptionBox", "100%純柳橙汁(非濃縮還原)\r");
        }

        [TestMethod]
        public void RestaurantMealList()
        {
            Robot.ClickButton("Restaurant");
            Robot.SetWindow("RestaurantSide");
            Robot.ClickListViewByValue("mealListBox", "洋蔥鮭魚");
            Robot.AssertEdit("mealName", "洋蔥鮭魚");
        }

        /// <summary>
        /// 修改Meal Name
        /// </summary>
        [TestMethod]
        public void RestaurantMealName()
        {
            Robot.ClickButton("Restaurant");
            Robot.SetWindow("RestaurantSide");
            Robot.ClickListViewByValue("mealListBox", "烤鯖魚押壽司");
            Robot.SetEdit("mealName", "asdf");
            Robot.ClickButton("mealSave");
            Robot.ClickListViewByValue("mealListBox", "洋蔥鮭魚");
            Robot.ClickListViewByValue("mealListBox", "asdf");
            Robot.AssertEdit("mealName","asdf");
        }

        /// <summary>
        /// 修改Meal Price
        /// </summary>
        [TestMethod]
        public void RestaurantMealPrice()
        {
            Robot.ClickButton("Restaurant");
            Robot.SetWindow("RestaurantSide");
            Robot.ClickListViewByValue("mealListBox", "烤鯖魚押壽司");
            Robot.SetEdit("mealPrice", "100");
            Robot.ClickButton("mealSave");
            Robot.ClickListViewByValue("mealListBox", "洋蔥鮭魚");
            Robot.ClickListViewByValue("mealListBox", "烤鯖魚押壽司");
            Robot.AssertEdit("mealPrice", "100");
        }

        /// <summary>
        /// 修改Meal description
        /// </summary>
        [TestMethod]
        public void RestaurantMealDescription()
        {
            Robot.ClickButton("Restaurant");
            Robot.SetWindow("RestaurantSide");
            Robot.ClickListViewByValue("mealListBox", "烤鯖魚押壽司");
            Robot.SetEdit("mealDescription", "asdasdasdas");
            Robot.ClickButton("mealSave");
            Robot.ClickListViewByValue("mealListBox", "洋蔥鮭魚");
            Robot.ClickListViewByValue("mealListBox", "烤鯖魚押壽司");
            Robot.AssertEdit("mealDescription", "asdasdasdas\r");
        }

        /// <summary>
        /// AddNewMeal
        /// </summary>
        [TestMethod]
        public void RestaurantMealAddNewMeal()
        {
            string[] fileName = { "0.png" };
            Robot.ClickButton("Restaurant");
            Robot.SetWindow("RestaurantSide");
            Robot.ClickButton("addMeal");
            Robot.SetEdit("mealName", "asdf");
            Robot.SetEdit("mealPrice", "100");
            Robot.SetComboBox("mealCategoryComboBox", "飲料");
            Robot.SetEdit("mealDescription", "asdasdasdas");         
            Robot.ClickButton("browseButton");
            Robot.SelectFileByOpenFileDialog("開啟", fileName);
            Robot.ClickButton("mealSave");
            Robot.ClickListViewByValue("mealListBox", "asdf");
            Robot.AssertEdit("mealName", "asdf");
        }

        /// <summary>
        /// Delete Meal
        /// </summary>
        [TestMethod]
        public void RestaurantMealDelete()
        { 
            Robot.ClickButton("Restaurant");
            Robot.SetWindow("RestaurantSide");
            Robot.ClickListViewByValue("mealListBox", "烤鯖魚押壽司");
            Robot.ClickButton("deleteMeal");
        }

        /// <summary>
        /// Qty
        /// </summary>
        [TestMethod]
        public void DataGridViewQty()
        {
            Robot.ClickButton("Customer");
            Robot.SetWindow("POS-Customer Side");
            Robot.ClickButton("0");
            Robot.ClickButton("addButton");
            Robot.SetDataGridViewQuantity("dataGridView", "1","3");
            Robot.ClickDataGridViewRowByIndex("dataGridView", "1");
            Robot.AssertText("totalPriceLabel", "Total : 120元");
        }

        /// <summary>
        /// Delete Meal
        /// </summary>
        [TestMethod]
        public void RestaurantCategory()
        {
            Robot.ClickButton("Restaurant");
            Robot.SetWindow("RestaurantSide");
            Robot.ClickTabControl("Category Manager");
            Robot.ClickButton("addCategory");
            Robot.SetEdit("categoryName","asdf");
            Robot.ClickButton("saveCategory");
            Robot.ClickListViewByValue("categoryListBox","飲料");
            Robot.SetEdit("categoryName", "aaaa");
            Robot.ClickButton("saveCategory");
            Robot.ClickListViewByValue("categoryListBox", "aaaa");
            Robot.ClickButton("deleteCategory");
            Robot.ClickListViewByValue("categoryListBox", "asdf");
            Robot.AssertEdit("categoryName", "asdf");
        }

        /// <summary>
        /// 修改Meal category
        /// </summary>
        [TestMethod]
        public void RestaurantMealCategory()
        {
            Robot.ClickButton("Restaurant");
            Robot.SetWindow("RestaurantSide");
            Robot.ClickListViewByValue("mealListBox", "烤鯖魚押壽司");
            Robot.SetComboBox("mealCategoryComboBox","飲料");
            Robot.ClickButton("mealSave");
            Robot.SetForm("StartUpForm", "SetUpForm");
            Robot.ClickButton("Customer");
            Robot.SetWindow("POS-Customer Side");
            Robot.ClickTabControl("飲料");
            Robot.ClickButton("0");
            Robot.AssertEdit("descriptionBox", "就是烤鯖魚押壽司，新鮮現烤鯖魚搭配剛出爐的飯，極度好吃!\r");
        }

        /// <summary>
        /// 跑Customer基本按鈕事件測試
        /// </summary>
        private void RunCustomer()
        {
            Robot.ClickButton("Customer");
            Robot.SetWindow("POS-Customer Side");
            Robot.ClickButton("nextPage");
            Robot.ClickButton("previousPage");
            Robot.ClickButton("0");
            Robot.ClickButton("addButton");
            Robot.DeleteDataGridViewRowByIndex("dataGridView","1");
            Robot.AssertEdit("descriptionBox", "就是烤鯖魚押壽司，新鮮現烤鯖魚搭配剛出爐的飯，極度好吃!\r");
        }

        /// <summary>
        /// 跑Restaurant基本按鈕事件測試
        /// </summary>
        private void RunRestaurant()
        {

        }
        private UIMap map;
    }
}
