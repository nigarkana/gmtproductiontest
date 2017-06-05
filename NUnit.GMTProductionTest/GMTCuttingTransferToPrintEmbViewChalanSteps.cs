using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTCuttingTransferToPrintEmbViewChalanSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"URL, User Name, Password, Menu Link, SubMenuLink, Job Code enter")]
        public void GivenURLUserNamePasswordMenuLinkSubMenuLinkJobCodeEnter()
        {
            //driver.Navigate().GoToUrl("http://172.16.1.63/gmtProduction");
            //driver.Manage().Window.Maximize();
            //Thread.Sleep(5000);


            ////For User Name 
            //driver.FindElement(By.Id("UserName")).SendKeys("nigar");

            ////For Password
            //driver.FindElement(By.Id("Password")).SendKeys("dms3534");

            ////Click Login Button
            //driver.FindElement(By.Id("loginBtn")).Click();
            CommonItem c = new CommonItem();
            c.login();

            Thread.Sleep(10000);

            //Click Cutting Menu
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/a")).Click();
            Thread.Sleep(2000);

            //Transfer to Prinit/Emb
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[7]/li/a")).Click();
            Thread.Sleep(2000);

            //Click View Record
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[7]/li/ul[2]/li/a")).Click();
            Thread.Sleep(2000);

            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");

            //Click Search
            Thread.Sleep(1000);
            driver.FindElement(By.Id("btnSearch")).Click();
            

        }

        [When(@"Clicking View Challan")]
        public void WhenClickingViewChallan()
        {
            //Click View Challan to view the Challan
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='SendEmbPrintView']/td[9]/button")).Click();
            Thread.Sleep(1000);
        }
        
        [Then(@"Challan is opened in another tab")]
        public void ThenChallanIsOpenedInAnotherTab()
        {
            //Assert with New Tab
            Thread.Sleep(3000);
            Assert.AreEqual("Cutting To Print/Emb Challan", driver.FindElement(By.Id("//*[@id='P9199f70ac5cf422db96e7aabd1e691d5_1_oReportCell']/table/tbody/tr[2]/td/table/tbody/tr/td/table/tbody/tr[2]/td[3]/table/tbody/tr/td/div")).Text);
        }
    }
}
