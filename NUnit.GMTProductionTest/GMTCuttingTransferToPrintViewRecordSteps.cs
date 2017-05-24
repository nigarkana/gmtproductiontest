using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTCuttingTransferToPrintViewRecordSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Url, UserName, Password,Job Code")]
        public void GivenUrlUserNamePasswordJobCode()
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

            //Click View Record
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[7]/li/ul[2]/li/a")).Click();
            Thread.Sleep(2000);

            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");

        }

        
        
        [When(@"press Search")]
        public void WhenPressSearch()
        {
            driver.FindElement(By.Id("btnSearch")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"Grid is loaded")]
        public void ThenGridIsLoaded()
        {
            Thread.Sleep(1000);
            Assert.AreEqual("Print/Emb Id", driver.FindElement(By.XPath("//*[@id='SendEmbPrintView']/thead/tr/th[1]/b")).Text);

            Thread.Sleep(1000);
            Assert.AreEqual("Edit", driver.FindElement(By.XPath("//*[@id='SendEmbPrintView']/thead/tr/th[8]/b")).Text);
        }

        [When(@"click EDIT")]
        public void WhenClickEDIT()
        {
            driver.FindElement(By.XPath("//*[@id='SendEmbPrintView']/td[8]/button")).Click();
            Thread.Sleep(10000);
        }


        [Then(@"Send for Emb form is opened")]
        public void ThenSendForEmbFormIsOpened()
        {
            Thread.Sleep(1000);
           Assert.AreEqual("Send for Embellishment", driver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div[1]/h2")).Text);
            Thread.Sleep(2000);
        }

        [Given(@"update all required information if needed")]
        public void GivenUpdateAllRequiredInformationIfNeeded()
        {
            //Enter Manual Chalan Ref
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtManualChallanRef")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtManualChallanRef")).SendKeys("Reference No -123");
            Thread.Sleep(1000);

            //Enter Body Part Garments
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtNoOfBodyPart")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtNoOfBodyPart")).SendKeys("7");
            Thread.Sleep(1000);


            //Body Part Description
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtBodyPartDescription")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtBodyPartDescription")).SendKeys("This is for Testing Automation.");
            Thread.Sleep(1000);

            //Note
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtNote")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtNote")).SendKeys("If required please enter Note for Testing Purpose.");
            Thread.Sleep(1000);

            //Send To

            //Search by ID/Name
            driver.FindElement(By.Id("txtSupSrcByID")).SendKeys("00356");
            Thread.Sleep(2000);

            //Search by Employee
            //driver.FindElement(By.Id("ddlEmployee")).Clear();
            //Thread.Sleep(2000);
            driver.FindElement(By.Id("ddlEmployee")).SendKeys("Md. Anower Hossain_63 (00356)");
            Thread.Sleep(2000);

            //In the grid (first Row)

            //Send For Embellishment
            driver.FindElement(By.Id("txtRemainEmbQty0")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRemainEmbQty0")).SendKeys("1");
            Thread.Sleep(1000);
            //Remarks
            driver.FindElement(By.Id("txtSentRemarks0")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtSentRemarks0")).SendKeys("Testing Purpose EDIT Mode.");
            Thread.Sleep(1000);

            //In the grid Second Row
            //Send For Embellishment
            driver.FindElement(By.Id("txtRemainEmbQty1")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRemainEmbQty1")).SendKeys("1");
            Thread.Sleep(1000);
            //Remarks
            driver.FindElement(By.Id("txtSentRemarks1")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtSentRemarks1")).SendKeys("Testing Purpose EDIT Mode.");
            Thread.Sleep(2000);

            //In the grid Third Row
            //Send For Embellishment
            driver.FindElement(By.Id("txtRemainEmbQty2")).Clear();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRemainEmbQty2")).SendKeys("1");
            Thread.Sleep(2000);
            //Remarks
            driver.FindElement(By.Id("txtSentRemarks2")).Clear();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtSentRemarks2")).SendKeys("Testing Purpose EDIT Mode.");
            Thread.Sleep(2000);


        }




        [When(@"press Update")]
        public void WhenPressUpdate()
        {
            //Click Update Button
            driver.FindElement(By.Id("btnSave")).Click();
            Thread.Sleep(2000);
        }
        
       
       
        
        [Then(@"Transfer to Print/Emb is saved successfully")]
        public void ThenTransferToPrintEmbIsSavedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
