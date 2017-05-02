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

            driver.FindElement(By.Id("txtUsername")).SendKeys("nadim");

            //Thread.Sleep(5000);
        }
        
        [Given(@"I have entered Password")]
        public void GivenIHaveEnteredPassword()
        {
            driver.FindElement(By.Id("txtPassword")).SendKeys("dms9842");

            //Thread.Sleep(5000);
        }
        
        [When(@"I click Login")]
        public void WhenIClickLogin()
        {
            driver.FindElement(By.Id("btnLogin")).Click();
        }
       
        [Then(@"Dashboard has shown after user logged in successfully")]
        public void ThenDashboardHasShownAfterUserLoggedInSuccessfully()
        {
            Thread.Sleep(10000);

            Assert.AreEqual("Md. Nadim Saker (41118)", driver.FindElement(By.Id("lblUsername")).Text);
        }
    }
}
