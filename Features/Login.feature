Feature: Log In Automation
	Login to EA Demo application

@smoke
Scenario: Perform Login of EA Application site

#steps
	Given I launch the application
	And I click login link 
	And I enter the following details
	| UserName | Password |
	| woodrow    | Lacie@7402   |
	And I click login button
	Then I should see Employee details link
	
@smoke
	Scenario: Login Logoff

	#Steps
	Given I launch the application
	And I click login link 
	And I enter the following details
	| UserName | Password |
	| woodrow    | Lacie@7402   |
	And I click login button
	And I click the log off button
	Then I close browser