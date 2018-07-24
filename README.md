# TechnicalTest

Background :

Solution is a form that shows the todo list of an employee.  There is a button that creates a default employee and displays its todo list. The projct is hosted on github in https://github.com/FlorianRoudautTabsters/TechnicalTest 
In the thest you will improve this project. 


You should accomplish the following tasks :

I Basic
1) Download the soluton from github
2) create a branch called "NewJoiners" for the changes to come
3) create a class "NewJoiner" that inherits from "Employees". 
4) "NewJoiners" should contain a lsit of "Trainings" object. Trainings should inherits Task.
5) Override the Default method of "NewJoiners" to also fill la list of trainings
6) Send the changes to the github server
7) Explain in Debug mode what happens when the "Show Default Employee" button is clicked

II Intermediate
1) Add a new button called "Show Default New Joiner". This button should do like "Show Default Employee", but show a NewJoiner with the todo list and trainings list.
2) Add a table to store the the New Joiners. 
3) Add CRUDE operations to store the New Joiners objects. 

III Advanced
1) Creates a mehod that loads all the Employees for a given taks using the JOIN SQL keyword.
2) Create a unit test to check that ....
3) Create a pop up that shows each time someone double clicks on the list view
4) Change the "Show Default Employee" button to put the Default method in a background thread.  
