Feature: Login_Feature
	In order to access my account
	As a user of the website
	I want to log into the website

@mytag
Scenario: Successful with valid credential
	Given User is at the Home Page
	Given Navigate to Login Page
	When User enter <email> and <pass>
	Then user can login successfully
	