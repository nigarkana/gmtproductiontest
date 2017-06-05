Feature: GMTPrintEmbDeliveryToCuttingAddRecord
	GMT Print/Emb Delivery to Cutting ->Add Record

@mytag
Scenario: Print/Embb Delivery to Cutting - Add Record
	Given Login Information, Menu Link and other information
	When Enter Job Code and press ENTER from keyboard, enter value of QC Pass, Reject, Remarks and click Save
	Then Information saved successfully
