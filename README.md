# Swapsha
Fullstack web application for trading skills with eachother

## Steps to run the application:

1. Run this command to clone the repository in the directory of your choice.![Screenshot 2024-04-12 080309](https://github.com/adrianbodin/Swapsha/assets/105102657/6869be84-d22a-41ea-9144-adf663a9f555)


2. Run this command to go into the project directory. </br>![Screenshot 2024-04-12 080606](https://github.com/adrianbodin/Swapsha/assets/105102657/6be61104-95f2-48a7-98b8-9952ce554db1)



3. Change to to src directory. </br> ![Screenshot 2024-04-12 080726](https://github.com/adrianbodin/Swapsha/assets/105102657/a444d223-112e-4c25-992e-dc1ac81e4da2)



4. Change to the api project to run migrations for the database.</br> ![Screenshot 2024-04-12 080839](https://github.com/adrianbodin/Swapsha/assets/105102657/8a50c883-44e8-49d4-a20f-e480877c15ec)



5. Go into appsettings.Development.json to change the connection string to your own. Change "RandomServerName" to 
   your own one.
![Screenshot 2024-04-12 081404](https://github.com/adrianbodin/Swapsha/assets/105102657/48006ce8-875d-4f71-841c-cf59f6e6ed56)



6. Now run this command. This should run all the migrations and create a database with seed data in it. Make sure you got MS sql server installed on your computer.
![Screenshot 2024-04-12 082230](https://github.com/adrianbodin/Swapsha/assets/105102657/78c2e826-1763-43fa-80d4-1d3084cd017a)


7. Now start up Swapsha.api in visual studio, this should open swagger with all the endpoints.


8. Navigate to the swapsha.frontend in the src root directory. Then run this command to install all the dependencies for the frontend </br>
   ![Screenshot 2024-04-12 083147](https://github.com/adrianbodin/Swapsha/assets/105102657/649d098f-22ef-4185-81f6-fef758181a21)



9. Then after the installation is complete, run this command to start the next.js project. ![Screenshot 2024-04-12 083339](https://github.com/adrianbodin/Swapsha/assets/105102657/09cb60ab-8de9-4d4b-b109-0b4188545ae8)



10. Now you should have a local database, an api and a frontend all connected together and ready to be tested, hope it worked!
