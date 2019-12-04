using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;
using TestingSearchFromGoogle.Core;
using static System.Net.Mime.MediaTypeNames;

namespace TestingSearchFromGoogle.Pages
{
    public class SearchPage
    {
        By FielForSearchingText = By.XPath("//input[@name='q']");
        By SearchButtonLocator = By.XPath("//input[@name='btnK']");
        By SearchResultLocator = By.XPath("//span[@class='S3Uucc']");

        public SearchPage TypeText(string text)
        {
            Element.WaitUntilDisplayed(FielForSearchingText, 5000);
            Element.InputText(FielForSearchingText, text);
            return this;
        }
        public SearchPage ClickButton()
        {
            Element.WaitUntilDisplayed(SearchButtonLocator, 5000);
            Element.Click(SearchButtonLocator);
            return this;
        }
        public string GetSearchResultText()
        {
            Element.WaitUntilDisplayed(SearchResultLocator, 5000);
            return Element.FindElements(SearchResultLocator)[3].Text;
        }

        public SearchPage ClickLink()
        {
            Element.WaitUntilDisplayed(SearchResultLocator, 5000);
            Element.Click(SearchResultLocator);
            return this;
        }

    }

}
