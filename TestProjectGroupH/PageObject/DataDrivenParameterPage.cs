using OpenQA.Selenium;
using System;
using TestProjectGroupH.Utilities;

namespace TestProjectGroupH.PageObject
{
    class DataDrivenParameterPage
    {

        public DataDrivenParameterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        //IWebElement SignUp => driver.FindElement(By.XPath("//a[@class='nav-link active']"));

        IWebElement Username => driver.FindElement(By.XPath("/ html / body / div / div / div / div / div / div / form / fieldset / fieldset[1] / input"));

        IWebElement Email => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));

        IWebElement Password => driver.FindElement(By.XPath("//input [@type='password']"));

        // IWebElement SignUpButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));

        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));


        //public void ClickOnSignUp()
        //{
        //   SignUp.Click();
        // }

        public void EnterUsername(string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys(username + randomInt);
           // Username.SendKeys(username);
        }

        public bool IsNewArticleButtonDispalyed()
        {
            return NewArticle.Displayed;
        }

        public void NavigateToWebsite(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmail(String emailText)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys(emailText + randomInt + "aol.co.uk");
            Email.SendKeys(emailText);
        }

        public void EnterPassword(String passwordText)
        {
            Password.SendKeys(passwordText);
        }

        // public void ClickOnSignUpButton()
        // {
        //  SignUpButton.Click();
        //  }

    }
}








    

