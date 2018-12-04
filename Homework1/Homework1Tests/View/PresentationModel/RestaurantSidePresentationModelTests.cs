using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework1.View.PresentationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.View.PresentationModel.Tests
{
    [TestClass()]
    public class RestaurantSidePresentationModelTests
    {
        Model.DataModel dataModel;
        RestaurantSidePresentationModel restaurantSidePresentationModel;
        [TestInitialize()]
        public void TestInitialize()
        {
            dataModel = new Model.DataModel();
            restaurantSidePresentationModel = new RestaurantSidePresentationModel(dataModel);
            restaurantSidePresentationModel.PropertyChanged += RestaurantSidePresentationModel_PropertyChanged;
            string categoryButton = restaurantSidePresentationModel.CategorySaveButtonText;
            string mealButton = restaurantSidePresentationModel.MealSaveButtonText;
            restaurantSidePresentationModel.MealSaveButtonText = Model.Constant.ADD;
            restaurantSidePresentationModel.CategorySaveButtonText = Model.Constant.ADD;
        }

        [TestMethod()]
        public void ChangeDescriptionTest()
        {
            restaurantSidePresentationModel.ChangeDescription();
            Assert.AreEqual(restaurantSidePresentationModel.IsMealSaveButtonEnable, true);
        }

        [TestMethod()]
        public void ChangeCategoryTextBoxTextTest()
        {
            restaurantSidePresentationModel.ChangeCategoryTextBoxText("");
            Assert.IsFalse(restaurantSidePresentationModel.IsCategorySaveButtonEnable);
            restaurantSidePresentationModel.ChangeCategoryTextBoxText("壽司");
            Assert.IsTrue(restaurantSidePresentationModel.IsCategorySaveButtonEnable);
        }
        private void RestaurantSidePresentationModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        [TestMethod()]
        public void ChangeTextBoxTextTest()
        {
            bool saveButton = restaurantSidePresentationModel.IsMealSaveButtonEnable;
            string[] text = { "壽司", "123", "壽司", "123", "好吃" };
            restaurantSidePresentationModel.ChangeTextBoxText(text);
            Assert.IsTrue(restaurantSidePresentationModel.IsMealSaveButtonEnable);
            string[] text1 = { "", "123", "壽司", "123", "" };
            restaurantSidePresentationModel.ChangeTextBoxText(text1);
            Assert.IsFalse(restaurantSidePresentationModel.IsMealSaveButtonEnable);

        }

        [TestMethod()]
        public void GetCategoryManagerGroupBoxTest()
        {
            restaurantSidePresentationModel.GetCategoryManagerGroupBox();
            Assert.IsFalse(restaurantSidePresentationModel.IsMealSaveButtonEnable);
        }

        
    }
}