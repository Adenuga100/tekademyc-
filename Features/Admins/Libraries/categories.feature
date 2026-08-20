Feature: categories

A short summary of the feature
Background: login
Given User navigates to takademy "https://tekademy-admin-app.vercel.app/auth/login"
	When User enters  email "superAdmin@tekademy.io"
	And User enters  password "Password123!"
	And User clicks on login button

@tag1
Scenario: Create a category to Library
	When user click on "Library" menus
	And user click on "Categories" button
	And user click on "Add Category" button
	And user enter category name "DEVS"
	And user enter display order 
	And user click on "Create category" button
	Then A message should be displayed "Resource category created"

	
@tag1
Scenario: Create with existing category name to Library
	When user click on "Library" menus
	And user click on "Categories" button
	And user click on "Add Category" button
	And user enter existing category name "Tester"
	And user enter display order 
	And user click on "Create category" button
	Then A message should be displayed "A resource category with this name already exists"

Scenario: Create a category with a empty category name to Library
	When user click on "Library" menus
	And user click on "Categories" button
	And user click on "Add Category" button
	And user enter existing category name "  "
	And user enter display order 
	And user click on "Create category" button
	Then A message should be displayed "Category name is required."

Scenario: Create a category with a zero display order to Library
	When user click on "Library" menus
	And user click on "Categories" button
	And user click on "Add Category" button
	And user enter category name "DEVS"
	And user click on "Create category" button
	Then A message should be displayed "Resource category created"

Scenario: Verify cancel button is functional to Library
	When user click on "Library" menus
	And user click on "Categories" button
	And user click on "Add Category" button
	And user enter existing category name "Tester"
	And user enter display order 
	And user click on "Create category" button
    And user click on "Cancel" button
	Then user redirected to "All resource categories" page
	
Scenario: Verify x button is functional to Library
	When user click on "Library" menus
	And user click on "Categories" button
	And user click on "Add Category" button
	And user enter existing category name "Tester"
	And user enter display order 
	And user click on "Create category" button
	And user click on x button
	Then user redirected to "All resource categories" page


