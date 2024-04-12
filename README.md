# Swapsha
Fullstack web application for trading skills with eachother

## Steps to run the application:

1. Run this command to clone the repository in the directory of your choice.![img.png](readme-images/img.png)


2. Run this command to go into the project directory. </br>![img_1.png](readme-images/img_1.png)


3. Change to to src directory. </br> ![img_2.png](readme-images/img_2.png)


4. Change to the api project to run migrations for the database.</br> ![img_3.png](readme-images/img_3.png)


5. Go into appsettings.Development.json to change the connection string to your own. Change "RandomServerName" to 
   your own one.
![img_4.png](readme-images/img_4.png)


6. Now run this command. This should run all the migrations and create a database with seed data in it. ![img_5.png](readme-images/img_5.png)


7. Now start up Swapsha.api in visual studio, this should open swagger with all the endpoints.


8. Navigate to the swapsha.frontend in the src root directory. Then run this command to install all the dependencies for the frontend
   ![img_6.png](readme-images/img_6.png)


9. Then after the installation is complete, run this command to start the next.js project. ![img_7.png](readme-images/img_7.png)


10. Now you should have a local database, an api and a frontend all connected together and ready to be tested, hope it worked!