Feature: AmountDepost
	Depost amount in current amount
@mytag
Scenario: Current amount after Depost
	Given Account amount
	And Enter choice
	And Depost amount
	When Validate the Pin	 
	Then Current amount