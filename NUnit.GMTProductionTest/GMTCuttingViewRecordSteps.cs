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
    public class GMTCuttingViewRecordSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Job Code, Date Range, View Button")]
        public void GivenJobCodeDateRangeViewButton()
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

            //Click View Record
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[4]/ul[3]/li/a")).Click();
            Thread.Sleep(2000);

            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");
            Thread.Sleep(2000);

        }
        
        [When(@"I press View")]
        public void WhenIPressView()
        {
            // Click View
            driver.FindElement(By.Id("btnView")).Click();
            Thread.Sleep(2000);
        }
        [Then(@"Grid is loaded with Edit and Lay Chart View")]
        public void ThenGridIsLoadedWithEditAndLayChartView()
        {
            //Assert with Cutting ID
            Thread.Sleep(3000);
            Assert.AreEqual("Cutting ID", driver.FindElement(By.XPath("//*[@id='cuttingEditView']/thead/tr/th[1]/b")).Text);
            Thread.Sleep(3000);

            //Assert with Job Code
            Assert.AreEqual("Job Code", driver.FindElement(By.XPath("//*[@id='cuttingEditView']/thead/tr/th[3]")).Text);
            Thread.Sleep(3000);

            //Assert with Table No
            Assert.AreEqual("Table No", driver.FindElement(By.XPath("//*[@id='cuttingEditView']/thead/tr/th[6]/b")).Text);
        }

        [When(@"I press Edit")]
        public void WhenIPressEdit()
        {
            //Click Edit Button
            Thread.Sleep(2000);
            driver.FindElement(By.Id("btnEdit")).Click();
        }
        
        [When(@"I click Garments Information")]
        public void WhenIClickGarmentsInformation()
        {
            //Click Garments information
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id='myTab1']/li[2]/a")).Click();
        }
        
        [When(@"click Save button for edit")]
        public void WhenClickSaveButtonForEdit()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.Id("btnSave")).Click();
        }
        
       
        
        [Then(@"Add Cutting Information page is displayed for edit")]
        public void ThenAddCuttingInformationPageIsDisplayedForEdit()
        {
            //Assert with Add Cutting Information page after click EDIT
            Thread.Sleep(2000);
            Assert.AreEqual("Add Cutting Information", driver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div[1]/h2")).Text);

            //Marker No
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtMarkerNo")).Clear();
            driver.FindElement(By.Id("txtMarkerNo")).SendKeys("2");
            Thread.Sleep(2000);

            //Lay Chart No
            driver.FindElement(By.Id("txtLayChartNo")).Clear();
            driver.FindElement(By.Id("txtLayChartNo")).SendKeys("2");
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
            driver.FindElement(By.Id("txtNote")).SendKeys("Edit Mode GMT Production Cutting Test purpose for QA Automation Testing.");
            Thread.Sleep(1000);

        }
        
        [Then(@"Garments Information page is displayed for edit")]
        public void ThenGarmentsInformationPageIsDisplayedForEdit()
        {
            //Assert with Garments Information tab
            Thread.Sleep(2000);
            Assert.AreEqual("Garments Information", driver.FindElement(By.XPath("//*[@id='myTab1']/li[2]/a")).Text);
        }
        
        [Then(@"enter required information if need to change")]
        public void ThenEnterRequiredInformationIfNeedToChange()
        {

            //Enter No. of Lay
            driver.FindElement(By.Id("txtNoOfLay")).Clear();
            driver.FindElement(By.Id("txtNoOfLay")).SendKeys("5");
            Thread.Sleep(1000);

            //Enter Table No
            driver.FindElement(By.Id("txtTableNo")).Clear();
            driver.FindElement(By.Id("txtTableNo")).SendKeys("2");
            Thread.Sleep(1000);

            //Select Order Code
            SelectElement select = new SelectElement(driver.FindElement(By.Id("ddlOrderCode")));
            select.SelectByText("B0027761");
            Thread.Sleep(1000);

            //Select Color NAVY
            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("ddlColor")));
            select1.SelectByText("Navy");
            Thread.Sleep(1000);
            //Click Add Button
            driver.FindElement(By.Id("btnAdd")).Click();
            Thread.Sleep(1000);

            //Select Color BLACK
            SelectElement select2 = new SelectElement(driver.FindElement(By.Id("ddlColor")));
            select2.SelectByText("Black");
            Thread.Sleep(1000);
            //Click Add Button
            driver.FindElement(By.Id("btnAdd")).Click();
            Thread.Sleep(1000);

            //Select Color Mid Heather Grey
            SelectElement select3 = new SelectElement(driver.FindElement(By.Id("ddlColor")));
            select3.SelectByText("Mid Heather Grey");
            Thread.Sleep(1000);
            //Click Add Button
            driver.FindElement(By.Id("btnAdd")).Click();
            Thread.Sleep(1000);

            //Select Color WHITE
            SelectElement select4 = new SelectElement(driver.FindElement(By.Id("ddlColor")));
            select4.SelectByText("White");
            Thread.Sleep(1000);
            //Click Add Button
            driver.FindElement(By.Id("btnAdd")).Click();
            Thread.Sleep(1000);

            //Enter 1st Grid Information
            //Enter Marker Ratio
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtMarkerRatio0")).Clear();
            driver.FindElement(By.Id("txtMarkerRatio0")).SendKeys("5");
            //Enter QC Pass Quantity
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtQcPass0")).Clear();
            driver.FindElement(By.Id("txtQcPass0")).SendKeys("5");
            //Enter Reject Quantity
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRejectQty0")).Clear();
            driver.FindElement(By.Id("txtRejectQty0")).SendKeys("5");
            //Enter Reject Note
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRejectNote0")).Clear();
            driver.FindElement(By.Id("txtRejectNote0")).SendKeys("Reject Quantity for Testing EDIT Purpose");
            Thread.Sleep(1000);

            //Enter 2nd Grid Information
            //Enter Marker Ratio
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtMarkerRatio7")).Clear();
            driver.FindElement(By.Id("txtMarkerRatio7")).SendKeys("5");
            //Enter QC Pass Quantity
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtQcPass7")).Clear();
            driver.FindElement(By.Id("txtQcPass7")).SendKeys("5");
            //Enter Reject Quantity
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRejectQty7")).Clear();
            driver.FindElement(By.Id("txtRejectQty7")).SendKeys("5");
            //Enter Reject Note
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRejectNote7")).Clear();
            driver.FindElement(By.Id("txtRejectNote7")).SendKeys("Reject Quantity for Testing EDIT Purpose");
            Thread.Sleep(1000);

            //Enter 3rd Grid Information
            //Enter Marker Ratio
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtMarkerRatio8")).Clear();
            driver.FindElement(By.Id("txtMarkerRatio8")).SendKeys("5");
            //Enter QC Pass Quantity
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtQcPass8")).Clear();
            driver.FindElement(By.Id("txtQcPass8")).SendKeys("5");
            //Enter Reject Quantity
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRejectQty8")).Clear();
            driver.FindElement(By.Id("txtRejectQty8")).SendKeys("5");
            //Enter Reject Note
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRejectNote8")).Clear();
            driver.FindElement(By.Id("txtRejectNote8")).SendKeys("Reject Quantity for Testing EDIT Purpose");
            Thread.Sleep(1000);

            //Enter 4th Grid Information
            //Enter Marker Ratio
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtMarkerRatio9")).Clear();
            driver.FindElement(By.Id("txtMarkerRatio9")).SendKeys("5");
            //Enter QC Pass Quantity
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtQcPass9")).Clear();
            driver.FindElement(By.Id("txtQcPass9")).SendKeys("5");
            //Enter Reject Quantity
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRejectQty9")).Clear();
            driver.FindElement(By.Id("txtRejectQty9")).SendKeys("5");
            //Enter Reject Note
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txtRejectNote9")).Clear();
            driver.FindElement(By.Id("txtRejectNote9")).SendKeys("Reject Quantity for Testing EDIT Purpose");
            Thread.Sleep(1000);


        }

        [Then(@"edited information save successfully")]
        public void ThenEditedInformationSaveSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
