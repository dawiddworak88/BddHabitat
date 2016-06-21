using System;
using System.Threading;
using OpenQA.Selenium;

namespace BddHabitat.IntegrationTests.Pages
{
    /// <summary>
    /// The home page.
    /// </summary>
    /// <seealso cref="BddHabitat.IntegrationTests.Pages.PageBase" />
    public class Home : PageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Home"/> class.
        /// </summary>
        /// <param name="driver">The driver.</param>
        public Home(IWebDriver driver) : base(driver, Constants.HostUrl)
        {
        }
        
        /// <summary>
        /// Clicks the more info on the main navigation.
        /// </summary>
        public void ClickMoreInfoOnTheMainNavigation()
        {
            this._header.MoreInfo.Click();
        }

        /// <summary>
        /// Reads the content.
        /// </summary>
        /// <param name="timeToReadInMiliseconds">The time to read in miliseconds.</param>
        public void ReadContent(int timeToReadInMiliseconds)
        {
            Thread.Sleep(timeToReadInMiliseconds);
            
            IJavaScriptExecutor js = (IJavaScriptExecutor)this._driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
        }

        /// <summary>
        /// Scrolls up.
        /// </summary>
        public void ScrollUp()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)this._driver;
            js.ExecuteScript("window.scrollTo(0, 0);");
        }

        /// <summary>
        /// Opens the visitor information sidebar.
        /// </summary>
        public void OpenVisitorInformationSidebar()
        {
            this._sidebar.SidebarButton.Click();
        }

        /// <summary>
        /// Clicks the refresh on visitor information sidebar.
        /// </summary>
        public void ClickRefreshOnVisitorInformationSidebar()
        {
            this._sidebar.RefreshButton.Click();
            Thread.Sleep(TimeSpan.FromSeconds(Constants.ImplicitTimeoutInSeconds));
        }

        /// <summary>
        /// Clicks the engagement tab on visitor information sidebar.
        /// </summary>
        public void ClickEngagementTabOnVisitorInformationSidebar()
        {
            this._sidebar.EngagementTab.Click();
        }
    }
}
