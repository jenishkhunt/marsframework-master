using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Global
{
    class Common
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url= "http://localhost:5000/";
            SignIn loginobj = new SignIn(driver);
            loginobj.Signinvalue();

        }
        //[TearDown]
        //public void Close()
        //{
        //    driver.Quit();
        //}
    }
}
