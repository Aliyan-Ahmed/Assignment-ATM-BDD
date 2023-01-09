Feature: CurrentAmount
check the current amount
@tag1
Scenario: Check the current amount
	Given current amount
	And account option
	When valid pin
	Then the current amount
