using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BddHabitat.IntegrationTests.Pages.Components
{
    /// <summary>
    /// The header component.
    /// </summary>
    public class Header : ComponentBase
    {
        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        /// <value>
        /// The logo.
        /// </value>
        [FindsBy(How = How.XPath, Using = "//div[@class='navbar-left']/a")]
        public IWebElement Logo { get; set; }

        /// <summary>
        /// Gets or sets the more info element.
        /// </summary>
        /// <value>
        /// The more info element.
        /// </value>
        [FindsBy(How = How.XPath, Using = "//div[@id='siteNavbar']/ul/li[4]/a")]
        public IWebElement MoreInfo { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Header"/> class.
        /// </summary>
        /// <param name="driver">The driver.</param>
        public Header(IWebDriver driver) : base(driver)
        {
        }
    }
}
