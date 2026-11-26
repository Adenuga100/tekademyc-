Feature: CreateNewUser


Background: login
Given User navigates to takademy "https://tekademy-admin-app.vercel.app/auth/login"
	When User enters  email "superAdmin@tekademy.io"
	And User enters  password "Password123!"
	And User clicks on login button

@tag1
Scenario: Create New User in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name
	And user enter last name 
	And user enter email
	And user enter password "Password123!"
	And user enter date of birth 
	And user select any role
	And user click on "Add User" button
	Then A message should be displayed "User created successfully"

	@tag1
Scenario: Create New User with existing email in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name
	And user enter last name 
	And user enter email "adenugaadeyemiisaac@gmail.com"
	And user enter password "Password123!"
	And user enter date of birth 
	And user select any role
	And user click on "Add User" button
	Then A message should be displayed "An account with this email already exists"

Scenario: Create New User with out selecting any role  in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name
	And user enter last name 
	And user enter email "adenugaadeyemiisaac@gmail.com"
	And user enter password "Password123!"
	And user enter date of birth 
	Then user is unable to click on "Add User" button

Scenario: Create New User with super admin  in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name
	And user enter last name 
	And user enter email
	And user enter password "Password123!"
	And user enter date of birth 
	And user select any role "SuperAdmin"
	And user click on "Add User" button
	Then A message should be displayed "Cannot assign SuperAdmin role to sub-admin users"

Scenario: Create New User with date of birth in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name
	And user enter last name 
	And user enter email
	And user enter password "Password123!"
	And user select any role
	And user click on "Add User" button
	Then A message should be displayed "User created successfully"

Scenario: Create New User with empty first name field in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter last name 
	And user enter email
	And user enter password "Password123!"
	And user select any role
	And user click on "Add User" button
	Then A message should be displayed "Please fill out this field." on "firstName" field
	
Scenario: Create New User with empty last name field in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name 
	And user enter email
	And user enter password "Password123!"
	And user select any role
	And user click on "Add User" button
	Then A message should be displayed "Please fill out this field." on "lastName" field

Scenario: Create New User with empty email field in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name 
	And user enter last name
	And user enter password "Password123!"
	And user select any role
	And user click on "Add User" button
	Then A message should be displayed "Please fill out this field." on "email" field

Scenario: Create New User with empty password field in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name 
	And user enter last name
	And user enter email
	And user enter password ""
	And user select any role
	And user click on "Add User" button
	Then A message should be displayed "Please fill out this field." on "password" field

Scenario: Verify eye password  works in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name 
	And user enter last name
	And user enter email
	And user enter password "Password123!"
	And user click on eye icon on password field
	Then user is able to see the password he or she entered in the password field

Scenario: Verify eye hide password  works in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name 
	And user enter last name
	And user enter email
	And user enter password "Password123!"
	And user click on eye icon on password field
	And user click on eye hide icon password field
	Then user is unable to see the password he or she entered in the password field

Scenario: Input 3 or 4 characters in password field in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name 
	And user enter last name
	And user enter email
	And user enter password "Pass"
	And user select any role
	And user click on "Add User" button
	Then A password message should be displayed "Password must be at least 8 characters,Password must contain at least one special character (@$!%*?&#)."

Scenario: Input 8  characters in password field in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name 
	And user enter last name
	And user enter email
	And user enter password "Password"
	And user select any role
	And user click on "Add User" button
    Then A message should be displayed "Password must contain at least one special character (@$!%*?&#)"

Scenario: Input 8  characters and one digit in password field in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name 
	And user enter last name
	And user enter email
	And user enter password "Password2"
	And user select any role
	And user click on "Add User" button
    Then A message should be displayed "Password must contain at least one special character (@$!%*?&#)"

Scenario: Input 8  characters and one special character in password field in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name 
	And user enter last name
	And user enter email
	And user enter password "Password$"
	And user select any role
	And user click on "Add User" button
   Then A message should be displayed "Password must contain at least one digit"

Scenario: Input 8  characters without uppercase and one special character in password field in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name 
	And user enter last name
	And user enter email
	And user enter password "password$"
	And user select any role
	And user click on "Add User" button
   Then A message should be displayed "Password must contain at least one uppercase letter"

Scenario: Input 8 characters without lowercase and one special character in password field in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name 
	And user enter last name
	And user enter email
	And user enter password "PASSWORD$"
	And user select any role
	And user click on "Add User" button
    Then A message should be displayed "Password must contain at least one lowercase letter"

Scenario:Create a New User Who Is at Least 13 Years Old in User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name
	And user enter last name 
	And user enter email
	And user enter password "Password123!"
	And user enters date of birth 
	And user select any role
	And user click on "Add User" button
	Then A message should be displayed "User must be at least 13 years old"

Scenario: verify cancel button works User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name
	And user enter last name 
	And user enter email
	And user enter password "Password123!"
	And user enters date of birth 
	And user select any role
	And user click on "Cancel" button
	Then user redirected to "User Management" page

Scenario: verify x button works User Management
	When user click on "User Management" menus
	And user click on "Add New User" button
	And user enter first name
	And user enter last name 
	And user enter email
	And user enter password "Password123!"
	And user enters date of birth 
	And user select any role
	And user click on x button
	Then user redirected to "User Management" page
	
Scenario: Assign a role on user Management page
	When user click on "User Management" menus
	And user click assign icon 
	And user select any roles
	And user click on "Save role" button
	Then A message should be displayed "Role assigned successfully"
	And user verify the picked role is equal to the role on the user management page 

Scenario: Assign a role as a super admin on user Management page
	When user click on "User Management" menus
	And user click assign icon 
	And user select any roles"SuperAdmin"
	And user click on "Save role" button
	Then A message should be displayed "SuperAdmin role assignment requires a dedicated break-glass process"

Scenario: Admin suspended a Active user on user Management page
	When user click on "User Management" menus 
	And user click suspended icon
	Then A message should be displayed "User suspended"
	And user verify the active user as be suspended user management page


Scenario: Admin Active a suspended on user Management page
	When user click on "User Management" menus 
	And user click on active icon
	Then A message should be displayed "User reactivated"
	And user verify the suspended user as be Active user management page


Scenario: Admin delete user on user Management page
	When user click on "User Management" menus 
	And user click on delete icon
	And user click on "Delete" button
	Then A message should be displayed "User deleted successfully"
	And user verify the delete user has been deleted user management page


Scenario: Admin cancel when deleting a user user on user Management page
	When user click on "User Management" menus 
	And user click on delete icon
	And user click on "Cancel" button
	Then user verify user have not delete


Scenario: Admin Search users by name or email on user Management page
	When user click on "User Management" menus 
	And user enter "Adenuga Adeyemi" on search bar
	Then user view the search name under "User" on the table


Scenario: Admin filter role on user Management page
	When user click on "User Management" menus 
	And user select any role on all roles field 
	Then user view the search name under "Role" on the table

Scenario: Admin filter role with No users yet result and create a new user on user Management page
	When user click on "User Management" menus 
	And user select any roles on all roles field 
	Then user view the search name under "Role" on the table

Scenario: Admin filter status on user Management page
	When user click on "User Management" menus 
	And user select any status on all status field 
	Then user view the search name under "Status" on the table