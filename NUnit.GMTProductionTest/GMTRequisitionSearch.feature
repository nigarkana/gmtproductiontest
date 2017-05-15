Feature: GMTRequisitionSearch
	Search requisition by Requisition ID

Scenario: Go To Requisition Form
	Given URL, UserName and Password
	When Click Fabric, Requisition
	Then Fabric Requistion form will be opened


Scenario: Search by Requisition ID
	Given Job Code in the search field
	When press Enter All requisition is displayed according to the Job Code and select one of the requisition
	Then Result should be shown according to the search


	Scenario: Search by Invalid Requisition ID
	Given wrong Requisition ID
	When click Search button
	Then Result should be displayed a message for invalid or wrong Requisition ID


