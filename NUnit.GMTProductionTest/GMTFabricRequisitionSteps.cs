using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using TechTalk.SpecFlow;

using OpenQA.Selenium.Support.UI;

namespace NUnit.GMTProductionTest
{
    [Binding]
    public class GMTFabricRequisitionSteps
    {
        IWebDriver driver = new ChromeDriver();

        [Given(@"Business Unit, Production Unit and Job code")]
        public void GivenBusinessUnitProductionUnitAndJobCode()
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

            //Click Fabric Menu
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[3]/a")).Click();
            Thread.Sleep(5000);

            //Click Requisition SubMenu
            driver.FindElement(By.XPath("//*[@id='MenuListLoad']/ul/li[3]/ul[1]/li/a")).Click();

            Thread.Sleep(5000);
            //Click Business Unit
            // driver.FindElement(By.XPath("//*[@id='ddlBussinessUnit']")).SendKeys("DCTL - 2(2)");
            //driver.FindElement(By.XPath("//*[@id='ddlBussinessUnit']")).Click();
            SelectElement select =new SelectElement(driver.FindElement(By.Id("ddlBussinessUnit")));
            select.SelectByText("DCTL-2(2)");

            //Click Production Unit
            SelectElement select1 = new SelectElement(driver.FindElement(By.Id("ddlProductionUnit")));
            select1.SelectByText("Cutting>>Floor- E(000115)");

            //Enter Job Code
            driver.FindElement(By.Id("txtJobCode")).SendKeys("9836");
            Thread.Sleep(2000);

           
           

           
        

        }

        [Given(@"Job code is valid")]
        public void GivenJobCodeIsValid()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='fabRequisition']/tbody/tr[1]/th[3]/b")).Displayed);
        }
        
        [Given(@"required information is provided in the grid")]
        public void GivenRequiredInformationIsProvidedInTheGrid()
        {
            //Enter value of first row
            driver.FindElement(By.Id("txtReqQty0")).Clear();
            driver.FindElement(By.Id("txtReqQty0")).SendKeys("1");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRemarks0")).SendKeys("Test");
            Thread.Sleep(2000);

            //Enter value of second row
            driver.FindElement(By.Id("txtReqQty1")).Clear();
            driver.FindElement(By.Id("txtReqQty1")).SendKeys("1");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRemarks1")).SendKeys("Test");
            Thread.Sleep(2000);

            //Enter value of third row
            driver.FindElement(By.Id("txtReqQty2")).Clear();
            driver.FindElement(By.Id("txtReqQty2")).SendKeys("1");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRemarks2")).SendKeys("Test");
            Thread.Sleep(2000);

            //Enter value of fouth row
            driver.FindElement(By.Id("txtReqQty3")).Clear();
            driver.FindElement(By.Id("txtReqQty3")).SendKeys("1");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("txtRemarks3")).SendKeys("Test");
            Thread.Sleep(2000);
        }
        
        [When(@"Press Enter button")]
        public void WhenPressEnterButton()
        {
            //Press ENTER
            driver.FindElement(By.Id("txtJobCode")).SendKeys(Keys.Enter);
            //driver.findElement(By.id("elementid")).sendKeys(Keys.ENTER);
            Thread.Sleep(2000);

        }

        [When(@"click on Save button")]
        public void WhenClickOnSaveButton()
        {
            //Click Save
            driver.FindElement(By.Id("btnSave")).Click();

            //Click Yes Button
            // driver.FindElement(By.CssSelector("btn btn-info pull-left")).Click();
        }

        [Then(@"Job Information is loaded according to the job code")]
        public void ThenJobInformationIsLoadedAccordingToTheJobCode()
        {
          Assert.IsTrue(driver.FindElement(By.XPath("//*[@id='fabRequisition']/tbody/tr[1]/th[3]/b")).Displayed);
        }
        
        [Then(@"new requisition has been created")]
        public void ThenNewRequisitionHasBeenCreated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
