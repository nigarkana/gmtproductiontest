Feature: GMTRequisitionSearch
	Search requisition by Requisition ID

Scenario: Search Fabric Requisition ID by Job Code
	Given Job Code in the search field
	When press Enter 
	And Requisition ID is selected
	And click Search button
	Then Information is displayed according to Requisition ID


Scenario: Search Fabric Requisition ID by Requisition ID
	Given Requisition ID
	When click Search button
	Then Information is displayed according to Requisition ID


