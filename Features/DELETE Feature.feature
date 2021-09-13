Feature: SpecFlowDELETEFeature
	Execute and Assert DELETE...


	Scenario Outline: check DELETE request for removing an existing pet from petstore
	Given URI is <uri>
	When <id> is passed in the URI for DEL 
	And URI is executed with a <method> method
	Then <statusCode> should match
	And <attribkey1> should be "unknown"
	And <attribkey2> should be <id>
	Examples:
	| uri                                  | method |  id     | attribkey1 | attribkey2 | statusCode | method2 |
	| "https://petstore.swagger.io/v2/pet" | "DEL"  | 847654321 | "type"     | "message"       | 200        | "GETBYID"   |


	Scenario Outline: Assert previous DELETE response with GET should return 404 error 
	Given URI is <uri>
	When <id> is passed in the URI for DEL 
	And URI is executed with a <method2> method 
	Then <statusCode> should match
	
	Examples:
	| uri                                  | method |  id     | attribkey1 | attribkey2 | statusCode | method2 |
	| "https://petstore.swagger.io/v2/pet" | "DEL"  | 847654321 | "code"     | "message"       | 404        | "GETBYID"   |
