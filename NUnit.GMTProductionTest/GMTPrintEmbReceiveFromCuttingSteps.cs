using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTPrintEmbReceiveFromCuttingSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Job Code")]
        public void GivenJobCode()
        {
            //CommonItem c = new CommonItem();
            //c.login();
            //Thread.Sleep(5000);


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

            //Click Print/Emb
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[5]/a")).Click();
            Thread.Sleep(5000);

            //Receive from Cutting
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[5]/ul[1]/li/a")).Click();
            Thread.Sleep(15000);

            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");
            Thread.Sleep(10000);
        }

        
        [When(@"Click View")]
        public void WhenClickView()
        {
            //Click View
            Thread.Sleep(5000);
            driver.FindElement(By.Id("btnView")).Click();
        }

        [When(@"click Row for expand or collapse, Check and select the row, Click Receive")]
        public void WhenClickRowForExpandOrCollapseCheckAndSelectTheRowClickReceive()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.Id("cbk_44715")).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.Id("btnReceiveSelected")).Click();
            Thread.Sleep(2000);
        }


       
        
       
    }
}
