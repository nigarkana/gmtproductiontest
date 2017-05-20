Feature: GMTFabricIssue
	Issue Fabric Quantity against Requisition ID

@mytag

Scenario: Issue Fabric Quantity
	Given Requisition ID, Job Code and according to Job Code select Requisition ID
	When write Job Code press Enter then select Requisition or only enter Requistion and press Enter and enter required field and click Save
	Then the result should be shown in the grid and saved successfully



Scenario: Issue Fbaric Search
	Given Requisition ID and Job ID
	When enter Job ID
	Then Result is populated in the grid
