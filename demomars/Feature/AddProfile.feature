Feature: AddProfile

As a Seller(user), I want the feature to add user’s Profile Details
So that the people seeking for some skills can look into user details

@demoMars
Scenario: User able to launch the homepage
	Given User able to launch the homepage profile successfully with valid username and password
	And User able to view the homepage profile launched
	When User click on Edit Description
	And User able to edit descriptions
	When User click on Add New “Languages”
	And User able to enter Add Language, select “Choose language level” and click “Add”
	When User click on Add New “Skills”
	And User able to enter Add Skills, select “Choose Skill level” and click “Add”
	When User click on Add New “Education”
	And User able to enter “College/University Name”, select “Country of college/university”, select “Title”, enter “Degree”, select “Year of graduation” and click “Add”
	When User click on Add New “Certifications”
	And User able to enter Certificate or Award, enter Certified from, select “Year” and click “Add”
	When User click on Edit Availability
	And User able to select Availability
	When User click on Edit Hours
	And User able to select Hours
	When User click on Edit Earn Target
	And User able to select Earn Target
	Then User able to see the updated details on homepage profile
	


