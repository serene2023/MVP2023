Feature: AddSellerProfileDetails

Seller🡪Add Profile Details @ http://localhost:5000/
As a Seller, I want the feature to add Seller’s Profile Details
So that the people seeking for some skills can look into Seller details


@tag03
Scenario: Seller Login to Homepage
	Given Seller launch homepage
	And Seller enter username and password
	When Seller click Login
	Then Seller view account profile successfully

Scenario: Seller create Descriptions
	Given Seller add Descrptions
	And Seller click edit Decriptions function
	When Seller enter description
	Then Seller click Save function

Scenario: Seller create Lanaguages
	Given Seller add Languages
	And Seller click Add New function, enter <Add Languages>
	When Seller select “Choose Language Level”
	Then Seller click Add function
	
Scenario: Seller create Skills
	Given Seller add Skills
	And Seller click Add New function, enter <Add Skills>
	When Seller select “Choose Skill Level”
	Then Seller click Add function

Scenario: Seller create Education
	Given Seller add Education
	And Seller click Add New function, enter <College/University Name>, select "Country", "Title", enter <Degree>
	When Seller select “Year of graduation”
	Then Seller click Add function

Scenario: Seller create Certification
	Given Seller add Certification
	And Seller click Add New function, enter <Certificate or Award>, <Certified From (e.g. Adobe)>
	When Seller select “Year”
	Then Seller click Add function

Scenario: Seller create Location
	Given Seller add Location
	And Seller click Edit Location function
	When Seller select "Availability", "Hours", "Earn Target"
	Then Seller view updated account profile page