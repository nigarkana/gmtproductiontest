Feature: GMTCutting-InputToSewingLineViewRecord
	Cutting -> Input to Sewing Line -> View Record

@mytag
Scenario: Input to Sewing Line -> View/Edit Record
	Given Login Link, Menu-SubMenu Link, Job Code
	When Click Search button, Click Edit Button, Change Issue Qty and update other information
	Then Sewing Line issue updated successfully
