using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTCuttingInputToSewingLineSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Login, Menu-SubMenu, Job Code, Select Employee, Business Unit, Production Unit, Production Line, issue Qty")]
        public void GivenLoginMenu_SubMenuJobCodeSelectEmployeeBusinessUnitProductionUnitProductionLineIssueQty()
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

            //Click Input to Sewing Line
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[9]/li/a")).Click();
            Thread.Sleep(2000);

            //Click Input to Sewing Line-> Add Record
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[9]/li/ul[1]/li/a")).Click();
            Thread.Sleep(2000);

            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");
            Thread.Sleep(5000);

            //Press Enter
            driver.FindElement(By.Id("txtJobCode")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            //Select Employee ID to issue
            SelectElement select = new SelectElement(driver.FindElement(By.Id("ddlEmployee")));
            select.SelectByText("Rabeya Sultana_63 (04361)");
            Thread.Sleep(2000);

            //Select Business Unit
            SelectElement select0 = new SelectElement(driver.FindElement(By.Id("ddlBusinessUnit")));
            select0.SelectByText("DPGL-1(3)");
            Thread.Sleep(2000);

            //Select Production Unit
            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("ddlProductionUnit")));
            select1.SelectByText("Sewing>>Unit-1(000021)");
            Thread.Sleep(2000);

            //Select Production Line
            SelectElement select2 = new SelectElement(driver.FindElement(By.Id("ddlProductionLine")));
            select2.SelectByText("Line- E(000039)");
            Thread.Sleep(2000);

            //Select 406303 Cutting Id Row 2 - Issue
            driver.FindElement(By.Id("issueQty_1")).SendKeys("1");         
            Thread.Sleep(2000);

            //Select 406304 Cutting Id Row 3 - Issue
            driver.FindElement(By.Id("issueQty_2")).SendKeys("1");
            Thread.Sleep(2000);

            //Select 406305 Cutting Id Row 4 - Issue
            driver.FindElement(By.Id("issueQty_3")).SendKeys("1");
            Thread.Sleep(2000);


        }
        
        [When(@"Press Enter, click Save to issue")]
        public void WhenPressEnterClickSaveToIssue()
        {
            //Click Issue Button
            driver.FindElement(By.Id("btnIssue")).Click();
            Thread.Sleep(2000);

        }
    }
}
