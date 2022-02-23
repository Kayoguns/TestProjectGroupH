Feature: Registration
	In order to remove the benefit on the website
	I will need to first registered


@mytag
 Scenario: Valid Registration
    Given I navigate to the website 
	And  I click on Sign up button
	And  I enter my Username 
	And  I enter my Email
	And  I enter my Password
	When I click on Sign up button
	Then I should be able to sign up successfully