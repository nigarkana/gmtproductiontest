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
    public class GMTCuttingSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Job Code, Cutting Date, Marker No, Lay Chart No, Business Unit, Production Unit, Embellishment Status, Search Supervisor, Table Supervisor and Note")]
        public void GivenJobCodeCuttingDateMarkerNoLayChartNoBusinessUnitProductionUnitEmbellishmentStatusSearchSupervisorTableSupervisorAndNote()
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

            //Click Add Record
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[2]/li/a")).Click();
            Thread.Sleep(2000);

            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");
            Thread.Sleep(1000);

            //Press Enter
            driver.FindElement(By.Id("txtJobCode")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            //Cutting Date
            //driver.FindElement(By.Id("txtCutDate")).SendKeys("21 May 2017");
            //Thread.Sleep(1000);

            //Marker No
            driver.FindElement(By.Id("txtMarkerNo")).SendKeys("1");
            Thread.Sleep(1000);

            //Lay Chart No
            driver.FindElement(By.Id("txtLayChartNo")).SendKeys("1");
            Thread.Sleep(1000);

            //Business Unit
            SelectElement select = new SelectElement(driver.FindElement(By.Id("ddlBussinessUnit")));
            select.SelectByText("DCTL-1(1)");
            Thread.Sleep(1000);

            //Production Unit
            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("ddlProductionUnit")));
            select1.SelectByText("Cutting>>Unit-2(000002)");
            Thread.Sleep(1000);

            //Embellishment Status
            SelectElement select2 = new SelectElement(driver.FindElement(By.Id("ddlEmbStatus")));
            select2.SelectByText("Print");
            Thread.Sleep(1000);

            //Search Supervisor
            driver.FindElement(By.Id("txtSupSrcByID")).SendKeys("00178");
            Thread.Sleep(1000);

            //Table Supervisor
            SelectElement select3 = new SelectElement(driver.FindElement(By.Id("ddlTableSupId")));
            select3.SelectByText("Alauddin_63 (00178)");
            Thread.Sleep(1000);

            //Note
            driver.FindElement(By.Id("txtNote")).SendKeys("GMT Production Cutting Test purpose for QA Automation Testing.");
            Thread.Sleep(1000);
        }

        [When(@"Click Garment Information")]
        public void WhenClickGarmentInformation()
        {
            driver.FindElement(By.XPath("//*[@id='myTab1']/li[2]/a")).Click();
        }

        [Given(@"No of Lay, Table No, Order Code, Color")]
        public void GivenNoOfLayTableNoOrderCodeColor()
        {
            //Enter No. of Lay
            driver.FindElement(By.Id("txtNoOfLay")).SendKeys("1");
            Thread.Sleep(1000);

            //Enter Table No
            driver.FindElement(By.Id("txtTableNo")).SendKeys("1");
            Thread.Sleep(1000);

            //Select Order Code
            SelectElement select = new SelectElement(driver.FindElement(By.Id("ddlOrderCode")));
            select.SelectByText("B0027761");
            Thread.Sleep(1000);

            //Select Color
            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("ddlColor")));
            select1.SelectByText("Navy");
            Thread.Sleep(1000);

            //SelectElement select2 = new SelectElement(driver.FindElement(By.Id("ddlColor")));
           // select1.SelectByText("Navy");
            //Thread.Sleep(1000);

        }
        
        [Given(@"Marker Ratio, QC Pass Quantity, Reject Quantity, Reject Note")]
        public void GivenMarkerRatioQCPassQuantityRejectQuantityRejectNote()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtMarkerRatio0")).Clear();
            driver.FindElement(By.Id("txtMarkerRatio0")).SendKeys("1");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtQcPass0")).Clear();
            driver.FindElement(By.Id("txtQcPass0")).SendKeys("1");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRejectQty0")).Clear();
            driver.FindElement(By.Id("txtRejectQty0")).SendKeys("0");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRejectNote0")).Clear();
            driver.FindElement(By.Id("txtRejectNote0")).SendKeys("Reject Quantity for Testing Purpose");
            Thread.Sleep(1000);
        }
        
        [Given(@"Job Code, Date Range")]
        public void GivenJobCodeDateRange()
        {
            //Click Cutting Menu
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/a")).Click();
            Thread.Sleep(2000);
          

        }
        
        
        [Then(@"Garments Information page is displayed")]
        public void ThenGarmentsInformationPageIsDisplayed()
        {
            driver.FindElement(By.XPath("//*[@id='myTab1']/li[2]/a")).Click();
            Thread.Sleep(3000);
        }

        [When(@"Click Add")]
        public void WhenClickAdd()
        {
            //Click Add Button
            driver.FindElement(By.Id("btnAdd")).Click();
            Thread.Sleep(1000);
        }
        
        [When(@"click Save")]
        public void WhenClickSave()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.Id("btnSave")).Click();
        }
       
        
        [Then(@"Grid has loaded")]
        public void ThenGridHasLoaded()
        {
            Thread.Sleep(1000);
            Assert.AreEqual("Order No/PO (Code)", driver.FindElement(By.XPath("//*[@id='garmentsInfos']/thead/tr/th[7]/b")).Text);
            Thread.Sleep(1000);
            Assert.AreEqual("Color", driver.FindElement(By.XPath("//*[@id='garmentsInfos']/thead/tr/th[8]/b")).Text);

        }
        
       

     
        
        
    }
}
