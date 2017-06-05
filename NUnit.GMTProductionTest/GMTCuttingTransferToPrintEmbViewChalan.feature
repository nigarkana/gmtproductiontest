Feature: GMTCuttingTransferToPrintEmbViewChalan
	GMT Cutting Transfer to Print/Emb View Chalan

@mytag
Scenario: Transfer to Print/Emb View Chalan
	Given URL, User Name, Password, Menu Link, SubMenuLink, Job Code enter
	When Clicking View Challan
	Then Challan is opened in another tab

