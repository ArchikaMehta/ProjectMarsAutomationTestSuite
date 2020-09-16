Feature: Add Profile Details
	Priority: Major
	As a Seller
	I want the feature to add my Profile Details
	So that
	The people seeking for some Skills can look into my details

Background: 
	Given I navigate to the application portal
	When I login using valid credentials
	
Scenario Outline: Adding Description passed with valid data
	Given I am on the profile page
	When I enter a valid <Description> 
	And I click on Save button
	Then A success message should pop up confirming Description added
	And I should see entered Description in the Profile
	# Valid Description starting from alphabet or number
	Examples:
	| Description |
	| abcdefghi   |
	| 123456789   |

Scenario Outline: Adding Description failed with invalid data
	Given I am on the profile page
	When I enter an invalid <Description> 
	Then I should see an error message for invalid Description
	And I shouldn't be able to see invalid Description in the Profile
	# Invalid Description starting from special character, zero, space or blank value
	Examples: 
	| Description |
	| $123456789  |
	| 0123456789  |
	|  abcdefghi  |
	|             |

Scenario Outline: Add Language in the Profile 
	Given I am on the profile page
	When I click on Add New button in "Language" section
	And I add the <Language> I speak
	And I select language level from the drop down 
	And I click on add button
	Then A success message should pop up confirming Language added
	And I should see entered Language in the Profile	
	# Valid Language starting from alphabet, number, special character, space or zero
	Examples: 
	| Language  |
	| abcdefghi |
	| @abcdefgh |
	|  abcdefgh |
	| 012345678 |
														
Scenario Outline: Edit Language in the Profile 
	Given I am on the profile page
	And There is already "Language" available to "Edit"
	When I click on edit button in "Language" section
	And I update the <Field> with <Value> 
	And I click on update button
	Then A success message should pop up confirming Language edited
	And I should see updated Language in the Profile
	Examples: 
	| Field     | Value   | 
	| Language  |         |        
	| Level     |         |        

Scenario: Delete Language in the Profile 
	Given I am on the profile page
	And There is already "Language" available to "Delete"
	When I click on delete button in "Language" section
	Then A success message should pop up confirming Language deleted
	And I should see Language deleted from the Profile

Scenario Outline: Adding Language failed with blank data
	Given I am on the profile page
	When I click on Add New button in "Language" section
	And I left the <Field> blank
	And I click on add button
	Then I should see an error message for invalid Language
	And I shouldn't be able to add Language
	Examples: 
	| Field    |
	| Language |
	| Level    |
	
Scenario: New Language addition failed after 4 entries
	Given I am on the profile page
	When I click on Add New button in "Language" section
	And I add the Language I speak
	And I select language level from the drop down 
	And I click on add button
	Then A success message should pop up confirming Language added
	And I should see entered Language in the Profile
	# As only maximum of four selections are allowed in Language section 
	But The add new button should be disappear after 4 entries

Scenario Outline: Add Skills in the Profile 
	Given I am on the profile page
	When I click on Add New button in "Skills" section
	And I add the <Skill> I have
	And I select Skill level from the drop down 
	And I click on add button
	Then A success message should pop up confirming Skill added
	And I should see entered Skill in the Profile
	# Valid Skill starting from alphabet, number, special character, space or zero
	Examples: 
	| Skill     |
	| abcdefghi |
	| 123456789 |
	| @abcdefgh |
	|  abcdefgh |
	| 012345678 |
	
Scenario Outline: Edit Skills in the Profile 
	Given I am on the profile page
	And There is already "Skill" available to "Edit"
	When I click on edit button in "Skills" section
	And I update the <Field> with <Value> 
	And I click on update button
	Then A success message should pop up confirming Skill edited
	And I should see updated Skill in the Profile
	Examples: 
	| Field     | Value  | 
	| Skill     |        |        
	| Level     |        |  

Scenario: Delete Skills in the Profile 
	Given I am on the profile page
	And There is already "Skill" available to "Delete"
	When I click on delete button in "Skills" section
	Then A success message should pop up confirming Skill deleted
	And I should see Skill deleted from the Profile

Scenario Outline: Adding Skills failed with blank data
	Given I am on the profile page
	When I click on Add New button in "Skills" section
	And I left the <Field> blank
	And I click on add button
	Then I should see an error message for invalid Skill
	And I shouldn't be able to add Skill
	Examples: 
	| Field    |
	| Skill    |
	| Level    |	

Scenario: Add Education in the Profile 
	Given I am on the profile page
	When I click on Add New button in "Education" section
	And I add the College/University name I have studied in
	And I select Country of college/university from the drop down 
	And I select Title from the drop down
	And I add name of my degree
	And I select Year of graduation from the drop down
	And I click on add button
	Then A success message should pop up confirming Education added
	And I should see entered Education in the Profile
	
Scenario Outline: Edit Education in the Profile 
	Given I am on the profile page
	And There is already "Education" available to "Edit"
	When I click on edit button in "Education" section
	And I update the <Field> with <Value>
	And I click on update button
	Then A success message should pop up confirming Education edited
	And I should see updated Education in the Profile
	Examples: 
	| Field           | Value  |
	| Country         |        |
	| University      |        |
	| Title           |        |
	| Degree          |        |
	| Graduation Year |        |

Scenario: Delete Education in the Profile 
	Given I am on the profile page
	And There is already "Education" available to "Delete"
	When I click on delete button in "Education" section
	Then A success message should pop up confirming Education deleted
	And I should see Education deleted from the Profile

Scenario Outline: Adding Education failed with blank data
	Given I am on the profile page
	When I click on Add New button in "Education" section
	And I left the <Field> blank
	And I click on add button
	Then I should see an error message for invalid Education
	And I shouldn't be able to add Education
	Examples: 
	| Field            |
	| Country          |
	| University       |
	| Title			   |
	| Degree		   |
	| Graduation Year  |

Scenario: Add Certification in the Profile 
	Given I am on the profile page
	When I click on Add New button in "Certification" section
	And I add the Certification/Award I have
	And I add Certificate received from
	And I select year of receiving certificate from the drop down 
	And I click on add button
	Then A success message should pop up confirming Certification added
	And I should see entered Certification in the Profile
	
Scenario Outline: Edit Certification in the Profile 
	Given I am on the profile page
	And There is already "Certification" available to "Edit"
	When I click on edit button in "Certification" section
	And I update the <Field> with <Value>
	And I click on update button
	Then A success message should pop up confirming Certification edited
	And I should see updated Certification in the Profile
	Examples: 
	| Field        | Value  |
	| Certificate  |        |
	| From         |        |
	| Year         |        |
	
Scenario: Delete Certification in the Profile 
	Given I am on the profile page
	And There is already "Certification" available to "Delete"
	When I click on delete button in "Certification" section
	Then A success message should pop up confirming Certification deleted
	And I should see Certification deleted from the Profile

Scenario Outline: Adding Certification failed with blank data
	Given I am on the profile page
	When I click on Add New button in "Certification" section
	And I left the <Field> blank
	And I click on add button
	Then I should see an error message for invalid Certification
	And I shouldn't be able to add Certification
	Examples: 
	| Field        |
	| Certificate  |
	| From         |
	| Year  	   |
	
Scenario: Validate First and last name on the Profile page
	Given I am on the profile page
	Then I should see the First and last name which I used while signing up
	| FirstName | LastName |
	| Archika   | Mehta    |

Scenario Outline: Edit First or Last name on the Profile page
	Given I am on the profile page
	When I click on the drop down next to username
	And I update the <Name> with <Value> 
	And I click on Save button
	Then I should see updated name in the profile
	Examples: 
	| Name      | Value |
	| FirstName |       |
	| LastName  |       |

Scenario: Add Availability in the Profile
	Given I am on the profile page
	When I select "Availability" option from the drop down
	Then I should see "Availability" updated in the profile

Scenario: Add Hours in the Profile
	Given I am on the profile page
	When I select "Hours" option from the drop down
	Then I should see "Hours" updated in the profile

Scenario: Add Earn Target in the Profile
	Given I am on the profile page
	When I select "Earn Target" option from the drop down
	Then I should see "Earn Target" updated in the profile

