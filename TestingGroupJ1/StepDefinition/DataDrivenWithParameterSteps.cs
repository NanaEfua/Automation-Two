using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestingGroupJ1.PageObject;

namespace TestingGroupJ1.StepDefinition
{
    [Binding]


    public class DataDrivenWithParameterSteps
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }





        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }
        
        [Given(@"I click on Sign up")]
        public void GivenIClickOnSignUp()
        {
            dataDrivenWithParameterPage.ClickOnSignUp();
        }
        
        [Given(@"I enter my Username ""(.*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }
        
        [Given(@"I enter email ""(.*)""")]
        public void GivenIEnterEmail(string email)
        {
            dataDrivenWithParameterPage.EnterEmail(email);
        }
        
        [Given(@"I enter password ""(.*)""")]
        public void GivenIEnterPassword(string password)
        {
            dataDrivenWithParameterPage.EnterPassword(password);
        }
        
        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            dataDrivenWithParameterPage.ClickOnSignUpButton();
        }
        
        [Then(@"I can register successfully")]
        public void ThenICanRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(dataDrivenWithParameterPage.IsNewArticleDisplayed);
        }
    }
}
