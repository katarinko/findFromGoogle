using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using TestingSearchFromGoogle.Core;
using TestingSearchFromGoogle.Core.Helpers;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Collections.ObjectModel;
using TestingSearchFromGoogle.Pages;
using System.ComponentModel;

namespace TestingSearchFromGoogle.Tests
{
    [TestFixture]
    class PassingTests : BaseTest
    {
        [Test]
            //Check Search result for Selenium IDE export to C#
        public void TestSearchResult()
        {
            //test steps 
            var searchPage = new SearchPage();
            searchPage.TypeText(Data.searchingText);
            searchPage.ClickButton();
            StringAssert.Contains(Data.searchResult, searchPage.GetSearchResultText(), "4 link does not contain Selenium IDE");
        }
    }
}
