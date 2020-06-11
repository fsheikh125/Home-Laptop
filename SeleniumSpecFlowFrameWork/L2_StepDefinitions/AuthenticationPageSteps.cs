using NUnit.Framework;
using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.L2_StepDefinitions.Hooks;
using SeleniumSpecFlowFrameWork.L3_SeleniumCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
    class AuthenticationPageSteps
    {
        ShareStateObjects sso;

        public AuthenticationPageSteps(ShareStateObjects _sso)
        {
            this.sso = _sso;
        }


        [When(@"I provide valid credentials and submit")]

        public void WhenIProvideValidCredentialsAndSubmit()
        {
            string uname = DataHooks.EnvData["username"];
            string pword = DataHooks.EnvData["password"];
            AuthenticationPage authenticationPage = new AuthenticationPage(sso);
            authenticationPage.Login(uname, pword);
        }


        [When(@"I provide invalid credentials and submit")]
        public void WhenIProvideInvalidCredentialsAndSubmit()
        {
            AuthenticationPage authenticationPage = new AuthenticationPage(sso);
            authenticationPage.Login("abrakh@gmail.com", "aaaaa");
        }


        [Then(@"I should get an authentication failed error")]
        public void ThenIShouldGetAnAuthenticationFailedError()
        {
            Assert.IsTrue(new AuthenticationPage(sso).IsErrorMessageDisplayed());
        }

    }
}

