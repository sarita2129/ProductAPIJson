# ProductAPIJson

Project Structured into following sections
* Models - Contains Models 
* Services - Service Interface and Service class to handle object creation and dependency
* ApiControllers


ProductsController

* Get -  /assets/products/<id>.json​:  Gets the ​static json file for the product with the given ID. 
  
* Post - /api/products​:  Creates a new product with unique Id to the /assets/products/ directory as a JSON file, named by its product ID.

Test Cases

* Get
<table>
    <tr><td>Url : /assets/products/1.json<td></tr>
    <tr><td>Result : 200OK with the json data for the product with id=1<td></tr>
    <tr><td>Url : /assets/products/1.json<td></tr>
    <tr><td>Result : 404 Not found with the message "Product does not exist"<td></tr>

</table>

* Post
<table>
    <tr><td>Url : /assets/products<td></tr>
    <tr><td>input : 
                {
                  "Name": "Product5",
                  "UnitPrice": 1000
                }<td></tr>
    <tr><td>Result : 200OK with the json data of the product that got created ie Product5<td></tr>
    
</table>


