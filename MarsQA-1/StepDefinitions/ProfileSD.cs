using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    class ProfileSD
    {
        private Profile Profileobj;

        public ProfileSD(IWebDriver driver)
        {
            Profileobj = new Profile(driver);
        }

        [Given(@"I am on the profile page")]
        public void GivenIAmOnTheProfilePage()
        {
            Profileobj.ProfileValidate();
        }

        [When(@"I enter an invalid (.*)")]
        public void WhenIEnterAnInvalid(string p0)
        {
            Profileobj.EnterDescription(p0);
        }

        [Then(@"I should see an error message for invalid Description")]
        public void ThenIShouldSeeAnErrorMessageForInvalidDescription()
        {
            Profileobj.ErrorMessage();
        }

        [Then(@"I shouldn't be able to see invalid (.*) in the Profile")]
        public void ThenIShouldnTBeAbleToSeeInvalidInTheProfile(string p0)
        {
            Profileobj.DesValidate(p0);
        }

        [When(@"I click on Add New button in ""(.*)"" section")]
        public void WhenIClickOnAddNewButtonInSection(string p0)
        {
            Profileobj.SkillAdd(p0);
        }

        [When(@"I add the (.*) I have")]
        public void WhenIAddTheiIHave(string p0)
        {
            Profileobj.EnterSkill(p0);
        }

        [When(@"I select Skill (.*) from the drop down")]
        public void WhenISelectSkillLevelFromTheDropDown(string p0)
        {
            Profileobj.SkillLevel(p0);
        }

        [When(@"I click on add button")]
        public void WhenIClickOnAddButton()
        {
            Profileobj.Add();
        }

        [Then(@"A success message should pop up confirming Skill added")]
        public void ThenASuccessMessageShouldPopUpConfirmingSkillAdded()
        {
            Profileobj.SuccessMsg();
        }
        
        [Then(@"I should see entered (.*) in Skills section")]
        public void ThenIShouldSeeEnteredInSkillsSection(string p0)
        {
            Profileobj.SkillValidate(p0);
        }

        [When(@"I click on edit button in ""(.*)"" section")]
        public void WhenIClickOnEditButtonInSection(string p0)
        {
            Profileobj.SkillEditClick();
        }

        [When(@"I edit the Skill with (.*)")]
        public void WhenIEditTheSkillWith(string p0)
        {
            Profileobj.EditSkill(p0);
        }

        [When(@"I click on update button")]
        public void WhenIClickOnUpdateButton()
        {
            Profileobj.SkillUpdate();
        }

        [Then(@"A success message should pop up confirming Skill edited")]
        public void ThenASuccessMessageShouldPopUpConfirmingSkillEdited()
        {
            Profileobj.EditSuccessMsg();
        }

        [Then(@"I should see updated Skill (.*) in the Profile")]
        public void ThenIShouldSeeUpdatedSkillInTheProfile(string p0)
        {
            Profileobj.EditSkillValidate(p0);
        }

        [When(@"I click on delete button in ""(.*)"" section")]
        public void WhenIClickOnDeleteButtonInSection(string p0)
        {
            Profileobj.DeleteSkill();
        }

        [Then(@"A success message should pop up confirming Skill deleted")]
        public void ThenASuccessMessageShouldPopUpConfirmingSkillDeleted()
        {
            Profileobj.DeleteSuccessMsg();
        }

        [Then(@"I should see Skill (.*) deleted from the Profile")]
        public void ThenIShouldSeeSkillDeletedFromTheProfile(string p0)
        {
            Profileobj.DeleteSkillValidate(p0);
        }

        [When(@"I click on Add New button in Education section")]
        public void WhenIClickOnAddNewButtonInEducationSection()
        {
            Profileobj.AddNewEducationBtn();
        }

        [When(@"I add the College/University name I have studied in")]
        public void WhenIAddTheCollegeUniversityNameIHaveStudiedIn()
        {
            Profileobj.CollegeName();
        }

        [When(@"I select Country of college/university from the drop down")]
        public void WhenISelectCountryOfCollegeUniversityFromTheDropDown()
        {
            Profileobj.CountryName();
        }

        [When(@"I select Title from the drop down")]
        public void WhenISelectTitleFromTheDropDown()
        {
            Profileobj.TitleName();
        }

        [When(@"I add name of my degree")]
        public void WhenIAddNameOfMyDegree()
        {
            Profileobj.DegreeName();
        }

        [When(@"I select Year of graduation from the drop down")]
        public void WhenISelectYearOfGraduationFromTheDropDown()
        {
            Profileobj.YearofGradName();
        }

        [When(@"I click on Education add button")]
        public void WhenIClickOnEducationAddButton()
        {
            Profileobj.AddEducation();
        }

        [Then(@"A success message should pop up confirming Education added")]
        public void ThenASuccessMessageShouldPopUpConfirmingEducationAdded()
        {
            Profileobj.AddEduSuccessMsg();
        }

        [Then(@"I should see entered Education in the Profile")]
        public void ThenIShouldSeeEnteredEducationInTheProfile()
        {
            Profileobj.EducationValidate();
        }

        [When(@"I click on edit button in Education section")]
        public void WhenIClickOnEditButtonInEducationSection()
        {
            Profileobj.EducationEditBtn();
        }

        [When(@"I update the (.*) with (.*)")]
        public void WhenIUpdateTheWith(string p0, string p1)
        {
            Profileobj.EditEducation(p0, p1);
        }

        [When(@"I click on Education update button")]
        public void WhenIClickOnEducationUpdateButton()
        {
            Profileobj.EditUpdateEdu();
        }

        [Then(@"A success message should pop up confirming Education edited")]
        public void ThenASuccessMessageShouldPopUpConfirmingEducationEdited()
        {
            Profileobj.EduEditSuccessMsg();
        }

        [Then(@"I should see updated Education (.*) in the Profile")]
        public void ThenIShouldSeeUpdatedEducationInTheProfile(String p0)
        {
            Profileobj.EditEducationValidate(p0);
        }

        [When(@"I click on delete button in Education section")]
        public void WhenIClickOnDeleteButtonInEducationSection()
        {
            Profileobj.DeleteEducation();
        }

        [Then(@"A success message should pop up confirming Education deleted")]
        public void ThenASuccessMessageShouldPopUpConfirmingEducationDeleted()
        {
            Profileobj.EduDeleteSuccessMsg();
        }

        [Then(@"I should see Education (.*) deleted from the Profile")]
        public void ThenIShouldSeeEducationDeletedFromTheProfile(String DeletedEducation)
        {
            Profileobj.DeleteEducationValidate(DeletedEducation);
        }
    }
}
