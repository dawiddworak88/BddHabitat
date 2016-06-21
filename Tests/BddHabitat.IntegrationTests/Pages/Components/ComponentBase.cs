using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BddHabitat.IntegrationTests.Pages.Components
{
    /// <summary>
    /// The base class for all components.
    /// </summary>
    public class ComponentBase
    {
        /// <summary>
        /// The web driver.
        /// </summary>
        private readonly IWebDriver _driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentBase"/> class.
        /// </summary>
        /// <param name="driver">The driver.</param>
        public ComponentBase(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(_driver, this);
        }
    }
}
