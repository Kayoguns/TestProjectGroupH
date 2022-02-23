using OpenQA.Selenium;
using TestProjectGroupH.Utilities;

namespace TestProjectGroupH.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.XPath("//a[@class='nav-link active']"));

        IWebElement Username => driver.FindElement(By.XPath("/ html / body / div / div / div / div / div / div / form / fieldset / fieldset[1] / input"));

        IWebElement Email => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));

        IWebElement Password => driver.FindElement(By.XPath("//input [@type='password']"));

        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));

        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));



        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername()
        {
            Username.SendKeys("nelsonolalekan45");
        }

        public bool IsNewArticleButtonDispalyed()
        {
            return NewArticle.Displayed;
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://angularjs.realworld.io/#/register");
        }

        public void EnterEmail()
        {
            Email.SendKeys("nelsonolalekan55@aol.co.uk");
        }

        public void EnterPassword()
        {
            Password.SendKeys("Olalekan@50");
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }

    }
}
