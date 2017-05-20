Feature: GMTFabricRequisition
	create a new requisition

Scenario: Create Fabric Booking Requisition
	Given Business Unit, Production Unit and Job code
	And Job Information is loaded according to the job code
	And required information is provided in the grid
	When click on Save button
	Then new requisition has been created