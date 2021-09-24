using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class Skills
    {
        IWebDriver driver;
        public Skills(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Share Skill')]")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[3]/div[1]/div[1]/input[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        public void AddSkills()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            ShareSkillButton.Click();
            //Title.SendKeys("Developing");
            Title.SendKeys(ExcelLibHelp.ReadData(2, "skills"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Description.SendKeys("Java");
            Description.SendKeys(ExcelLibHelp.ReadData(3, "skills"));
            //choose level
            var selectElement = new SelectElement(CategoryDropDown);
            //select by value
            selectElement.SelectByIndex(1);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var selectElement1 = new SelectElement(SubCategoryDropDown);
            //select by value
            selectElement1.SelectByIndex(1);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Tags.SendKeys("C#");
            Tags.SendKeys(ExcelLibHelp.ReadData(4, "skills"));
            Tags.SendKeys(Keys.Enter);
            ServiceTypeOptions.Click();
            LocationTypeOption.Click();
            Thread.Sleep(1000);
            Days.Click();
            //StartTimeDropDown.SendKeys("02:04");
            StartTimeDropDown.SendKeys(ExcelLibHelp.ReadData(5, "skills"));
            //EndTimeDropDown.SendKeys("02:04");
            EndTimeDropDown.SendKeys(ExcelLibHelp.ReadData(6, "skills"));
            Thread.Sleep(1000);
            SkillTradeOption.Click();
            Thread.Sleep(1000);
           // SkillExchange.SendKeys("C#");
            SkillExchange.SendKeys(ExcelLibHelp.ReadData(7, "skills"));
            SkillExchange.SendKeys(Keys.Enter);
           // CreditAmount.Click();
            ActiveOption.Click();
            Thread.Sleep(1000);
            Save.Click();
        }

        public void EditSkills()
        {
            Thread.Sleep(1000);
            ShareSkillButton.Click();
            Title.SendKeys("Designing");
            Thread.Sleep(2000);
            Description.SendKeys("HTML");
            //choose level
            var selectElement = new SelectElement(CategoryDropDown);
            //select by value
            selectElement.SelectByIndex(1);
            Thread.Sleep(2000);
            var selectElement1 = new SelectElement(SubCategoryDropDown);
            //select by value
            selectElement1.SelectByIndex(1);
            Thread.Sleep(2000);
            Tags.SendKeys("CSS");
            Tags.SendKeys(Keys.Enter);
            ServiceTypeOptions.Click();
            LocationTypeOption.Click();
            Thread.Sleep(2000);
            Days.Click();
            StartTimeDropDown.SendKeys("02:04");
            EndTimeDropDown.SendKeys("02:04");
            Thread.Sleep(2000);
            SkillTradeOption.Click();
            Thread.Sleep(2000);
            SkillExchange.SendKeys("CSS");
            SkillExchange.SendKeys(Keys.Enter);
            // CreditAmount.Click();
            ActiveOption.Click();
            Thread.Sleep(2000);
            //Save.Click();
        }
    }
}
