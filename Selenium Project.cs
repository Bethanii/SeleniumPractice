using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumPractice
{
    class Program : Methods
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            string printMessage = MethodExample();
            driver.Navigate().GoToUrl("https://accounts.google.com/ServiceLogin/identifier?elo=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("identifierId")).SendKeys("fakepersonemail11@gmail.com");
            driver.FindElement(By.Id("identifierNext")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Name("password")).SendKeys("fakepassword");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(105);
            driver.FindElement(By.Id("passwordNext")).Click();
            driver.FindElement(By.ClassName("gb_C")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://mail.google.com/mail/u/0/?tab=km#inbox");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[1]/div[1]/div/div/div/div[1]/div/div")).Click();
            driver.FindElement(By.XPath("//textarea[@name='to']")).Click();
            driver.FindElement(By.XPath("//textarea[@name='to']")).SendKeys("someone@email.com");
            driver.FindElement(By.XPath("//input[@name='subjectbox']")).SendKeys("Testing Automation");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[1]/div[1]/div/div/div/div[1]/div/div")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div/div[2]/div[1]/div[1]/div[1]/div/div/div/div[1]/div/div")).SendKeys(printMessage);
            
        }
    }
}
