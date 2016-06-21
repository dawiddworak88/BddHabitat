using System.IO;
using BddHabitat.IntegrationTests.Pages.Components;
using OpenQA.Selenium;

namespace BddHabitat.IntegrationTests.Pages
{
    /// <summary>
    /// The more info page.
    /// </summary>
    /// <seealso cref="BddHabitat.IntegrationTests.Pages.PageBase" />
    public class MoreInfo : PageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoreInfo"/> class.
        /// </summary>
        /// <param name="driver">The driver.</param>
        public MoreInfo(IWebDriver driver) : base(driver, Path.Combine(Constants.HostUrl, Constants.MoreInfoUrl))
        {
        }

        /// <summary>
        /// Clicks the logo.
        /// </summary>
        public void ClickLogo()
        {
            this._header.Logo.Click();
        }
    }
}
