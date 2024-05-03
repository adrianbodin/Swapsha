# Swapsha

## 📝 Description 

This project is a platform for people to find each other and offer services and get services in return.
They will be able to contact each other and then come up with an agreement of a job that they will do for each other.
The idea behind the entire application was to make it easier and more affordable for people with less money to get help
from other people and swap services with each other.

##  💻 Technologies Used

### Frontend

The frontend uses <ins>**NextJs/React**</ins> I am using this because we are using it in school, but would like to try other
frameworks as well. I think Svelte looks good and very easy syntax to understand. 

### Backend

The backend uses a <ins>**Asp.Net Web Api**</ins> for sending data back and forth to the client and take care of backend logic. 

### Database

The database used is a <ins>**SQL Server**</ins> relational database. I might also add a document database later for some parts
of the application.

## Challenges and Solutions


## What i Learned

The things that i have learned the most on this project is about advanced entity framework and React.
I have gotten alot of knowledge about how entity framework works behind the scenes. I have learnt how 
many to many relationships work in this project, which i have not worked with before. Entity framework is 
very intresting i think, i have learnt how you can pick only some columns from a table when including another table 
in a join for example. This is very handy for better performance because you dont want to send data that is not needed.
Here i put some links to talk/videos about EF that have helped me understand it better: 

[Common mistakes in EF Core - Jernej Kavka - NDC Oslo 2023](https://www.youtube.com/watch?v=dDANjr5MCew&t=3400s)

[Entity Framework (Core) Unchained: Getting the Best Performance from Your ORM - Dan Mallott](https://www.youtube.com/watch?v=ZKVXl2640ps&t=1571s)

## Future Improvements

There is alot that can be added to this platform to make it more interesting. One thing that i would like to implement some time is 
a way to write a digital contract between the two parts before every job is started. This would lower the risk for arguing about 
the job being done, because everything will be written in detail in this contract.

I would probably have to use a third party solution for this to make it secure and follow legal laws. But it would be very fun to build on myself.

## Testing Strategy




<details>
<summary><strong>How you run this locally</strong></summary>

## Run this locally

---

1. Run this command to clone the repository in the directory of your choice.

```bash
git clone https://github.com/adrianbodin/Swapsha
```

---

2. Run this command to go into the project directory. 

```bash
cd Swapsha
```

---

3. Change to to src directory. 

```bash
cd src
```

---

4. Change to the api project to run migrations for the database.

```bash
cd Swapsha.Api
```

---

5. Go into appsettings.Development.json to change the server to your own, you can keep everything after the server.

```json
{
   "DefaultConnection": "Server={YOUR-SERVER-NAME};Database=Swapsha;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
}
```

---

6. Now run this command. This should run all the migrations and create a database with seed data in it. Make sure you got MS sql server installed on your computer.

```bash
dotnet ef database update
```

---

7. Now start up Swapsha.api in visual studio, this should open swagger with all the endpoints.
>[!NOTE]
> You can also use other code editors or IDEs but you might have to start the api from the terminal.  

---

8. Open a new terminal while the api is running and navigate to the swapsha.frontend in the src root directory. Then run this command to install all the dependencies for the frontend 

```bash
npm install
```

---

9. Then after the installation is complete, run this command to start the next.js project.

```bash
npm run dev
```

---

10. Now you should have a local database, an api and a frontend all connected together and ready to be tested, hope it worked!

---

</details>
