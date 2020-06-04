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
            string emailadd = DataHooks.EnvData["newemail"];
            string domain = DataHooks.EnvData["newdomain"];


            RegisterNewUser registerNewUser = new RegisterNewUser(sso);
            registerNewUser.RegisterAccount(emailadd, domain);
            
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
