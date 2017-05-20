using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTRequisitionSearchSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Job Code in the search field")]
        public void GivenJobCodeInTheSearchField()
        {
            LoginGMTProduction();

            NavigateToFabricRequisitionPage();

            //Enter Job Code in the search text box
            driver.FindElement(By.Id("txtJobCodeExt")).SendKeys("9836");
            Thread.Sleep(2000);







            //Test for invalid requisition
            //Click Clear Button
            //driver.FindElement(By.Id("btnClear")).Click();

            //Enter wrong Requisition Id in the Search Text
            // driver.FindElement(By.Id("txtFabReqId")).SendKeys("34788");



        }

        private void NavigateToFabricRequisitionPage()
        {
            //Click Fabric Menu
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[3]/a")).Click();
            Thread.Sleep(2000);

            //Click Requisition SubMenu
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[3]/ul[1]/li/a")).Click();

            Thread.Sleep(5000);
        }

        private void LoginGMTProduction()
        {
            driver.Navigate().GoToUrl("http://172.16.1.63/gmtproduction");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);

            //Enter username 
            driver.FindElement(By.Id("UserName")).SendKeys("nigar");

            //Enter Password
            Thread.Sleep(2000);
            driver.FindElement(By.Id("Password")).SendKeys("d123");

            //Click Login Button
            Thread.Sleep(2000);
            driver.FindElement(By.Id("loginBtn")).Click();
            Thread.Sleep(2000);
        }

        [When(@"press Enter")]
        public void WhenPressEnter()
        {
            driver.FindElement(By.Id("txtJobCodeExt")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
        }

        [When(@"Requisition ID is selected")]
        public void WhenRequisitionIDIsSelected()
        {
            SelectElement select = new SelectElement(driver.FindElement(By.Id("ddlFabReqId")));
            select.SelectByText("34719 ");
        }

        [When(@"click Search button")]
        public void WhenClickSearchButton()
        {

            //Click Search button
            driver.FindElement(By.Id("btnSearch")).Click();
        }

        [Then(@"Information is displayed according to Requisition ID")]
        public void ThenInformationIsDisplayedAccordingToRequisitionID()
        {
            Thread.Sleep(3000);
            Assert.AreEqual("J0000009836", driver.FindElement(By.XPath("//*[@id='fabRequisitionRow']/td[3]")).Text);
            Thread.Sleep(3000);
            Assert.AreEqual("Single Jersey( 02371)", driver.FindElement(By.XPath("//*[@id='fabRequisitionRow']/td[6]")).Text);
            Thread.Sleep(3000);
            Assert.AreEqual("White( 00034)", driver.FindElement(By.XPath("//*[@id='fabRequisitionRow']/td[9]")).Text);
            Thread.Sleep(3000);
            Assert.AreEqual("10", driver.FindElement(By.Id("txtReqQty0")).GetAttribute("value"));

            //Chrome Close
            driver.Close();
        }

        [Given(@"Requisition ID")]
        public void GivenRequisitionID()
        {
            LoginGMTProduction();

            NavigateToFabricRequisitionPage();


            Thread.Sleep(5000);
            driver.FindElement(By.Id("txtFabReqId")).SendKeys("34719");

        }
        
    }
}
