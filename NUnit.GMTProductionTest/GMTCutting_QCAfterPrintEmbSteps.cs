using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTCutting_QCAfterPrintEmbSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Login, Menu Link, Job Code and press enter")]
        public void GivenLoginMenuLinkJobCodeAndPressEnter()
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

            //Click QC after Print/Emb
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[6]/li/a")).Click();
            Thread.Sleep(2000);

            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");
            Thread.Sleep(5000);

            //Press Enter
            driver.FindElement(By.Id("txtJobCode")).SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }
        
        [When(@"click on row, enter QC pass, reject, remarks, click Select option and Save")]
        public void WhenClickOnRowEnterQCPassRejectRemarksClickSelectOptionAndSave()
        {
            //Click on the row to expand
            driver.FindElement(By.XPath("//*[@id='1']/td[1]")).Click();
            Thread.Sleep(3000);

            //Click on the row to collapse
            driver.FindElement(By.XPath("//*[@id='1']/td[1]")).Click();
            Thread.Sleep(3000);

            //Click on Select option
            driver.FindElement(By.Id("cbk_47639")).Click();
            Thread.Sleep(2000);

            //Click Receive"
            driver.FindElement(By.Id("btnSave")).Click();
            Thread.Sleep(2000);

            //Every QC Pass Qty
            ////For 1st Row
            ////Clear QC Pass Qty
            //driver.FindElement(By.Id("txtQcPassQty1")).Clear();
            //Thread.Sleep(2000);
            ////Enter QC Pass Qty
            //driver.FindElement(By.Id("txtQcPassQty1")).SendKeys("1");
            //Thread.Sleep(2000);
            ////Enter Reject Qty
            //driver.FindElement(By.Id("txtRejectQty1")).SendKeys("0");
            //Thread.Sleep(2000);
            ////Enter Remarks
            //driver.FindElement(By.Id("txtRemarks1")).SendKeys("This is Automation Test");
            //Thread.Sleep(2000);

            ////For 2nd Row
            ////Clear QC Pass Qty
            //driver.FindElement(By.Id("txtQcPassQty2")).Clear();
            //Thread.Sleep(2000);
            ////Enter QC Pass Qty
            //driver.FindElement(By.Id("txtQcPassQty2")).SendKeys("1");
            //Thread.Sleep(2000);
            ////Enter Reject Qty
            //driver.FindElement(By.Id("txtRejectQty2")).SendKeys("0");
            //Thread.Sleep(2000);
            ////Enter Remarks
            //driver.FindElement(By.Id("txtRemarks2")).SendKeys("This is Automation Test");
            //Thread.Sleep(2000);

            ////For 3rd Row
            ////Clear QC Pass Qty
            //driver.FindElement(By.Id("txtQcPassQty3")).Clear();
            //Thread.Sleep(2000);
            ////Enter QC Pass Qty
            //driver.FindElement(By.Id("txtQcPassQty3")).SendKeys("1");
            //Thread.Sleep(2000);
            ////Enter Reject Qty
            //driver.FindElement(By.Id("txtRejectQty3")).SendKeys("0");
            //Thread.Sleep(2000);
            ////Enter Remarks
            //driver.FindElement(By.Id("txtRemarks3")).SendKeys("This is Automation Test");
            //Thread.Sleep(2000);

            ////For 4th Row
            ////Clear QC Pass Qty
            //driver.FindElement(By.Id("txtQcPassQty4")).Clear();
            //Thread.Sleep(2000);
            ////Enter QC Pass Qty
            //driver.FindElement(By.Id("txtQcPassQty4")).SendKeys("1");
            //Thread.Sleep(2000);
            ////Enter Reject Qty
            //driver.FindElement(By.Id("txtRejectQty4")).SendKeys("0");
            //Thread.Sleep(2000);
            ////Enter Remarks
            //driver.FindElement(By.Id("txtRemarks4")).SendKeys("This is Automation Test");
            //Thread.Sleep(2000);

        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
