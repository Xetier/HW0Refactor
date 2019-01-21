SignIn
==========
tags: signinspec

Test1
-----------------
tags: signinscenario1
* Go to "http://automationpractice.com/index.php"
* Click to button SingIn 
* Fill email_create with "email4@mail.com"
* Click on Submit Create
* I wait "5" seconds
* Click on Mr
* Fill first name in customer_firstname field with "FirstName"
* Fill last name in customer_lastname field with "LastName"
* Fill password in passwd field with "123456"
* Pick day "7  " in birthday day combobox
* Pick month "July " in birthday month combobox
* Pick year "1955  " in birthday year combobox
* Check Sign up for our newsletter! and Receive special offers from our partners!
* Fill Company name in company field with "CompanyTest"
* Fill first address in Address1 field with "Address1"
* Fill second address in Address2 field with "Address2"
* Fill city in City field with "Juliet"
* Pick state "California" in state combobox
* Fill post code in postcode field with "12345"
* Pick country "United States" in country combobox
* Fill additional information in other field with "Additional Test"
* Fill phone in phone field with "+51 0123456789"
* Fill mobile phone in mobile phone field with "+51 999123456"
* Fill Address in alias field with "My address"
* Click on button Register
* I wait "5" seconds
* Check proper username is shown in the header with "FirstName LastName"
* Check my account page contains "?controller=my-account"
* Check Log out action is available showing "Sign out"
