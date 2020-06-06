using NUnit.Framework;
using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.L2_StepDefinitions.Hooks;
using SeleniumSpecFlowFrameWork.L3_SeleniumCode;
using SeleniumSpecFlowFrameWork.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
    class RegisterNewUserSteps
    {
        ShareStateObjects sso;

        public RegisterNewUserSteps(ShareStateObjects _sso)
        {
            this.sso = _sso;

        }

        [Given(@"The user provides email ID to create an account")]
        public void GivenTheUserProvidesEmailIDToCreateAnAccount()
        {
            string email = DataHooks.UserData["newemail"];
            string domain = DataHooks.UserData["newdomain"];
            string emailadd = email + Utils.GetRandomNumber(1000, 9999) + domain;


            RegisterNewUser registerNewUser = new RegisterNewUser(sso);
            registerNewUser.RegisterAccount(emailadd);
            
        }

        [When(@"The user provides the required information and submits for registration")]
        public void WhenTheUserProvidesTheRequiredInformationAndSubmitsForRegistration()
        {
            RegisterNewUser registerNewUser = new RegisterNewUser(sso);
            registerNewUser.FillAccountDetails();
        }

        [Then(@"The user should be able to register successfully")]
        public void ThenTheUserShouldBeAbleToRegisterSuccessfully()
        {
            RegisterNewUser registerNewUser = new RegisterNewUser(sso);
            registerNewUser.CreateAccount();
            Assert.IsTrue(registerNewUser.IsAccountCreated());
        }



    }
}
