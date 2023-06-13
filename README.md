# NET-MVC-Map Application with Leaflet Library
![image](https://github.com/ZeddHp/NET-MVC-Maps/assets/68005483/10f8d101-3f92-4b1a-8936-3f0f415d3edc)
![image](https://github.com/ZeddHp/NET-MVC-Maps/assets/68005483/4d83e098-bce6-4427-8383-21a82cd5af14)

This repository contains the code for a .NET MVC application that utilizes the Leaflet library to display interactive maps. The application allows users to visualize and explore geographic data.

## Setup

Before running the application, please ensure that you have completed the following steps:

1. **Check Database Connection Strings**

2. **Generate Initial Migrations**: If you haven't already generated the initial migrations for the database, you need to run the following commands in the Package Manager Console (PMC) within Visual Studio:

   ```
   PM> Enable-Migrations
   PM> Add-Migration InitialCreate
   PM> Update-Database
   ```

   These commands will enable migrations, create the initial migration script based on your database models, and apply the changes to the database.

## Running the Application

To run the application, follow these steps:

1. Open the solution file (`NET-MVC-Map.sln`) in Visual Studio.

2. Build the solution to restore NuGet packages and compile the code.

3. Set the startup project to the `NET-MVC-Map` project.

4. Press **F5** or click on the **Start** button to launch the application.

5. Once the application is running, you can access it by navigating to the specified URL in your preferred web browser.

## Usage
...

## Acknowledgements

This application was built using the following technologies and libraries:

- .NET MVC
- Leaflet
- Other dependencies and libraries as listed in the `packages.config` file

We would like to express our gratitude to the developers and contributors of these open-source projects for their invaluable work.
