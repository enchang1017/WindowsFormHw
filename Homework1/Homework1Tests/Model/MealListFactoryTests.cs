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
    public class MealListFactoryTests
    {
        [TestMethod()]
        public void SetMealDescriptionTest()
        {
            MealListFactory mealListFactory = new MealListFactory();
            DataModel dataModel = new DataModel();
            mealListFactory.SetMealDescription(dataModel.MealsList);
            Assert.AreEqual(dataModel.MealsList[0].MealDescription, "就是烤鯖魚押壽司，新鮮現烤鯖魚搭配剛出爐的飯，極度好吃!");
        }
    }
}