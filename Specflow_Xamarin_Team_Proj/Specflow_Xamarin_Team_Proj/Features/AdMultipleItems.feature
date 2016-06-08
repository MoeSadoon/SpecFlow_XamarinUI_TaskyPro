Feature: AdMultipleItems
	In order to keep track of tasks.

@mytag
Scenario: Add Multiple Tasks
	Given a list of tasks
	| taskName                | taskNote                                 |
	| Pick up kids from school | Get kids from school at 3:30pm       |
	| Post letter              | Post Letter to granny at post office |
	| Talk to Phone Company    | EE overcharged me!!!                 |

	When I press add the list of tasks

	Then the tasks will appear on home screen

