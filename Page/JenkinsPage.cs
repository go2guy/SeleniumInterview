using OpenQA.Selenium;

namespace SeleniumInterview.Page
{
    public class JenkinsPage : BasePage
    {
        private readonly By _jenkinsLink = By.LinkText("Jenkins Test");
     
        public JenkinsPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickJenkinsLink()
        {
            Click(_jenkinsLink);
        }

        public void TestJenkinsLink()
        {
            ClickJenkinsLink();
        }
    }
}
