using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BddHabitat.IntegrationTests.Pages.Components
{
    /// <summary>
    /// The visitor information sidebar.
    /// </summary>
    /// <seealso cref="BddHabitat.IntegrationTests.Pages.Components.ComponentBase" />
    public class VisitorInformationSidebar : ComponentBase
    {
        /// <summary>
        /// Gets or sets the sidebar button.
        /// </summary>
        /// <value>
        /// The sidebar button.
        /// </value>
        [FindsBy(How = How.XPath, Using = "//button[@data-toggle='sidebar']")]
        public IWebElement SidebarButton { get; set; }

        /// <summary>
        /// Gets or sets the refresh button.
        /// </summary>
        /// <value>
        /// The refresh button.
        /// </value>
        [FindsBy(How = How.XPath, Using = "//button[@title='Refresh visit details panel']")]
        public IWebElement RefreshButton { get; set; }

        /// <summary>
        /// Gets or sets the engagement tab.
        /// </summary>
        /// <value>
        /// The engagement tab.
        /// </value>
        [FindsBy(How = How.XPath, Using = "//*[@id='experiencedata']/div[1]/div[1]/h3/a")]
        public IWebElement EngagementTab { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorInformationSidebar"/> class.
        /// </summary>
        /// <param name="driver">The driver.</param>
        public VisitorInformationSidebar(IWebDriver driver) : base(driver)
        {
        }
    }
}
