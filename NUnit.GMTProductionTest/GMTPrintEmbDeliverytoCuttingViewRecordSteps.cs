using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTPrintEmbDeliverytoCuttingViewRecordSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Login, Menu, SubMenu link, Job Code")]
        public void GivenLoginMenuSubMenuLinkJobCode()
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

            //Click View Record
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[5]/ul[2]/li/ul[2]/li/a")).Click();
            Thread.Sleep(2000);

            //Enter Job Code
            driver.FindElement(By.Id("jobCode")).SendKeys("9836");
            Thread.Sleep(5000);


        }
        
        [When(@"Click Search, Edit, Enter QC Pass, Reject, Remarks from Edit Mode")]
        public void WhenClickSearchEditEnterQCPassRejectRemarksFromEditMode()
        {
            //Click Search Button
            driver.FindElement(By.Id("btnSearch")).Click();
            Thread.Sleep(5000);

            //Click Edit Button
            driver.FindElement(By.XPath("//*[@id='SendEmbPrintView']/td[7]/button")).Click();
            Thread.Sleep(5000);

            //Enter Note
            driver.FindElement(By.Id("txtNote")).SendKeys("This is Automation Test");
            Thread.Sleep(5000);

            //Enter 1st Row
            //Press QC Pass Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtQcPassQty0")).Clear();
            driver.FindElement(By.Id("txtQcPassQty0")).SendKeys("1");
            //Enter Reject Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRejectQty0")).Clear();
            driver.FindElement(By.Id("txtRejectQty0")).SendKeys("0");
            //Enter Remarks
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks0")).Clear();
            driver.FindElement(By.Id("txtSentRemarks0")).SendKeys("This is Automation Script.");



            //Enter 2nd Row
            //Press QC Pass Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtQcPassQty1")).Clear();
            driver.FindElement(By.Id("txtQcPassQty1")).SendKeys("1");
            //Enter Reject Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRejectQty1")).Clear();
            driver.FindElement(By.Id("txtRejectQty1")).SendKeys("0");
            //Enter Remarks
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks1")).Clear();
            driver.FindElement(By.Id("txtSentRemarks1")).SendKeys("This is Automation Script.");

            //Enter 3rd Row
            //Press QC Pass Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtQcPassQty2")).Clear();
            driver.FindElement(By.Id("txtQcPassQty2")).SendKeys("1");
            //Enter Reject Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRejectQty2")).Clear();
            driver.FindElement(By.Id("txtRejectQty2")).SendKeys("0");
            //Enter Remarks
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks2")).Clear();
            driver.FindElement(By.Id("txtSentRemarks2")).SendKeys("This is Automation Script.");


            //Enter 4th Row
            //Press QC Pass Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtQcPassQty3")).Clear();
            driver.FindElement(By.Id("txtQcPassQty3")).SendKeys("1");
            //Enter Reject Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRejectQty3")).Clear();
            driver.FindElement(By.Id("txtRejectQty3")).SendKeys("0");
            //Enter Remarks
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks3")).Clear();
            driver.FindElement(By.Id("txtSentRemarks3")).SendKeys("This is Automation Script.");


            //Enter fifth Row
            //Press QC Pass Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtQcPassQty4")).Clear();
            driver.FindElement(By.Id("txtQcPassQty4")).SendKeys("1");
            //Enter Reject Qty
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRejectQty4")).Clear();
            driver.FindElement(By.Id("txtRejectQty4")).SendKeys("0");
            //Enter Remarks
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks4")).Clear();
            driver.FindElement(By.Id("txtSentRemarks4")).SendKeys("This is Automation Script.");


            //Click Save button
            Thread.Sleep(2000);
            driver.FindElement(By.Id("btnUpdate")).Click();
        }
        
        [Then(@"Information edited successfully")]
        public void ThenInformationEditedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
