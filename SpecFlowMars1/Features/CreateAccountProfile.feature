Feature: CreateAccountProfile

A short summary of the feature
Seller able to join to create a user account

@tag01
Scenario: Seller create account profile
	Given Seller launch homepage
	And Seller enter firstName, lastName, email, password, confirmPassword
	When Seller check terms and conditions 
	And Seller click Join
	Then Seller view account profile page sucessfully
