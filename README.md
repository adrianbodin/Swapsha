# Swapsha
Fullstack web application for trading skills with eachother

<details>
<summary><strong>How you run this locally</strong></summary>

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
