Feature: DeleteAndEditCategories

Background: login
Given User navigates to takademy "https://tekademy-admin-app.vercel.app/auth/login"
	When User enters  email "superAdmin@tekademy.io"
	And User enters  password "Password123!"
	And User clicks on login button

@tag1
Scenario: Verify delete button is functional to Library
	When user click on "Library" menus
	And user click on "Categories" button
	And User click on Delete button
	And user click on "Delete" button
	Then A message should be displayed "Resource category deleted"

	@tag1
Scenario: Verify cancel button is functional when delete button is clicked
	When user click on "Library" menus
	And user click on "Categories" button
	And User click on Delete button
	And user click on "Cancel" button
	Then user redirected to "All resource categories" page

Scenario: Verify x button is functional when delete button is clicked
	When user click on "Library" menus
	And user click on "Categories" button
	And User click on Delete button
	And user click on x button
	Then user redirected to "All resource categories" page

Scenario: Verify edit button is functional to Library
	When user click on "Library" menus
	And user click on "Categories" button
	And User click on Edit button
	And user enter category name "DEVS"
	And user enter display order 
	And user click on "Save changes" button
	Then A message should be displayed "Resource category updated"

Scenario: Verify category name is empty when edit button is clicked
	When user click on "Library" menus
	And user click on "Categories" button
	And User click on Edit button
	And user clear category name
	And user enter display order 
	And user click on "Save changes" button
	Then A message should be displayed "Category name is required."

Scenario:Verify zero display order  when edit button is clicked
	When user click on "Library" menus
	And user click on "Categories" button
	And User click on Edit button
	And user enter category name "DEVS"
	And user click on "Save changes" button

Scenario: Verify cancel button is functional when edit button is clicked
	When user click on "Library" menus
	And user click on "Categories" button
	And User click on Edit button
	And user enter category name "DEVS"
	And user enter display order 
	And user click on "Cancel" button
	Then user redirected to "All resource categories" page


Scenario: Verify x button is functional when edit button is clicked
	When user click on "Library" menus
	And user click on "Categories" button
	And User click on Edit button
	And user enter category name "DEVS"
	And user enter display order 
	And user click on x button
	Then user redirected to "All resource categories" page

