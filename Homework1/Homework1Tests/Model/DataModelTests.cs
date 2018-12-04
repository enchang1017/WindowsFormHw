using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Homework1.Model.Tests
{
    [TestClass()]
    public class DataModelTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            DataModel dataModel = new DataModel();
        }


        [TestMethod()]
        public void DeleteCategoryTest()
        {
            DataModel dataModel = new DataModel();

            dataModel.DeleteCategory(2);
            Assert.AreEqual(dataModel.MealsList[0].Category.ToString(), "壽司");
            dataModel.DeleteCategory(1);
            Assert.AreEqual(dataModel.MealsList[0].Category.ToString(), "壽司");

        }

        [TestMethod()]
        public void GetCategoryDeleteButtonStatusTest()
        {
            DataModel dataModel = new DataModel();
            BindingList<Meal> ordeMeal = new BindingList<Meal>();
            Meal meal = new Meal();
            Meal meal1 = new Meal();
            Category category = new Category()
            {
                CategoryName = "甜點"
            };
            Category category2 = new Category()
            {
                CategoryName = "壽司"
            };
            meal.Category = category;
            meal1.Category = category2;
            ordeMeal.Add(meal);
            ordeMeal.Add(meal1);
            Assert.IsTrue(dataModel.GetCategoryDeleteButtonStatus(0));
            dataModel.GetOrder.OrderMealList = ordeMeal;
            Assert.IsFalse(dataModel.GetCategoryDeleteButtonStatus(0));
        }

        [TestMethod()]
        public void GetComboBoxIndexTest()
        {
            DataModel dataModel = new DataModel();
            Assert.AreEqual(dataModel.GetComboBoxIndex(0), 0);
            Meal meal = new Meal();
            Category category = new Category();
            category.CategoryName = "手捲";
            meal.Category = category;
            dataModel.MealsList.Add(meal);
            Assert.AreEqual(dataModel.GetComboBoxIndex(27), 0);
        }

        [TestMethod()]
        public void DeleteMealTest()
        {
            DataModel dataModel = new DataModel();
            int count = dataModel.MealsList.Count;
            dataModel.DeleteMeal(0);
            Assert.AreEqual(dataModel.MealsList.Count, count - 1);
        }

        [TestMethod()]
        public void IsMealInOrderListTest()
        {
            DataModel dataModel = new DataModel();
            Order order = new Order();
            order.OrderMealList.Add(dataModel.MealsList[0]);
            dataModel.GetOrder = order;
            Assert.IsTrue(dataModel.IsMealInOrderList(1));
            Assert.IsFalse(dataModel.IsMealInOrderList(0));
        }

        [TestMethod()]
        public void SetSelectedMealTest()
        {
            DataModel dataModel = new DataModel();
            dataModel.SetSelectedMeal(-999);
            Assert.AreEqual(dataModel.GetOrder.SelectedMeal.MealName, null);
            dataModel.SetSelectedMeal(0);
            Assert.AreEqual(dataModel.GetOrder.SelectedMeal, dataModel.MealsList[0]);
        }

        [TestMethod()]
        public void AddOrderListTest()
        {
            DataModel dataModel = new DataModel();
            int count = dataModel.GetOrder.OrderMealList.Count;
            Meal meal = new Meal();
            meal.ImagePath = "123";
            dataModel.GetOrder.OrderMealList.Add(meal);
            Assert.AreEqual(dataModel.GetOrder.OrderMealList.Count, count + 1);
            Assert.AreEqual(dataModel.GetOrder.OrderMealList[count].ImagePath, @"..\..\..123");
        }

        [TestMethod()]
        public void CombineButtonTextTest()
        {
            DataModel dataModel = new DataModel();
            Assert.AreEqual(dataModel.CombineButtonText(0), "烤鯖魚押壽司" + Constant.WRAP + "$40元");
        }

        [TestMethod()]
        public void SetTotalPageTest()
        {
            DataModel dataModel = new DataModel();
            dataModel.SetTotalPage(10);
            Assert.AreEqual(dataModel.FormData.TotalPage, 2);
        }

        [TestMethod()]
        public void SetTotalPriceTest()
        {
            DataModel dataModel = new DataModel();
            Meal meal = new Meal()
            {
                MealPrice = 100,
                Quantity = 2,
                ImagePath = "123"
            };
            int subTotal = meal.Subtotal;
            int quantity = meal.Quantity;
            string delete = meal.Delete;
            dataModel.GetOrder.OrderMealList.Add(meal);
            dataModel.SetTotalPrice();
            Assert.AreEqual(dataModel.FormData.TotalPrice, 200);
            Assert.AreEqual(dataModel.GetOrder.OrderMealList[0].Subtotal, 200);
        }

        [TestMethod()]
        public void GetCurrentPageTest()
        {
            DataModel dataModel = new DataModel();
            Assert.IsFalse(dataModel.GetCurrentPage("壽司", 20));
            Assert.IsTrue(dataModel.GetCurrentPage("壽司", 0));
        }

        [TestMethod()]
        public void CheckMealInOrderListTest()
        {
            DataModel dataModel = new DataModel();
            Meal meal = new Meal()
            {
                MealName = "東坡肉"
            };
            dataModel.GetOrder.OrderMealList.Add(meal);
            Assert.IsTrue(dataModel.IsMealInOrderList());
            dataModel.GetOrder.SelectedMeal = meal;
            Assert.IsFalse(dataModel.IsMealInOrderList());
        }

        [TestMethod()]
        public void GetCategoryNameInListTest()
        {
            DataModel dataModel = new DataModel();
            dataModel.GetCategoryNameInList(0);
            Assert.AreEqual(dataModel.CategoryUsingList.Count, 15);
        }

        [TestMethod()]
        public void ChangeCategoryNameTest()
        {
            DataModel dataModel = new DataModel();
            dataModel.ChangeCategoryName("手卷", 0);
            Assert.AreEqual(dataModel.CategoriesList[0].CategoryName, "手卷");
        }

        [TestMethod()]
        public void AddCategoryTest()
        {
            DataModel dataModel = new DataModel();
            int count = dataModel.CategoriesList.Count;
            dataModel.AddCategory("手卷");
            Assert.AreEqual(dataModel.CategoriesList.Count, count + 1);
        }

        [TestMethod()]
        public void AddOrderListTest1()
        {
            DataModel dataModel = new DataModel();
            int count = dataModel.GetOrder.OrderMealList.Count;
            dataModel.GetOrder.SelectedMeal = new Meal();
            dataModel.AddOrderList();

            Assert.AreEqual(dataModel.GetOrder.OrderMealList.Count, count + 1);
        }

        [TestMethod()]
        public void AddNewMealTest()
        {
            DataModel dataModel = new DataModel();
            string[] mealInformation = {"鮭魚手卷", "100", "123", "壽司", "好吃" };
            int count = dataModel.MealsList.Count;
            dataModel.AddNewMeal(mealInformation);
            Assert.AreEqual(dataModel.MealsList.Count, count+1);
        }

    }
}