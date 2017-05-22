Feature: GMTCuttingViewRecord
	View and Edit GMT Production Cutting Record

@mytag
Scenario: View and Edit GmtProduction Cutting Record
	Given Job Code, Date Range, View Button
	When I press View
	Then Grid is loaded with Edit and Lay Chart View
	When I press Edit
	Then Add Cutting Information page is displayed for edit
	When I click Garments Information
	Then Garments Information page is displayed for edit
	And enter required information if need to change
	When click Save button for edit
	Then edited information save successfully



