﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateHybridTestFrameworkInterfaceContracts.NonHybridVersion.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace CreateHybridTestFrameworkInterfaceContracts.NonHybridVersion
{
    [TestClass]
    public class BingTests
    {
        private BingMainPage bingMainPage;
        private IWebDriver driver;

        [TestInitialize]
        public void SetupTest()
        {
            this.driver = new FirefoxDriver();
            this.bingMainPage = new BingMainPage(this.driver);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.driver.Quit();
        }

        [TestMethod]
        public void SearchForAutomateThePlanet()
        {
            this.bingMainPage.Open();
            this.bingMainPage.Search("Automate The Planet");
            this.bingMainPage.AssertResultsCountIsAsExpected(264);
        }
    }
}
