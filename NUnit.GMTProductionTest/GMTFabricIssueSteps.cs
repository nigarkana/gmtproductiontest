using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTFabricIssueSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"Requisition ID, Job Code and according to Job Code select Requisition ID")]
        public void GivenRequisitionIDJobCodeAndAccordingToJobCodeSelectRequisitionID()
        {
            driver.Navigate().GoToUrl("http://172.16.1.63/gmtproduction");
            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            driver.FindElement(By.Id("UserName")).SendKeys("nigar");

            //Enter Password
            Thread.Sleep(2000);
            driver.FindElement(By.Id("Password")).SendKeys("d123");

            //Click Login Button
            driver.FindElement(By.Id("loginBtn")).Click();

            //Click Fabric Menu
            //driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[3]/a/text()")).Click();
            Thread.Sleep(2000);
            //Click Fabric Menu
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[3]/a")).Click();
            Thread.Sleep(2000);

            // Click Sub Menu Issue
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[3]/ul[2]/li/a")).Click();

        }

        [When(@"write Job Code press Enter then select Requisition or only enter Requistion and press Enter and enter required field and click Save")]
        public void WhenWriteJobCodePressEnterThenSelectRequisitionOrOnlyEnterRequistionAndPressEnterAndEnterRequiredFieldAndClickSave()
        {
            
            Thread.Sleep(2000);
            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");
            Thread.Sleep(2000);
            //Press Enter
            driver.FindElement(By.Id("txtJobCode")).SendKeys(Keys.Enter);

            Thread.Sleep(2000);
            //select Requisition
            SelectElement select = new SelectElement(driver.FindElement(By.Id("ddlFabReqId")));
            Thread.Sleep(2000);
            select.SelectByText("34719");
            Thread.Sleep(5000);

            //For First Row
            //Select Batch ID
            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("ddlBatch_0")));
            select1.SelectByText("9836-2 (24855)");
            Thread.Sleep(5000);

            //Select Roll No's
            driver.FindElement(By.Id("txtRollCode0")).SendKeys("1");
            Thread.Sleep(2000);

            //Enter Issue Qty
            driver.FindElement(By.Id("txtIssueQty0")).Clear();
            driver.FindElement(By.Id("txtIssueQty0")).SendKeys("1");
            Thread.Sleep(2000);

            //Enter Remarks
            driver.FindElement(By.Id("txtRemarks0")).SendKeys("GMT Automation Test");
            Thread.Sleep(2000);


            //For Second Row
            //Select Batch ID
            SelectElement select2 = new SelectElement(driver.FindElement(By.Id("ddlBatch_1")));
            select2.SelectByText("9836-8 (26487)");
            Thread.Sleep(5000);

            //Select Roll No's
            driver.FindElement(By.Id("txtRollCode1")).SendKeys("1");
            Thread.Sleep(2000);

            //Enter Issue Qty
            driver.FindElement(By.Id("txtIssueQty1")).Clear();
            driver.FindElement(By.Id("txtIssueQty1")).SendKeys("1");
            Thread.Sleep(2000);

            //Enter Remarks
            driver.FindElement(By.Id("txtRemarks1")).SendKeys("GMT Automation Test");
            Thread.Sleep(2000);


            //For Third Row
            //Select Batch ID
            SelectElement select3 = new SelectElement(driver.FindElement(By.Id("ddlBatch_2")));
            select3.SelectByText("9836-11 (29234)");
            Thread.Sleep(5000);

            //Select Roll No's
            driver.FindElement(By.Id("txtRollCode2")).SendKeys("1");
            Thread.Sleep(2000);

            //Enter Issue Qty
            driver.FindElement(By.Id("txtIssueQty2")).Clear();
            driver.FindElement(By.Id("txtIssueQty2")).SendKeys("1");
            Thread.Sleep(2000);

            //Enter Remarks
            driver.FindElement(By.Id("txtRemarks2")).SendKeys("GMT Automation Test");
            Thread.Sleep(2000);

            //Click Scroll bar
           // driver.FindElement(By.Id("fabIssueDiv")).Click();
            //For Third Row
            //Select Batch ID
            SelectElement select4 = new SelectElement(driver.FindElement(By.Id("ddlBatch_3")));
            select4.SelectByText("9836-3 (24856)");
            Thread.Sleep(2000);

            //Select Roll No's
            driver.FindElement(By.Id("txtRollCode3")).SendKeys("1");
            Thread.Sleep(2000);

            //Enter Issue Qty
            driver.FindElement(By.Id("txtIssueQty3")).Clear();
            driver.FindElement(By.Id("txtIssueQty3")).SendKeys("1");
            Thread.Sleep(2000);

            //Enter Remarks
            driver.FindElement(By.Id("txtRemarks3")).SendKeys("GMT Automation Test");
            Thread.Sleep(2000);

            //Click Save button
            driver.FindElement(By.Id("btnSave")).Click();
            Thread.Sleep(1000);

            //Click No button
            driver.FindElement(By.ClassName("btn btn-info pull-left")).Submit();
            Thread.Sleep(1000);



            //Click Clear Button
            // driver.FindElement(By.Id("btnClear")).Click();




        }

        [Then(@"the result should be shown in the grid and saved successfully")]
        public void ThenTheResultShouldBeShownInTheGridAndSavedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Requisition ID and Job ID")]
        public void GivenRequisitionIDAndJobID()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"enter Job ID")]
        public void WhenEnterJobID()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Result is populated in the grid")]
        public void ThenResultIsPopulatedInTheGrid()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
