Feature: RegisterUser

As a user, I will register a new account on the Automation Exercise website

@tag1
Scenario: Register New User Account
	Given I navigate to the Automation Exercise site
	Then I will arrive on the Automation Exercise home page
	When I click on the sign up/ Login link
	Then I will arrive on the signup/login in page
	When I enter my name and email address
		And I click on the signup button
	Then I will arrive on the Account information page
	When I enter the following data
		And Click the create account button
	Then I will arrive on the account confirmation screen
	When I click on the signup / Login link
	Then I will be logged in as my username in the homePage