Feature: GMTCuttingTransferToPrinEmb
	Transfer to Print/Emb (Add Record.)

@mytag
Scenario: Transfer to Print/Emb (Add Record)  
	Given URL Login, Transfer to Print/Emb link, Job Code
	When I press Enter
	Then Grid is loaded with all Cutting Id according to the Job
	Given Send for Emb, Remarks
	And in Description give Manual Challan Ref, Body Part per Gmt, Body Part Description, Note
	And in Send To Search by Name or Select Employee
	When Click Save
	Then Print/Emb Send Successfully

