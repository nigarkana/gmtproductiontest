using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTCuttingTransferToPrinEmbSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"URL Login, Transfer to Print/Emb link, Job Code")]
        public void GivenURLLoginTransferToPrintEmbLinkJobCode()
        {
            driver.Navigate().GoToUrl("http://172.16.1.63/gmtProduction");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);


            //For User Name 
            driver.FindElement(By.Id("UserName")).SendKeys("nigar");

            //For Password
            driver.FindElement(By.Id("Password")).SendKeys("d123");

            //Click Login Button
            driver.FindElement(By.Id("loginBtn")).Click();

            Thread.Sleep(5000);

            //Click Cutting Menu
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/a")).Click();
            Thread.Sleep(2000);

            //Transfer to Prinit/Emb
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[7]/li/a")).Click();
            Thread.Sleep(2000);

            //Click Add Record
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[7]/li/ul[1]/li/a")).Click();
            Thread.Sleep(2000);

            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");


        }

        [When(@"I press Enter")]
        public void WhenIPressEnter()
        {
            //Press Enter
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtJobCode")).SendKeys(Keys.Enter);
            Thread.Sleep(11000);
        }

        [Then(@"Grid is loaded with all Cutting Id according to the Job")]
        public void ThenGridIsLoadedWithAllCuttingIdAccordingToTheJob()
        {
            //Assert with Cutting Id in the Grid
            Thread.Sleep(3000);
            Assert.AreEqual("406303", driver.FindElement(By.XPath("//*[@id='embSendDataView']/td[1]")).Text);

            //Assert with OrderNo/ PO (Code)
            Thread.Sleep(3000);
            Assert.AreEqual("Order No / PO (Code)", driver.FindElement(By.XPath("//*[@id='embSendDataView']/thead/tr/td[6]")).Text);

            //Assert with Order Qty
            Thread.Sleep(3000);
            Assert.AreEqual("Order Qty", driver.FindElement(By.XPath("//*[@id='embSendDataView']/thead/tr/td[13]")).Text);

            //Assert with Send for Emb
            Thread.Sleep(3000);
            Assert.AreEqual("Send for Emb", driver.FindElement(By.XPath("//*[@id='embSendDataView']/thead/tr/td[17]")).Text);

            //Assert with Remarks
            Thread.Sleep(3000);
            Assert.AreEqual("Remarks", driver.FindElement(By.XPath("//*[@id='embSendDataView']/thead/tr/td[18]")).Text);




        }


        [Given(@"Send for Emb, Remarks")]
        public void GivenSendForEmbRemarks()
        {

            //Enter 1st row
            //Enter value of Send for Emb
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSendQty_0")).SendKeys("1");


            //Enter text of Remarks field
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks_0")).SendKeys("This is for GMTProduction Automation Testing");

            //Enter 2nd row
            //Enter value of Send for Emb
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSendQty_1")).SendKeys("1");

            //Enter text of Remarks field
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks_1")).SendKeys("This is for GMTProduction Automation Testing");

            //Enter 2nd row
            //Enter value of Send for Emb
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSendQty_3")).SendKeys("1");

            //Enter text of Remarks field
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks_3")).SendKeys("This is for GMTProduction Automation Testing");


        }
        
        [Given(@"in Description give Manual Challan Ref, Body Part per Gmt, Body Part Description, Note")]
        public void GivenInDescriptionGiveManualChallanRefBodyPartPerGmtBodyPartDescriptionNote()
        {
            //Enter Manual Chalan Ref
            driver.FindElement(By.Id("txtManualChallanRef")).SendKeys("Ref-1");
            Thread.Sleep(1000);

            //Enter Body Part per GMT
            driver.FindElement(By.Id("txtNoOfBodyPart")).SendKeys("5");
            Thread.Sleep(1000);

            //Enter Body Part Description
            driver.FindElement(By.Id("txtBodyPartDescription")).SendKeys("Body Part Description");
            Thread.Sleep(1000);

            //Enter Note
            driver.FindElement(By.Id("txtNote")).SendKeys("This is for testing purpose");
            Thread.Sleep(1000);

        }
        
        [Given(@"in Send To Search by Name or Select Employee")]
        public void GivenInSendToSearchByNameOrSelectEmployee()
        {
            //Enter Search by ID/Name
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtSupSrcByID")).SendKeys("00356");
            //Enter Search by ID/Name
            Thread.Sleep(1000);
            SelectElement select = new SelectElement(driver.FindElement(By.Id("ddlEmployee")));
            select.SelectByText("Md. Anower Hossain_63 (00356)");
            
        }
        
       
        
        [When(@"Click Save")]
        public void WhenClickSave()
        {

            Thread.Sleep(2000);
            driver.FindElement(By.Id("btnSave")).Click();
        }
        
        
        [Then(@"Print/Emb Send Successfully")]
        public void ThenPrintEmbSendSuccessfully()
        {
            ScenarioContext.Current.Pending();

            driver.Close();
        }
    }
}
