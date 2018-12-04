using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Model.Tests
{
    [TestClass()]
    public class FormDataTests
    {
        [TestMethod()]
        public void GetPageLabelTextTest()
        {
            FormData formData = new FormData();
            formData.NowPage = 1;
            formData.TotalPage = 3;
            Assert.AreEqual(formData.GetPageLabelText(), "Page:1/3");
        }

        [TestMethod()]
        public void SetNextPageButtonEnableTest()
        {
            FormData formData = new FormData();
            formData.NowPage = 1;
            formData.TotalPage = 2;
            Assert.IsTrue(formData.SetNextPageButtonEnable());
            formData.NowPage = 2;
            Assert.IsFalse(formData.SetNextPageButtonEnable());
        }
    }
}