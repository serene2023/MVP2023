Feature: Login

A short summary of the feature
Seller Login to homepage -> http://localhost:5000/

@tag02
Scenario: Seller Login to Homepage
	Given Seller launch homepage
	And Seller enter username and password
	When Seller click Login
	Then Seller view account profile successfully
