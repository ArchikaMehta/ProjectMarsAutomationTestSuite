using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace MarsQA_1.SpecflowPages.Pages
{
    internal class Profile : Driver
    {
        public Profile(IWebDriver driver): base(driver)
        {

        }

        //Web element for Profile validation
        private IWebElement Descriptionbtn => _driver.FindElement(By.CssSelector("h3.ui.dividing.header"));
        
        internal void ProfileValidate()
        {
            //Validating Profile
            Assert.IsTrue(Descriptionbtn.Text.Contains("Description"));
        }

        //Variables for saving the text of Description before and after edit
        String BeforeEdit;
        String AfterEdit;

        //Web element for Description edit button, text box and save button
        private IWebElement DesEditBtn => _driver.FindElement(By.CssSelector("span.button"));
        private IWebElement DesEdit => _driver.FindElement(By.Name("value"));
        private IWebElement SaveDes => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
        
        internal void EnterDescription(String Description)
        {
            //Waiting for page to load with Description tab
            WaitClickable(_driver, "XPath", ("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"), 10);
            //Saving already available Description text into a String before edit
            BeforeEdit = DesText.Text;
            //Click on Description edit button
            DesEditBtn.Click();
            //Remove already available data from text area
            DesEdit.SendKeys(Keys.Control + "a");
            DesEdit.SendKeys(Keys.Delete);
            //Enter Description
            DesEdit.SendKeys(Description);
            //Save Description
            SaveDes.Click();
        }

        //Web element for Error message
        private IWebElement Errormsg => _driver.FindElement(By.CssSelector("div.ns-box.ns-growl.ns-effect-jelly.ns-type-error.ns-show"));

        internal void ErrorMessage()
        {
            //Wait for error message to appear
            WaitClickable(_driver, "CssSelector", ("div.ns-box.ns-growl.ns-effect-jelly.ns-type-error.ns-show"), 5);
            //Comparing error message appeared
            Assert.IsTrue(Errormsg.Text.Contains("First character can only be digit or letters") || Errormsg.Text.Contains("Please, a description is required"));
        }

        //Web element for already available Description text
        private IWebElement DesText => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"));

        internal void DesValidate(String Description)
        {
            //Refreshing the web page
            _driver.Navigate().Refresh();
            //Wait for page to load with Description tab
            WaitClickable(_driver, "XPath", ("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"), 10);
            //Saving already available Description text into a String after edit
            AfterEdit = DesText.Text;
            //Comparing befor and after edit Description data for validation
            Assert.IsTrue(BeforeEdit.Equals(AfterEdit));
        }

        //Web elements for Skill tab and Add new button in Skill section
        private IWebElement SkillTab => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private IWebElement SkillAddNewBtn => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
                                                                                
        internal void SkillAdd(String Skills)
        {
            //Click on Skill tab
            SkillTab.Click();
            //Click on add new button in Skill section
            SkillAddNewBtn.Click();
        }

        //Web element for Add skill text box
        private IWebElement AddSkill => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));

        internal void EnterSkill(String Skill)
        {
            //Enter skill for adding in Profile
            AddSkill.SendKeys(Skill);
        }

        //Web element for Skill level select drop down
        private IWebElement LevelSelected => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));

        internal void SkillLevel(String SkillLevel)
        {
            //Select level from drop down
            LevelSelected.SendKeys(SkillLevel);
        }

        //Web element for Skill add button
        private IWebElement AddnBtn => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));

        internal void Add()
        {
            //Click on add button
            AddnBtn.Click();
            //Wait for page to load with added skills
            WaitClickable(_driver, "CssSelector", ("div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);
        }

        //Web element for Success message and for message close button
        private IWebElement Message => _driver.FindElement(By.CssSelector("div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"));
        private IWebElement MessageClose => _driver.FindElement(By.CssSelector("a.ns-close"));
        
        internal void SuccessMsg()
        {
            //Comparing success message text for skill add  
            Assert.IsTrue(Message.Text.Contains("has been added to your skills"));
            //Close success message
            MessageClose.Click();
        }

        //Web element for Skill table 
        private IWebElement SkillVal => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));

        internal void SkillValidate(String Skill)
        {
            //Comparing Skill table content for Skill add validation
            Assert.IsTrue(SkillVal.Text.Contains(Skill));
        }

        //Web element for Skill edit button
        private IWebElement SkillEditBtn => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));

        internal void SkillEditClick()
        {
            //Click on edit button 
            SkillEditBtn.Click();
        }

        private IWebElement SkillEdit => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));

        internal void EditSkill(String EditedSkill)
        {
            //Clear already available skill text
            SkillEdit.Clear();
            //Enter edit value for skill
            SkillEdit.SendKeys(EditedSkill);
        }

        //Web element for update button in skill section
        private IWebElement SkillUpdateBtn => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));

        internal void SkillUpdate()
        {
            //Click on update button
            SkillUpdateBtn.Click();
            //Wait for page to load with updated skill
            WaitClickable(_driver, "CssSelector", ("div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);
        }

        internal void EditSuccessMsg()
        {
            //Comparing success messgae text for skill update
            Assert.IsTrue(Message.Text.Contains("has been updated to your skills"));
            //Close success message
            MessageClose.Click();
        }

        internal void EditSkillValidate(String EditedSkill)
        {
            //Comparing Skill table content for Skill edit validation
            Assert.IsTrue(SkillVal.Text.Contains(EditedSkill));
        }

        //Web element for delete button in skill section
        private IWebElement DelSkill => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]"));

        internal void DeleteSkill()
        {
            //Click on delete button
            DelSkill.Click();
            //Wait for the page loading with deleted skill 
            WaitClickable(_driver, "CssSelector", ("div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);
        }

        internal void DeleteSuccessMsg()
        {
            //Comparing success messgae text for skill
            Assert.IsTrue(Message.Text.Contains("has been deleted"));
            //Close success message
            MessageClose.Click();
        }

        internal void DeleteSkillValidate(String DeletedSkill)
        {
            //Comparing Skill table content for Skill delete validation
            Assert.IsTrue(!SkillVal.Text.Contains(DeletedSkill));
        }
        
        // Web elements for Education tab and add new button in education section
        private IWebElement EduTabBtn => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        private IWebElement AddNewEduBtn => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));

        internal void AddNewEducationBtn()
        {
            //Click on Education tab
            EduTabBtn.Click();
            //Click on add new button
            AddNewEduBtn.Click();
        }

        //Web element for College/University name
        private IWebElement CollegeNameTBox => _driver.FindElement(By.Name("instituteName"));
        //Variable for institute name
        String instituteName = "Oxford University";

        internal void CollegeName()
        {
            //Enter College/University name
            CollegeNameTBox.SendKeys(instituteName);
        }

        //Web element for Country name selection from drop down list
        SelectElement CountryNameTBox => new SelectElement(_driver.FindElement(By.Name("country")));
        //Variable for country name
        String country = "United Kingdom";

        internal void CountryName()
        {
            //Enter country name
            CountryNameTBox.SelectByText(country);
        }

        //Web element for Title selection from drop down list
        SelectElement TitleNameTBox => new SelectElement(_driver.FindElement(By.Name("title")));
        //Variable for title
        String title = "B.Tech";

        internal void TitleName()
        {
            //Emter title
            TitleNameTBox.SelectByText(title);
        }

        //Web element for Degree name 
        private IWebElement DegreeNameTBox => _driver.FindElement(By.Name("degree"));
        //Variable for Degree name
        String degree = "Electronics and Communication";
        //Variable for unique record creation using time stamp
        String UniqueRecord;

        internal void DegreeName()
        {
            //Time stamp
            UniqueRecord= (DateTime.Now.ToString("yyyyMMddHHmmssfff"));
            //Enter Degree name
            DegreeNameTBox.SendKeys(degree + UniqueRecord);
        }

        //Web element for Year Of Graduation selection from drop down list
        SelectElement YrofGradNameTBox => new SelectElement(_driver.FindElement(By.Name("yearOfGraduation")));
        //Variable for Year Of Graduation 
        String yearOfGraduation = "2012";

        internal void YearofGradName()
        {
            //Enter Year Of Graduation
            YrofGradNameTBox.SelectByText(yearOfGraduation);
        }

        //Web element for add button 
        private IWebElement AddEduBtn => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        
        internal void AddEducation()
        {
            //Click on add button
            AddEduBtn.Click();
            //Wait for page to load with added Education
            WaitClickable(_driver, "CssSelector", ("div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);
        }

        internal void AddEduSuccessMsg()
        {
            //Comapring success message for Education add
            Assert.IsTrue(Message.Text.Contains("Education has been added"));
            //Close success message
            MessageClose.Click();
        }

        //Web element for Education table
        private IWebElement EduVal => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table"));

        internal void EducationValidate()
        {
            //Comparing Education table content for Education add validation
            Assert.IsTrue(EduVal.Text.Contains(instituteName));
        }

        //Web element for edit button in Education section
        private IWebElement EduEditBtn => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]"));

        internal void EducationEditBtn()
        {
            //Click on edit button
            EduEditBtn.Click();
        }

        internal void EditEducation(String Field, String Value)
        {
            //Implemented Switch-case to handle multiple conditions using a single function
            switch(Field)
            {
                case "University":
                    //Clear already existed data and enter new value for institute name
                    CollegeNameTBox.Clear();
                    CollegeNameTBox.SendKeys(Value);
                    break;

                case "Country":
                    //Enter new value for country name
                    CountryNameTBox.SelectByText(Value); 
                    break;

                case "Title":
                    //Enter new value for title
                    TitleNameTBox.SelectByText(Value);
                    break;

                case "Degree":
                    //Clear already existed data and enter new value for degree name
                    DegreeNameTBox.Clear();
                    DegreeNameTBox.SendKeys(Value);
                    break;

                case "Graduation Year":
                    //Enter new value for Year of Graduation
                    YrofGradNameTBox.SelectByText(Value);
                    break;
            }
        }

        //Web element for update button in education section
        private IWebElement EduUpdateBtn => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));

        internal void EditUpdateEdu()
        {
            //Click on update button
            EduUpdateBtn.Click();
            //Wait for the page to laod with edited Education
            WaitClickable(_driver, "CssSelector", ("div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);
        }

        internal void EduEditSuccessMsg()
        {
            //Comparing success message for Education edit
           Assert.IsTrue(Message.Text.Contains("Education as been updated"));
        }

        internal void EditEducationValidate(String EditedEducation)
        {
            //Comparing Education table content for Education edit validation
            Assert.IsTrue(EduVal.Text.Contains(EditedEducation));
            //Close success messgae
            MessageClose.Click();
        }

        //Web element for delete button in education section
        private IWebElement DelEdu => _driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));

        internal void DeleteEducation()
        {
            //Click on delete button
            DelEdu.Click();
            //Wait for the page to laod with deleted Education
            WaitClickable(_driver, "CssSelector", ("div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);
        }

        internal void EduDeleteSuccessMsg()
        {
            //Comparing success message for Education delete
            Assert.IsTrue(Message.Text.Contains("Education entry successfully removed"));
            //Close success message
            MessageClose.Click();
        }

        internal void DeleteEducationValidate(String DeletedEducation)
        {
            //Comparing Education table content for Education delete validation
            Assert.IsTrue(!EduVal.Text.Contains(DeletedEducation));
        }
    }
}
