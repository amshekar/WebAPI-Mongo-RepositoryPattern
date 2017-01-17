# WebAPI-Mongo-RepositoryPattern

Web API with the mongodb

Step 1:

Clone the Code from https://github.com/amshekar/WebAPI-Mongo-RepositoryPattern.git

step 2 Change the Connection string of the MongoDB in the appsettings.json like "MongoConnection": {
"ConnectionString": "mongodb://localhost:27017", "Database": "test" },

step 3: Restore/Build the solution in Visualstudio

Step 4: Run the solution Note :FYI check the launchsettings in launchsettings.json like default launch url "skillboardAPI": { "commandName": "Project", "launchBrowser": true, "launchUrl": "http://localhost:5000/api/imagegallery", "environmentVariables": { "ASPNETCORE_ENVIRONMENT": "Development" }


step 5: open the swagger to test for EX: http://localhost:5000/swagger/ui/index.html


Swagger.json to test the API and Help Documentation of the API http://localhost:5000/swagger/v1/swagger.json
