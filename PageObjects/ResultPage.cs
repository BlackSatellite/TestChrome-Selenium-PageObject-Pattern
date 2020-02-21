using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChrome.PageObjects
{
    class ResultPage
    {
        [FindsBy(How = How.CssSelector, Using = "data-tooltip-text='Hotel Pennsylvania, New York'")]
        public IWebElement StartDate { get; set; }
    }
}
