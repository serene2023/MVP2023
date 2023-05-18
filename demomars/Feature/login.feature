Feature: login

A short summary of the feature
Seller🡪Add Profile Details
homepage -> http://localhost:5000/

@demoMars
Scenario: [Seller login to homepage]
	Given User should be able to launch the homepage
	And User should be able to enter <username> and <password> credentials and click "Sign in"
	|username		     |password|
	|serene.ng3@gmail.com|abc123  |
	Then User should be able to view the homepage profile launched successfully
