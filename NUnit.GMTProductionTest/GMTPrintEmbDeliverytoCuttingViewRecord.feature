Feature: GMTPrintEmbDeliverytoCuttingViewRecord
	GMT Production - Print/Emb - Delivery to Cutting - View Records

@mytag
Scenario: Delivery to Cutting -View Records
	Given Login, Menu, SubMenu link, Job Code
	When Click Search, Edit, Enter QC Pass, Reject, Remarks from Edit Mode
	Then Information edited successfully
