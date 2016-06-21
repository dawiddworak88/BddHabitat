using BddHabitat.IntegrationTests.Pages.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BddHabitat.IntegrationTests.Pages
{
    /// <summary>
    /// The base class for all pages.
    /// </summary>
    public class PageBase
    {
        /// <summary>
        /// The web driver.
        /// </summary>
        protected readonly IWebDriver _driver;

        /// <summary>
        /// The header component.
        /// </summary>
        protected readonly Header _header;

        /// <summary>
        /// The sidebar component.
        /// </summary>
        protected readonly VisitorInformationSidebar _sidebar;

        /// <summary>
        /// The url.
        /// </summary>
        private readonly string _url;

        /// <summary>
        /// Initializes a new instance of the <see cref="PageBase"/> class.
        /// </summary>
        /// <param name="driver">The driver.</param>
        /// <param name="url">The url.</param>
        public PageBase(IWebDriver driver, string url)
        {
            this._url = url;
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
            this._header = new Header(driver);
            this._sidebar = new VisitorInformationSidebar(driver);
        }

        /// <summary>
        /// Navigates to the page.
        /// </summary>
        public void NavigateTo()
        {
            this._driver.Navigate().GoToUrl(this._url);
        }
    }
}
