using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;


namespace MarsFramework.Pages
{
    class SignIn
    {
        IWebDriver driver;
        public SignIn(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How=How.XPath, Using = "//A[@class='item'][text()='Sign In']")]
        public IWebElement SignInBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "(//INPUT[@type='text'])[2]")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.XPath, Using = "//INPUT[@type='password']")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='fluid ui teal button'][text()='Login']")]
        public IWebElement LoginBtn { get; set; }

        public void Signinvalue()
        {
            SignInBtn.Click();
            Thread.Sleep(1000);
            //Email.SendKeys("jenishkhunt07@gmail.com");
            //Password.SendKeys("jenish1997");
            Email.SendKeys(ExcelLibHelp.ReadData(2, "username"));
            Password.SendKeys(ExcelLibHelp.ReadData(2, "password"));
            Thread.Sleep(1000);
            LoginBtn.Click();
        }


    }
}