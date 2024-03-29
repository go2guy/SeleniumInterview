using OpenQA.Selenium;

namespace SeleniumInterview.Page
{
    public class HomePage : BasePage
    {
        private readonly By _search = By.Id("edit-search-block-form--2");
        private readonly By _searchButton = By.XPath("//*[@id=\"search-block-form\"]/div/div/div[1]/span");

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void Search(string what)
        {
            SendKeys(_search,what);
            Click(_searchButton);
        }
    }
}

