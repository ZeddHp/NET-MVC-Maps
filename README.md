# NET-MVC-Map Application with Leaflet Library
![image](https://github.com/ZeddHp/NET-MVC-Maps/assets/68005483/10f8d101-3f92-4b1a-8936-3f0f415d3edc)
![image](https://github.com/ZeddHp/NET-MVC-Maps/assets/68005483/4d83e098-bce6-4427-8383-21a82cd5af14)

This repository contains the code for a .NET MVC application that utilizes the Leaflet library to display interactive maps. The application allows users to visualize and explore geographic data.

## Setup

Before running the application, please ensure that you have completed the following steps:

1. **Check Database Connection Strings**: Open the `Web.config` file in the project root and verify that the connection strings for your database are correctly configured. Make any necessary adjustments to match your database setup.

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

Upon accessing the application, you will be presented with a map interface powered by Leaflet. The map will display geographic data markers or layers depending on the configured settings.

Use the available controls and options to interact with the map, such as zooming in/out, panning, and toggling different layers or markers. Additional functionalities may be available depending on the specific implementation and customization of the application.

## Contributing

If you would like to contribute to this project, please follow these steps:

1. Fork the repository and clone it to your local machine.

2. Make the necessary changes and additions.

3. Test your changes to ensure they work as intended.

4. Commit your changes and push them to your forked repository.

5. Submit a pull request, describing the changes you have made and any additional relevant information.

We appreciate your contributions to making this project even better!


## Acknowledgements

This application was built using the following technologies and libraries:

- .NET MVC
- Leaflet
- Other dependencies and libraries as listed in the `packages.config` file

We would like to express our gratitude to the developers and contributors of these open-source projects for their invaluable work.
