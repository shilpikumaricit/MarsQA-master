Feature: SellerProfilePage
 As a Seller
 I want to add my profile details

 @Positive test cases
 Scenario: Add Description
      Given: I login to Mars application as a seller
      And:I navigate to profile page
      When: I click on the edit button of Description
      Then: I should be able to Add description
      Examples: 
      |description|Hobby|
  @Negative test case
  Scenario: Add blank in Description field
      Given: I loging to Mars Application as a seller
      And: I navigate to profile page
      When: I click on the edit button of discription
      And: Seller should try to add empty valu in description field
      Then: Seller should not able to add empty valu in discription field
     Examples: 
     |description||
  @Positive test case
  Scenario: Add language In Language field
    Given: As a seller loging to Mars Application
    And:   Seller navigate to profile page
    When:  Seller click on the add language button 
    Then:  Seller should able to add language
    Examples: 
    |Language|English|
  @Negative
  Scenario: Add Duplicate language in language field
   Given: As a seller loging to Mars Application
   And: Seller navigate to profile page
   When: Seller click on the add language button
   Then: Seller should not be able to add language
   Examples: 
   |Language|English|
   