Feature: GMTFabricRequisition
	create a new requisition

@mytag

Scenario: Create Requisition for Fabric Booking
	Given Business Unit, Production Unit and Job code
	When Press Enter button 
	Then Job Information is loaded according to the job code

	
	Given Job code is valid
	And required information is provided in the grid
	When click on Save button
	Then new requisition has been created


	Given Fabric Requisition is created
	When A requisition report is displayed and click YES
	Then report will be displayed in another tab