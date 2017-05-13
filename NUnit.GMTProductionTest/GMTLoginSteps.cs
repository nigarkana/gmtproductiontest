using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTLoginSteps
        
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"I have entered User Name")]
        public void GivenIHaveEnteredUserName()
        {
            driver.Navigate().GoToUrl("http://172.16.1.63/gmtProduction");
            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            driver.FindElement(By.Id("UserName")).SendKeys("nigar");

            //Thread.Sleep(5000);
        }
        
        [Given(@"I have entered Password")]
        public void GivenIHaveEnteredPassword()
        {
            driver.FindElement(By.Id("Password")).SendKeys("d123");

            //Thread.Sleep(5000);
        }
        
        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            driver.FindElement(By.Id("loginBtn")).Click();
        }
       
        [Then(@"Dashboard has shown after user logged in successfully")]
        public void ThenDashboardHasShownAfterUserLoggedInSuccessfully()
        {
            Thread.Sleep(10000);

            Assert.AreEqual("Hello Nigar", driver.FindElement(By.XPath("//*[@id='header']/nav/div[2]/ul/li[2]")).Text);
        }
    }
}
