using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
      
        IWebDriver driver;
        public ManageListings(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[3]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[2]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

    public void ViewManageListing()
        {
            Thread.Sleep(2000);
            manageListingsLink.Click();
            Thread.Sleep(2000);
            view.Click();
        }
        public void EditManageListing()
        {
            Thread.Sleep(2000);
            manageListingsLink.Click();
            Thread.Sleep(2000);
            edit.Click();
            Skills obj = new Skills(driver);
            obj.EditSkills();
        }
        public void DeleteManageListing()
        {
            Thread.Sleep(2000);
            manageListingsLink.Click();
            Thread.Sleep(2000);
            delete.Click();
        }

    }
}
