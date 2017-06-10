using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit.GMTProductionTest
{
    public class CommonItem
    {
        IWebDriver driver = new ChromeDriver();
        public void login()
        {
            driver.Navigate().GoToUrl("http://172.16.1.63/gmtProduction");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);


            //For User Name 
            driver.FindElement(By.Id("UserName")).SendKeys("nigar");

            //For Password
            driver.FindElement(By.Id("Password")).SendKeys("dms3534");

            //Click Login Button
            driver.FindElement(By.Id("loginBtn")).Click();

            Thread.Sleep(5000);
            
            Thread.Sleep(5000);
        }

        internal void login(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }
}
