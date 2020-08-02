Feature: SellerProfilePage
 As a Seller
 I want to add my profile details

 @mytag
Scenario: Add Description
	Given login to Mars application as a seller
    And navigate to profile page
    When click on the edit button of Description
    Then should be able to Add description
    Examples: 
    | description               |
    | This is dummy description |
     
  @Negative test case
  Scenario: Add blank in Description field
      Given loging to Mars Application as a seller
      And navigate to profile page
      When click on the edit button of discription
      And seller should try to add empty valu in description field
      Then seller should not able to add empty valu in discription field
      Examples: 
    | description|
    ||
   
  @Positive test case
  Scenario: Add language In Language field
    Given as a seller loging to Mars Application
    And seller navigate to profile page
    When seller click on the add language button 
    Then seller should able to add language
    Examples: 
    | language |
    | English  |
  
  @Negative
  Scenario: Add Duplicate language in language field
   Given as a seller loging to Mars Application
   And seller navigate to profile page
   When seller click on the add language button
   Then seller should not be able to add language
   Examples: 
   | language |
   | English  |