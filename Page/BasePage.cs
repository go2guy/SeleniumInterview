using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace SeleniumInterview.Page
{
    public class BasePage
    {
        private readonly IWebDriver _driver;
        protected WebDriverWait Wait;
        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
            Wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
        }

        protected void WaitUntilElementVisible(By by)
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected IWebElement GetElement(By by)
        {
            WaitUntilElementVisible(by);
            return _driver.FindElement(by);
        }

        protected void Click(By by)
        {

            WaitUntilElementVisible(by);
            _driver.FindElement(by).Click();
        }

        protected void SendKeys(By by, string text)
        {
            WaitUntilElementVisible(by);
            _driver.FindElement(by).SendKeys(text);
        }

        public string GetPageTitle()
        {
            string PageTitle = _driver.Title;
            return PageTitle;
        }
    }
}
