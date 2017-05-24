Feature: GMTCuttingTransferToPrintViewRecord
	GMT Cutting Transfer to Print/Emb View Record

@mytag
Scenario: GMT Cutting Transfer to Print/Emb View Record
	Given Url, UserName, Password,Job Code
	When press Search
	Then Grid is loaded
	When click EDIT 
	Then Send for Emb form is opened
	Given update all required information if needed
	When press Update
	Then Transfer to Print/Emb is saved successfully
