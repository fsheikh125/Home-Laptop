Feature: Ex05_ShareState
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Template: Add two numbers share state
	Given I have <Initial> items in the basket
	When I add <NoOfItems> items in the basket
	Then I have <Total> items in the basket

Examples:
		| Initial | NoOfItems | Total |
		| 5       | 2         | 7     |
		| 3       | 4         | 7     |
