using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsIntegrationTest.Controllers;
using System.Web.Mvc;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Should_Get_Index()
        {
            HomeController homeController = new HomeController();
            ViewResult result = homeController.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
