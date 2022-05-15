Feature: Rozetka

@DataSource:products.xlsx
Scenario: Check sum in the cart test
	Given User opens <homePage> page
	When User makes search by keyword <keyword>
	And User choose the <brandName> brand
	And User sorts products by <sortValue>
	And User clicks on the first product
	And User clicks Add to cart button
	And User clicks Cart button
	Then User checks the sum in the cart more than <price>


#Examples: 
#| homePage                   | keyword | brandName | sortValue    | price |
#| https://rozetka.com.ua/ua/ | Laptop  | HP        | 2: expensive | 10000 |