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

Scenario: Replace a file in Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Documents\clinc\Chenot Palace Weggis.docx"
	And user select a file "C:\Users\NUGA\Documents\clinc\Cleveland Clinic Executive Health.docx"
	And user click on "Upload" button
	Then A message should be displayed "Resource uploaded"

	
Scenario: Remove a file and upload a new one in Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Documents\clinc\Chenot Palace Weggis.docx"
	And user click on "Remove" button
	And user select a file "C:\Users\NUGA\Documents\clinc\Cleveland Clinic Executive Health.docx"
	And user click on "Upload" button
	Then A message should be displayed "Resource uploaded"

Scenario: Replace a video in Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on "Upload" button
	Then A message should be displayed "Resource uploaded"

Scenario: Remove a video  and upload a new one in Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on "Remove" button
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on "Upload" button
	Then A message should be displayed "Resource uploaded"

Scenario: Remove a file or a video from Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Documents\clinc\Chenot Palace Weggis.docx"
	And user click on "Remove" button
	Then user is unable to click on "Upload" button
	
Scenario: Empty title file in Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title ""
	And user select categories
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Documents\clinc\Chenot Palace Weggis.docx"
	And user clear title field
	Then user is unable to click on "Upload" button

Scenario: Empty category  in Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user enter descriptions "Test Description"
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Documents\clinc\Chenot Palace Weggis.docx"
	Then user is unable to click on "Upload" button

Scenario: Empty description in Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "  "
	And user enter tags "c#"
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on "Remove" button
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on "Upload" button
	Then A message should be displayed "Resource uploaded"

Scenario: Empty tags in Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions "Test automation"
	And user enter tags " "
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on "Remove" button
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on "Upload" button
	Then A message should be displayed "Resource uploaded"


Scenario: Verify that user can click on cancel button in Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions " Test Description"
	And user enter tags " "
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on "Remove" button
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on "Cancel" button
	Then user redirected to "Library & Resources" page

Scenario: Verify that user can click on X button in Library
	When user click on "Library" menus
	And user click on "Upload Resource" button
	And user enter title "Test Title"
	And user select categories
	And user enter descriptions " Test Description"
	And user enter tags " "
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on "Remove" button
	And user select a file "C:\Users\NUGA\Pictures\Camera Roll\WIN_20260115_03_11_12_Pro.mp4"
	And user click on x button
	Then user redirected to "Library & Resources" page
	