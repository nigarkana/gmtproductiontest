Feature: GMTLogin
Go to Login Page
Enter User Name
Enter  Password
Click "Login"
Verify Dashborad after Logged In
Click "Remember" to avoid continuous enter user name and password for everytime login


@mytag
Scenario: Login with User Name and Password
	Given I have entered User Name
	And I have entered Password
	When I click Login
	Then Dashboard has shown after user logged in successfully 