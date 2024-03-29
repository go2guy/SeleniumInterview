using SeleniumInterview.Page;

namespace SeleniumInterview.Tests
{
    [TestFixture]
    public class JenkinsTest : BaseTest
    {
        private JenkinsPage _jenkinsPage;
        private HomePage _homePage;

        [OneTimeSetUp]
        public void Setup()
        {
            _jenkinsPage = new JenkinsPage(Driver);
            _homePage = new HomePage(Driver);
        }

        [Test(Description = "Verify that clicking Jenkins Link lands on Jenkins page"), Order(1)]
        public void TestClickingJenkinsLink()
        {
            _jenkinsPage.TestJenkinsLink();
            Assert.That(_jenkinsPage.GetPageTitle(), Is.EqualTo("Jenkins Continuous Integration Tutorial | Selenium Easy"));   
        }

        [Test(Description = "Verify search page works"), Order(2)]
        public void TestSearchingHomepage()
        {
            _homePage.Search("Jenkins");
            Assert.That(_jenkinsPage.GetPageTitle(), Is.EqualTo("Search | Selenium Hard"));
        }

    }
}
