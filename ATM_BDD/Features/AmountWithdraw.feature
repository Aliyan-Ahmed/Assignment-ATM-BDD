Feature: AmountWithdraw
	Withdraw amount from current amount
@mytag
Scenario: Depost amount
	Given Current amount
	And enter option
	And Withdraw amount
	When Validate Pin	 
	Then total current amount