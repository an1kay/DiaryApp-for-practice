# Diary
ASP.Net Practice Diary app for learning about LINQ and MVC.

NOTE: In order to run this app you'll need to do the following

1. Open the project in Visual Studio 2022
2. Have a SQL database configured and ready to connect.
3. Create an appsettings.json in the DiaryApp directory, see the format below.
4. Use the following command in NuGet package console: "add-migration setup"
5. Once you've completed ALL ABOVE STEPS, use update-database in the same NuGet package console. This should updated your database with seeded data and allow you to play around openly with the features.

appsettings.json file example:
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",

  "ConnectionStrings": { "DefaultConnection": "YourConnectionStringHere" }
}

# Personal Statements

Please poke around and take a look at the LINQ statements I used in DiaryEntriesController to handle searching and discriminating by DateTime.

I may update this repo with other functionalities as I learn more about them.