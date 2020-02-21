using TestChrome.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace TestChrome
{
    public class TestClass
    {   
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void Test()
        {

            driver.Navigate().GoToUrl("https://www.booking.com");
            HomePage homePage = new HomePage(); // чтобы могли обращаться к объектам из HomePage.cs
            PageFactory.InitElements(driver, homePage); // инициализация элементов Page Object из PageHome.cs (Deprecated/устаревшее?)
            /*
            // Выбор Английского США раздела
            homePage.LanguageSelection.Click();
            homePage.EnglishLanguageSelection.Click();
            
            // Ввод в поиск New York
            homePage.TextSearchForm.Click();
            homePage.TextSearchForm.SendKeys("New York");
            */
            homePage.DateSearchForm.Click();
            Thread.Sleep(5000);

            for (int i = 0; i < 3; i++)
            {
                homePage.DateArrowRight.Click();
            }
            
            homePage.DateStart.Click();
            homePage.DateEnd.Click();
            
            homePage.ButtonSearchForm.Click();

            Thread.Sleep(5000);

            //driver.Dispose(); // Close the chromedriver.exe
            Assert.That(result, Does.Contain("def").IgnoreCase);
             gjrf
        }
    }
}
