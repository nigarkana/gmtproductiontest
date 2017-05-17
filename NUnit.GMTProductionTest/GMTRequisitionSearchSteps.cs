using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

            //Click Fabric Menu
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[3]/a")).Click();
            Thread.Sleep(2000);

            //Click Requisition SubMenu
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[3]/ul[1]/li/a")).Click();

            Thread.Sleep(5000);

            //Enter Job Code in the search text box
            driver.FindElement(By.Id("txtJobCodeExt")).SendKeys("9836");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtJobCodeExt")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            SelectElement select = new SelectElement(driver.FindElement(By.Id("ddlFabReqId")));
            select.SelectByText("34725 ");
            Thread.Sleep(2000);

            //Click Search button
            driver.FindElement(By.Id("btnSearch")).Click();

            //Test for invalid requisition
            //Click Clear Button
            driver.FindElement(By.Id("btnClear")).Click();

            //Enter wrong Requisition Id in the Search Text
            driver.FindElement(By.Id("txtFabReqId")).SendKeys("34788");



        }
        
        [When(@"press Enter All requisition is displayed according to the Job Code and select one of the requisition")]
        public void WhenPressEnterAllRequisitionIsDisplayedAccordingToTheJobCodeAndSelectOneOfTheRequisition()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Result should be shown according to the search")]
        public void ThenResultShouldBeShownAccordingToTheSearch()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
