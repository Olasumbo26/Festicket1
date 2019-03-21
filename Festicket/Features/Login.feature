Feature: Login
	As a registered user of the Festicket
	I would like to Login
	So that I can use the site and Logout

@mytag
Scenario: Valid Login
	Given I Navigate to the site
	When I Click on Login button
	And I enter Email address
	And I enter Password
	And I click on Login
	And I click on User Image
	And I Click Logout
	Then I am Logout

