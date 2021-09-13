Feature: SpecFlowPUTFeature
	Execute and Assert PUT...

	Scenario Outline: check PUT request for update an existing pet 
	Given URI is <uri>
	When Payload is created with  <name>, <id>
	And URI is executed with a <method> method
	Then <statusCode> should match
	And <attribkey1> should be <name>
	And <attribkey2> should be <id>
	Examples:
	| uri                                  | method | name        | id     | attribkey1 | attribkey2 | statusCode | method2 |
	| "https://petstore.swagger.io/v2/pet" | "PUT" | "slg_updated" | 847654321 | "name"     | "id"       | 200        | "GETBYID"   |


	Scenario Outline: Assert Previous PUT response with GET 
	Given URI is <uri>
	When <id> is passed in the URI 
	And URI is executed with a <method2> method 
	Then <statusCode> should match
	And <attribkey1> should be <name>
	And <attribkey2> should be <id>
	
	Examples:
	| uri                                  | method | name        | id     | attribkey1 | attribkey2 | statusCode | method2 |
	| "https://petstore.swagger.io/v2/pet" | "PUT" | "slg_updated" | 847654321 | "name"     | "id"       | 200        | "GETBYID"   |