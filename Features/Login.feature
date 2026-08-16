Feature: Login

A short summary of the feature

@tag1
Scenario: Login with valid credentials
	Given User navigates to takademy "https://tekademy-admin-app.vercel.app/auth/login"
	When User enters  email "superAdmin@tekademy.io"
	And User enters  password "Password123!"
	And User clicks on login button
	Then User should be logged in

Scenario: Login with remember me option
	Given User navigates to takademy "https://tekademy-admin-app.vercel.app/auth/login"
	When User enters  email "superAdmin@tekademy.io"
	And User enters  password "Password123!"
	And user click on checkbox
	And User clicks on login button
	Then User should be logged in

	@tag1
Scenario: Login with invalid password
	Given User navigates to takademy "https://tekademy-admin-app.vercel.app/auth/login"
	When User enters  email "superAdmin@tekademy.io"
	And User enters  password "InvalidPassword123!"
	And User clicks on login button
	Then A message should be displayed "Invalid email or password"

	Scenario: Login with invalid email
	Given User navigates to takademy "https://tekademy-admin-app.vercel.app/auth/login"
	When User enters  email "superAdmin@tekademy.io"
	And User enters  password "InvalidPassword123!"
	And User clicks on login button
	Then A message should be displayed "Invalid email or password"
