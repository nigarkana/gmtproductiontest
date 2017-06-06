using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTCutting_InputToSewingLineViewRecordSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Login Link, Menu-SubMenu Link, Job Code")]
        public void GivenLoginLinkMenu_SubMenuLinkJobCode()
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

            //Click Input to Sewing Line-> View Record
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[9]/li/ul[2]/li/a")).Click();
            Thread.Sleep(2000);

            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");
            Thread.Sleep(5000);

            //Click Search button
            driver.FindElement(By.Id("btnSearch")).Click();
            Thread.Sleep(10000);

           
        }

        [When(@"Click Search button, Click Edit Button, Change Issue Qty and update other information")]
        public void WhenClickSearchButtonClickEditButtonChangeIssueQtyAndUpdateOtherInformation()
        {
            //Click Edit button
            driver.FindElement(By.XPath("//*[@id='SewingIssueView']/td[8]/button")).Click();
            Thread.Sleep(15000);

            //Select Employee ID to issue
            SelectElement select = new SelectElement(driver.FindElement(By.Id("ddlEmployee")));
            select.SelectByText("Md. Monir Hossain_63 (02697)");
            Thread.Sleep(15000);

            ////Select Business Unit
            //SelectElement select0 = new SelectElement(driver.FindElement(By.Id("ddlBusinessUnit")));
            //select0.SelectByText("DCTL-1(1)");
            //Thread.Sleep(2000);

            ////Select Production Unit
            //SelectElement select1 = new SelectElement(driver.FindElement(By.Id("ddlProductionUnit")));
            //select1.SelectByText("Sewing>>Unit-1(000021)");
            //Thread.Sleep(2000);

            ////Select Production Line
            //SelectElement select2 = new SelectElement(driver.FindElement(By.Id("ddlProductionLine")));
            //select2.SelectByText("Line- E(000039)");
            //Thread.Sleep(2000);

            //Select 406303 Cutting Id Row 1 - Issue
            driver.FindElement(By.Id("issueQty_0")).Clear();
            driver.FindElement(By.Id("issueQty_0")).SendKeys("550");
            Thread.Sleep(2000);

            //Select 406304 Cutting Id Row 2- Issue
            driver.FindElement(By.Id("issueQty_1")).Clear();
            driver.FindElement(By.Id("issueQty_1")).SendKeys("550");
            Thread.Sleep(2000);

            //Select 406305 Cutting Id Row 3 - Issue
            driver.FindElement(By.Id("issueQty_2")).Clear();
            driver.FindElement(By.Id("issueQty_2")).SendKeys("550");
            Thread.Sleep(2000);

            //Select 406305 Cutting Id Row 4 - Issue
            driver.FindElement(By.Id("issueQty_3")).Clear();
            driver.FindElement(By.Id("issueQty_3")).SendKeys("550");
            Thread.Sleep(5000);

            // Click Issue button
            driver.FindElement(By.Id("btnIssue")).Click();
            Thread.Sleep(2000);
        }

        [Then(@"Sewing Line issue updated successfully")]
        public void ThenSewingLineIssueUpdatedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
