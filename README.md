# TechnicalTest

Background :

Solution is a form that shows the todo list of an employee.  There is a button that creates a default employee and displays its todo list. The projct is hosted on github in https://github.com/FlorianRoudautTabsters/TechnicalTest 
In the test you will improve this project. 


You should accomplish the following tasks :

I Basic
1) In the program.cs file, Add method that will load all the tasks that are due in the next week, based on LoadAllTasks(). 
2) create a class "NewJoiner" that inherits from "Employees". NewJoiners should have an IntegrationDate and Former Company fields
3) Create a class Trainings should inherits Task. Trainings should have a StartDate and TrainerId fields
4) Override the Default method of "NewJoiners" class to return a NewJoiner with dummy trainings in the Task list.
5) Create a git branch called "NewJoiners", and send the changes to that branch
6) Launch the application , then explain in Debug mode what happens when the "Show Default Employee" button is clicked

II Intermediate
7) Add a new button called "Show Default New Joiner". This button should do like "Show Default Employee", but show a NewJoiner with the todo list and trainings list.
8) in MySQL workbench. Add a table to store the the NewJoiners and the Trainings.
9) In the DataLayer file, add CRUDE operations to intract with the database for the New Joiners objects. 

III Advanced
10) Create a mehod that loads all the Employees for a given taks using the JOIN SQL keyword.
11) Create a unit test to check that the default employee's tasks contains three entries. 
12) Create a pop up that shows and says "Hello" each time someone double clicks on the list view.
13) Change the "Show Default Employee" button to put the Default method in a background thread.  
