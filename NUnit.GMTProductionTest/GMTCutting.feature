Feature: GMTCutting
	Create Cutting Information and view cutting information

@mytag
Scenario: Add Cutting and Garments Information
	Given Job Code, Cutting Date, Marker No, Lay Chart No, Business Unit, Production Unit, Embellishment Status, Search Supervisor, Table Supervisor and Note
	When Click Garment Information
	Then Garments Information page is displayed
	Given No of Lay, Table No, Order Code, Color
	When Click Add
	Then Grid has loaded
	Given Marker Ratio, QC Pass Quantity, Reject Quantity, Reject Note
	When click Save
	Then Cutting Record is saved successfully
	Given Job Code, Date Range
	When Click View
	Then Gird is loaded with Edit and Laychart View Button
	When click Edit Button
	Then Cutting Information is opened with Edit view
	When click Garments Information
	And edit required information in the grid and other
	When click Save
	Then Cutting information is edited successfully


