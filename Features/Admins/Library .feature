Feature: Library 

A short summary of the feature

Background: login
Given User navigates to takademy "https://tekademy-admin-app.vercel.app/auth/login"
	When User enters  email "superAdmin@tekademy.io"
	And User enters  password "Password123!"
	And User clicks on login button

@tag1
Scenario: Upload a file to Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Documents\clinc\Chenot Palace Weggis.docx"
	And user click on "Upload" button
	Then A message should be displayed "Resource uploaded"

Scenario: Upload a file to Library uncheck Publish immediately
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Documents\clinc\Chenot Palace Weggis.docx"
	And user unclick Publish immediately
	And user click on "Upload" button
	Then A message should be displayed "Resource uploaded"

Scenario: Upload a video less than 50MB.to Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "c:\Users\NUGA\Videos\IMG_5567.MOV"
	And user click on "Upload" button
	Then A message should be displayed "File must be at most 50 MB."

Scenario: Upload a video to Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on "Upload" button
	Then A message should be displayed "Resource uploaded"

Scenario: Upload a video to Library uncheck Publish immediately
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user unclick Publish immediately
	And user click on "Upload" button
	Then A message should be displayed "Resource uploaded"