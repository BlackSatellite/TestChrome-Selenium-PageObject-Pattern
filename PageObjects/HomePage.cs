using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestChrome.PageObjects
{
    class HomePage
    {
        // Иконка выбора языка на странице
        [FindsBy(How = How.CssSelector, Using = "[data-id='language_selector']")]
        public IWebElement LanguageSelection { get; set; }

        // Выбор Английского США (English US)
        [FindsBy(How = How.CssSelector, Using = "span[lang='en-us']")]
        public IWebElement EnglishLanguageSelection { get; set; }

        // Строка для ввода текста поиска
        [FindsBy(How = How.CssSelector, Using = "input[type='search']")]
        public IWebElement TextSearchForm { get; set; }

        // Поле даты въезда и выезда #frm > div.xp__fieldset.accommodation
        [FindsBy(How = How.CssSelector, Using = "[data-component='search/dates/date-field-select']")]
        public IWebElement DateSearchForm { get; set; }

        // Стрелка вправо по датам
        [FindsBy(How = How.XPath, Using = @"//div[@class='bui-calendar__control bui-calendar__control--next']")]
        public IWebElement DateArrowRight { get; set; }

        // Дата начала 1 Мая
        [FindsBy(How = How.CssSelector, Using = "[data-date='2020-05-01']")]
        
        public IWebElement DateStart { get; set; }

        // Дата окончания 30 Мая
        [FindsBy(How = How.CssSelector, Using = "[data-date='2020-05-30']")]
        public IWebElement DateEnd { get; set; }

        // Кнопка поиск
        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        public IWebElement ButtonSearchForm { get; set; }
    }
}
