using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTPrintEmbDeliveryToCuttingAddRecordSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Login Information, Menu Link and other information")]
        public void GivenLoginInformationMenuLinkAndOtherInformation()
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

            //Click Print/Emb
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[5]/a")).Click();
            Thread.Sleep(5000);

            //Click Delivery to Cutting
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[5]/ul[2]/li/a")).Click();
            Thread.Sleep(2000);

            //Click Add Record
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[5]/ul[2]/li/ul[1]/li/a")).Click();
            Thread.Sleep(2000);
        }
        
        [When(@"Enter Job Code and press ENTER from keyboard, enter value of QC Pass, Reject, Remarks and click Save")]
        public void WhenEnterJobCodeAndPressENTERFromKeyboardEnterValueOfQCPassRejectRemarksAndClickSave()
        {
            //Enter Job Code
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");

            //Press Enter
            Thread.Sleep(5000);
            driver.FindElement(By.Id("txtJobCode")).SendKeys(Keys.Enter);

            //Enter 1st Row
            //Press QC Pass Qty
            Thread.Sleep(5000);
            driver.FindElement(By.Id("txtQcPassQty_0")).SendKeys("1");
            //Enter Reject Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRejectQty_0")).SendKeys("0");
            //Enter Remarks
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks_0")).SendKeys("This is Automation Test.");



            //Enter 2nd Row
            //Press QC Pass Qty
            Thread.Sleep(5000);
            driver.FindElement(By.Id("txtQcPassQty_1")).SendKeys("1");
            //Enter Reject Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRejectQty_1")).SendKeys("0");
            //Enter Remarks
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks_1")).SendKeys("This is Automation Test.");

            //Enter 3rd Row
            //Press QC Pass Qty
            Thread.Sleep(5000);
            driver.FindElement(By.Id("txtQcPassQty_2")).SendKeys("1");
            //Enter Reject Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRejectQty_2")).SendKeys("0");
            //Enter Remarks
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks_2")).SendKeys("This is Automation Test.");

            //Enter 4th Row
            //Press QC Pass Qty
            Thread.Sleep(5000);
            driver.FindElement(By.Id("txtQcPassQty_3")).SendKeys("1");
            //Enter Reject Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRejectQty_3")).SendKeys("0");
            //Enter Remarks
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks_3")).SendKeys("This is Automation Test.");

            //Enter fifth Row
            //Press QC Pass Qty
            Thread.Sleep(5000);
            driver.FindElement(By.Id("txtQcPassQty_4")).SendKeys("1");
            //Enter Reject Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRejectQty_4")).SendKeys("0");
            //Enter Remarks
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks_4")).SendKeys("This is Automation Test.");

            //Click Save button
            Thread.Sleep(2000);
            driver.FindElement(By.Id("btnSave")).Click();


        }
        
        [Then(@"Information saved successfully")]
        public void ThenInformationSavedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
