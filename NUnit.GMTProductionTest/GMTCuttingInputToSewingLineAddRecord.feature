Feature: GMTCuttingInputToSewingLine
	Input to Sewing Line 

@mytag
   Scenario: Cutting -> Input to Sewing Line
	Given Login, Menu-SubMenu, Job Code, Select Employee, Business Unit, Production Unit, Production Line, issue Qty
	When Press Enter, click Save to issue
	Then Gird loaded successfully


	

