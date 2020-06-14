using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.L3_SeleniumCode;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
    class AddProducttoCartSteps
    {
        ShareStateObjects sso;
        public AddProducttoCartSteps(ShareStateObjects _sso)
        {
            sso = _sso;
        }

        [Given(@"The user adds (.*) from the popular section")]
        public void GivenTheUserAddsBlouseFromThePopularSection(string dressName)
        {
            new AddProducttoCartPage(sso).SelectDress(dressName);
        }

    }
}