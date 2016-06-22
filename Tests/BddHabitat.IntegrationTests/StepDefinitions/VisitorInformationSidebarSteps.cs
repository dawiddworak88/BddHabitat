using System;
using BddHabitat.IntegrationTests.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace BddHabitat.IntegrationTests.StepDefinitions
{
    /// <summary>
    /// The step definitions.
    /// </summary>
    [Binding]
    public sealed class VisitorInformationSidebarSteps
    {
        /// <summary>
        /// The web driver.
        /// </summary>
        private IWebDriver _driver;

        /// <summary>
        /// The home page.
        /// </summary>
        private Home _homePage;

        /// <summary>
        /// The more info page.
        /// </summary>
        private MoreInfo _moreInfoPage;

        [BeforeScenario()]
        public void SetUp()
        {
            // Initializes web driver and pages
            this._driver = new FirefoxDriver();
            this._homePage = new Home(this._driver);
            this._moreInfoPage = new MoreInfo(this._driver);

            // Sets a bit longer page load timeout in case the application pool starts
            this._driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(Constants.PageLoadTimeoutInSeconds));

            // Maximizes the web driver window
            this._driver.Manage().Window.Maximize();
        }

        [Given(@"David opened the Home page")]
        public void GivenDavidOpenedTheHomePage()
        {
            this._homePage.NavigateTo();
        }

        [Given(@"he clicked More Info item on the main navigation")]
        public void GivenHeClickedMoreInfoItemOnTheMainNavigation()
        {
            this._homePage.ClickMoreInfoOnTheMainNavigation();
        }

        [Given(@"he read More Info page content for (.*) milliseconds")]
        public void GivenHeReadMoreInfoPageContentForMilliseconds(int p0)
        {
            this._homePage.ReadContent(p0);
        }

        [Given(@"he scrolled up the page")]
        public void GivenHeScrolledUpThePage()
        {
            this._homePage.ScrollUp();
        }

        [Given(@"he clicked the logo")]
        public void GivenHeClickedTheLogo()
        {
            this._moreInfoPage.ClickLogo();
        }

        [Given(@"he opened the visitor information sidebar")]
        public void GivenHeOpenedTheVisitorInformationSidebar()
        {
            this._homePage.OpenVisitorInformationSidebar();
        }

        [Given(@"he clicked the Refresh button on the visitor information sidebar")]
        public void GivenHeClickedTheRefreshButtonOnTheVisitorInformationSidebar()
        {
            this._homePage.ClickRefreshOnVisitorInformationSidebar();
        }

        [When(@"he clicks the Engagement tab on the information sidebar")]
        public void WhenHeClicksTheEngagementTabOnTheInformationSidebar()
        {
            this._homePage.ClickEngagementTabOnVisitorInformationSidebar();
        }

        [Then(@"his recent visit on the More Info page is present on the list")]
        public void ThenHisRecentVisitOnTheMoreInfoPageIsPresentOnTheList()
        {
            var moreInfoListElement = this._driver.FindElement(By.XPath("//*[@id='visitsPanel']/div/table/tbody/tr[2]/td[2]"));
            
            Assert.IsTrue(moreInfoListElement != null);
            Assert.IsTrue(moreInfoListElement.Text == Constants.MoreInfoUrl);
        }

        [Then(@"he can read the duration of his visit on More Info page in milliseconds")]
        public void ThenHeCanReadTheDurationOfHisVisitOnMoreInfoPageInMilliseconds()
        {
            var duration = 0;

            var durationOfMoreInfoListElement = this._driver.FindElement(By.XPath("//*[@id='visitsPanel']/div/table/tbody/tr[2]/td[3]"));
            Assert.IsTrue(durationOfMoreInfoListElement != null);

            Int32.TryParse(durationOfMoreInfoListElement.Text, out duration);
            Assert.IsTrue(duration > 0);
        }

        [AfterScenario()]
        public void TearDown()
        {
            this._driver.Quit();
        }
    }
}
