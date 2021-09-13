Feature: SpecFlowPOST405ErrorFeature
	Simple calculator for adding two numbers

Scenario Outline: check POST request for adding a new pet to petstore
	Given URI is <uri>
	# Create payload with wrong arguments
	When Payload is created with  <name>, <id> 
	And URI is executed with a <method> method
	Then <statusCode> should match
	Examples:
	| uri                                  | method | name        | id     | attribkey1 | attribkey2 | statusCode | method2 |
	| "https://petstore.swagger.io/v2/user/createUsersWithArrayInput" | "POST" | "slg" | 847654321 | "name"     | "id"       | 405        | "GETBYID"   |
