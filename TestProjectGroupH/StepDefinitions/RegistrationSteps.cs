using NUnit.Framework;
using TechTalk.SpecFlow;
using TestProjectGroupH.PageObject;

namespace TestProjectGroupH.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationpage;

        public RegistrationSteps()
        {
            registrationpage = new RegistrationPage();
        }



        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationpage.NavigateToWebsite();
        }

        [Given(@"I click on Sign up button")]
        public void GivenIClickOnSignUpButton()
        {
            registrationpage.ClickOnSignUp();
        }

        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            registrationpage.EnterUsername();
        }

        [Given(@"I enter my Email")]
        public void GivenIEnterMyEmail()
        {
            registrationpage.EnterEmail();
        }

        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            registrationpage.EnterPassword();
        }

        [When(@"I click on Sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            registrationpage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to sign up successfully")]
        public void ThenIShouldBeAbleToSignUpSuccessfully()
        {
            Assert.That(registrationpage.IsNewArticleButtonDispalyed);
        }

    }
}
