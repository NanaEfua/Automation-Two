Feature: DataDrivenWithParameter
	To benefit from the website, I need to register first

@mytag
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And I enter my Username "EfuaBo"
	And I enter email "nana"
	And I enter password "1234"
	When I click on sign up button
	Then I can register successfully