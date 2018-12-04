using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework1.View.PresentationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Homework1.View.PresentationModel.Tests
{
    [TestClass()]
    public class CustomerPresentationModelTests
    {
        Model.DataModel dataModel;
        CustomerPresentationModel customerPresentationModel;
        [TestInitialize()]
        public void TestInitialize()
        {
            dataModel = new Model.DataModel();
            customerPresentationModel = new CustomerPresentationModel(dataModel);
            customerPresentationModel.PropertyChanged += CustomerSidePresentationModel_PropertyChanged;
            string totalPrice = customerPresentationModel.TotalPrice;
        }

        [TestMethod()]
        public void UpdateNowPageTest()
        {
            customerPresentationModel.UpdateNowPage(Model.Constant.NEXT_BUTTON);
            dataModel.FormData.TotalPage = 2;
            Assert.IsFalse(customerPresentationModel.IsNextPageEnable);
            Assert.IsTrue(customerPresentationModel.IsPreviousPageEnable);
            Assert.AreEqual(dataModel.FormData.NowPage, 2);
            Assert.AreEqual(customerPresentationModel.PageLabel, "Page:2/2");
            customerPresentationModel.UpdateNowPage("123");
            Assert.IsTrue(customerPresentationModel.IsNextPageEnable);
            Assert.IsFalse(customerPresentationModel.IsPreviousPageEnable);
            Assert.AreEqual(dataModel.FormData.NowPage, 1);
        }

        [TestMethod()]
        public void SetTotalPageTest()
        {
            customerPresentationModel.SetTotalPage(15);
            Assert.AreEqual(dataModel.FormData.TotalPage, 2);
        }

        [TestMethod()]
        public void GetButtonOptionTest()
        {
            Assert.IsTrue(customerPresentationModel.GetButtonOption(15, 1));
            Assert.IsFalse(customerPresentationModel.GetButtonOption(15, 14));
        }

        [TestMethod()]
        public void SetTotalPriceTest()
        {
            Model.Meal meal = new Model.Meal()
            {
                MealPrice = 100
            };
            dataModel.GetOrder.OrderMealList.Add(meal);
            customerPresentationModel.SetTotalPrice();
            Assert.AreEqual(dataModel.FormData.TotalPrice, 100);
        }

        [TestMethod()]
        public void SetMealButtonLocationTest()
        {
            Assert.AreEqual(customerPresentationModel.SetMealButtonLocation(0), new Point(11, 11));
            Assert.AreEqual(customerPresentationModel.SetMealButtonLocation(1), new Point(174, 11));
            Assert.AreEqual(customerPresentationModel.SetMealButtonLocation(2), new Point(337, 11));
            Assert.AreEqual(customerPresentationModel.SetMealButtonLocation(3), new Point(11, 174));
            Assert.AreEqual(customerPresentationModel.SetMealButtonLocation(6), new Point(11, 337));
        }

        [TestMethod()]
        public void GetAddButtonOptionTest()
        {
            customerPresentationModel.GetAddButtonOption(false);
            Assert.AreEqual(customerPresentationModel.IsAddButtonEnable, false);
            customerPresentationModel.GetAddButtonOption(true);
            Assert.AreEqual(customerPresentationModel.IsAddButtonEnable, true);
        }

        private void CustomerSidePresentationModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}