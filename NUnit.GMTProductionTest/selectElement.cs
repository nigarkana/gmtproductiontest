using OpenQA.Selenium;

namespace NUnit.GMTProductionTest
{
    internal class selectElement
    {
        private IWebElement webElement;

        public selectElement(IWebElement webElement)
        {
            this.webElement = webElement;
        }
    }
}