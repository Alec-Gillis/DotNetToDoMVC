# DotNetToDoMVC
Brush up on .NET MVC by creating a simple todo app

**Tutorial:**
https://www.youtube.com/watch?v=BfEjDD8mWYg

**Notes:**<br>
*Model* -> Manages data & behavior
  * Data related
  * Consists of classes/objects with properties
  * Uses SQL statements
  * Supplies the controller with lists of objects
 
*View* -> Manages the display of data
  * HTML CSS code (or similar)
  * Usually gets a list of data from the controller
  * Dynamically combines data with HTML in a template
  * Razor (ASP.NET)

*Controller* -> Handles page events & navigation between pages

<br>

*ORM (Object Relationship Model)*
  * Computer generates tables base on classes in application
  * DB updates using migration
  * Entity Framework is Microsoft's ORM
  * Simple for basic applications

*DAO (Data Access Object)*
  * Manually create tables
  * Traditional method of database access
  * Write your own SQL statements
  * DBA's usually prefer DAOs -> Provides more visibility on finding problems
