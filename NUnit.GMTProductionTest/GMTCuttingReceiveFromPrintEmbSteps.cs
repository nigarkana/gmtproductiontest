using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTCuttingReceiveFromPrintEmbSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Login, Menu link, Job Code")]
        public void GivenLoginMenuLinkJobCode()
        {
            driver.Navigate().GoToUrl("http://172.16.1.63/gmtProduction");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);


            //For User Name 
            driver.FindElement(By.Id("UserName")).SendKeys("nigar");
            Thread.Sleep(2000);
            //For Password
            driver.FindElement(By.Id("Password")).SendKeys("dms3534");
            Thread.Sleep(2000);
            //Click Login Button
            driver.FindElement(By.Id("loginBtn")).Click();

            Thread.Sleep(5000);

            //Click Cutting
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/a")).Click();
            Thread.Sleep(5000);

            //Click Receive from Print/Emb
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[5]/li/a")).Click();
            Thread.Sleep(2000);

            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");
            Thread.Sleep(5000);

        }

        [When(@"press View, Check select Option, click Receive")]
        public void WhenPressViewCheckSelectOptionClickReceive()
        {
            //Click View
            driver.FindElement(By.Id("btnView")).Click();
            Thread.Sleep(10000);

            //Click Select option
            driver.FindElement(By.Id("cbk_47639")).Click();
            Thread.Sleep(5000);

            //Click Receive
            driver.FindElement(By.Id("btnReceive")).Click();
            Thread.Sleep(10000);




        }
        
        [Then(@"Receive from Print/Emb saved successfully")]
        public void ThenReceiveFromPrintEmbSavedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
