# Requirements

## Package install

Open (View -> Other Windows -> Package Manager Console)

- **Execute in terminal : Install-Package Microsoft.Data.Sqlite -ProjectName ProjectName ('UI' and 'Library')**
- **Execute in terminal : Install-Package System.Data.Sqlite -ProjectName ProjectName ('UI' and 'Library')**

Type your path to database in config.txt!!!

## Project Overview

This project involves the development of a .NET library and a graphical application designed for Internet and TV providers. The library, exported as a DLL, serves as a Class Library project, while the graphical application is implemented as a Windows Forms App project. The application empowers providers to efficiently manage service packages utilized by clients through a user-friendly interface. Key functionalities include adding new packages and clients, activating/deactivating packages for specific clients, and reading user and package information from a database.

### Key Features

- **Adding new packages and clients** 
- **Activating/deactivating packages for clients**
- **Reading user and package information from a database** 
- **Loading configuration data from the config.txt file for provider customization** 

### Graphical User Interface (GUI)

The GUI enables users to view provider information, list of clients, and packages categorized by type. Users can mark activated packages for a selected client, activate/deactivate packages, and add new clients seamlessly.

### Design Patterns

This project showcases the implementation of several design patterns, including:

- **Singleton**
- **Factory Method**
- **Repository pattern**
- **Builder**
- **Facade**
- **Decorator**
- **Observer**
- **Memento**