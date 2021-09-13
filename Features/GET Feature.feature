Feature: SpecFlowGETFeature
	Execute and Assert GET...

Scenario Outline: check result for GET ALL
	Given URI is <uri>
	When URI is executed with a <method> method
	Then <statusCode> should match
	Then <attribkey1> should be <attribval1>
	Then <attribkey2> should be <attribval2>

	Examples:
	| uri                               | method | attribkey1 | attribval1 | attribkey2 | attribval2 |statusCode |
	| "https://petstore.swagger.io/v2/store/inventory" | "GETALL"  | "free"    | "1"       |"OK"      | "1"       | 200        |



